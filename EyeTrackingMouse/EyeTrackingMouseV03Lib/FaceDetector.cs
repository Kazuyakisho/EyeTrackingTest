using Accord.Imaging.Filters;
using Accord.Vision.Tracking;
using AForge.Imaging;
using AForge.Imaging.Filters;
using AForge.Math.Geometry;
using EyeTrackingMouseV03Lib.Detection;
using EyeTrackingMouseV03Lib.Filter;
using EyeTrackingMouseV03Lib.Helper;
using EyeTrackingMouseV03Lib.Log;
using EyeTrackingMouseV03Lib.Settings;
using EyeTrackingMouseV03Lib.Utils;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using Point = AForge.Point;

namespace EyeTrackingMouseV03Lib
{
    public class FaceDetector
    {
        private static readonly Lazy<FaceDetector> _instance = new Lazy<FaceDetector>(() => new FaceDetector());

        public static FaceDetector Instance
        {
            get
            {
                return _instance.Value;

            }
        }



        public readonly ETFilterManager FcCriteriaLeftEye;
        public readonly ETFilterManager FcCriteriaRightEye;
        public readonly ETFilterManager FcFace;
#if TRYNEWFILTER
        public readonly FailSafeFilter FcGauss;  
#endif
        private FaceDetector()
        {
#if TRYNEWFILTER
            FcGauss = new FailSafeFilterAggregation();
            var gauss = (FailSafeFilterAggregation) FcGauss;
            gauss.AddFilter(new FailSafeGaussFilter(3,5));
            gauss.AddFilter(new FailSafeGaussFilter(1.5, 5));
            gauss.AddFilter(new FailSafeConvolutionFilter(new int[,]
            {
                {1,0,1},
                {0,0,0},
                {1,0,1}
            }));
#if TRYSERIALIZATION
            FcGauss.Save(Environment.GetFolderPath(Environment.SpecialFolder.Desktop)+"//Test.xml");
#endif
#if TRYDESERIALIZATION
            FcGauss = FailSafeFilter.Load(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "//Test.xml");
#endif
#endif
            FcFace = new ETFilterManager(EnumROI.Face);
            FcFace = DefaultSettings.DefaultFilterSettings(EnumROI.Face, FcFace);

            FcCriteriaLeftEye = new ETFilterManager(EnumROI.LeftEye);
            FcCriteriaLeftEye = DefaultSettings.DefaultFilterSettings(EnumROI.LeftEye, FcCriteriaLeftEye);

            FcCriteriaRightEye = new ETFilterManager(EnumROI.RightEye);
            FcCriteriaRightEye = DefaultSettings.DefaultFilterSettings(EnumROI.RightEye, FcCriteriaRightEye);


            //load defaults
            DefaultSettings.DefaultSettingsEmgu(EnumROI.LeftEye);
            DefaultSettings.DefaultSettingsEmgu(EnumROI.RightEye);
            DefaultSettings.DefaultSettingsEmgu(EnumROI.Nose);
            DefaultSettings.DefaultSettingsAforge(EnumROI.LeftEye);
            DefaultSettings.DefaultSettingsAforge(EnumROI.RightEye);
            DefaultSettings.DefaultSettingsAforge(EnumROI.Face);
            DefaultSettings.DefaultSettingsAforge(EnumROI.Nose);




        }

        private UnmanagedImage _unBmpRightEye;
        private UnmanagedImage _unBmpLeftEye;
        private UnmanagedImage _unmanagedFace;
        private UnmanagedImage _unManagedBothEyes;
        private UnmanagedImage _unmanagedNose;
        private readonly EyesTracker _eyesTracker = new EyesTracker();
        private readonly TiltTracker _tiltTracker = new TiltTracker();
        private readonly Color _rightEyeColor = Color.Aqua;
        private readonly Color _leftEyeColor = Color.Green;
        private readonly Color _tiltTrackerColor = Color.Chocolate;

        //objeckt Marker
        public Camshift CamShiftTracker { get; set; }
        public RectanglesMarker FaceMarker { get; set; }
        public RectanglesMarker EyeRightmarker { get; set; }
        public RectanglesMarker EyeLeftmarker { get; set; }

        public double FaceAngle { get; set; }


        //PbBox 
        public Bitmap BmpRightEye { get; private set; }
        public Bitmap BmpLeftEye { get; private set; }
        public Bitmap BmpRightPupil { get; private set; }
        public Bitmap BmpLeftPupil { get; private set; }
        public Bitmap BmpFaceBackProjection { get; private set; }
        public Bitmap BmpFilterFace { get; private set; }




        // Box Size
        public Size SizePbFaceBox { get; set; }
        public Size SizePbRightPupil { get; set; }
        public Size SizePbLeftPupil { get; set; }
        public Size SizePbFaceBackProjection { get; set; }
        public Size SizeDesktop { get; set; } = Size.Empty;
        public Size SizeVideoSource { get; set; } = Size.Empty;


        public string GetBlinkMessageRightEye { get; private set; } = "";
        public string GetBlinkMessageLeftEye { get; private set; } = "";
        public string GetMessageAngleBetweenEyes { get; private set; }

        public string GetMessangeLengthBeetwennEyes { get; private set; }
        public Color GetBlinkColorRightEye { get; private set; }
        public Color GetBlinkColorLeftEye { get; private set; }

        //bool
        public bool IsMauseMove { private get; set; }
        public bool IsDetecting { private get; set; }
        public bool IsTracking { private get; set; }
        public bool IsFlipVideo { private get; set; }
        public bool IsShowBackProjection { get; set; }
        public bool IsShowObjectAxis { private get; set; }
        public bool IsDrawObjectBox { private get; set; }
        public bool IsDrawTrackingWindow { private get; set; }
        public bool IsShowFaces { private get; set; }
        public bool IsCameraDetected { get; set; }
        public bool IsBackProjektion { private get; set; }
        public bool IsDrawEyes { private get; set; }
        public bool IsOneDesktop { get; set; }
        public bool IsTwoDesktop { private get; set; }
        public bool IsThreeDesktop { private get; set; }
        public bool IsNose { private get; set; }

        //Stabelizer
        public readonly RectStabelizer RectStabLeftEye = new RectStabelizer();
        public readonly RectStabelizer RectStabRightEye = new RectStabelizer();
        public readonly RectStabelizer RectStabNose = new RectStabelizer();

        //Gesture
        private readonly GestureAnalizer _gAna = new GestureAnalizer();

        //show PixelFormat
        public void BackProjektion(ref Bitmap image)
        {
            if (!IsTracking && !IsDetecting && !IsBackProjektion) return;

            lock (this)
            {
                var im = UnmanagedImage.FromManagedImage(image);

                if (IsFlipVideo)
                {
                    var filterFlipImage = new Mirror(false, true);

                    filterFlipImage.ApplyInPlace(im);
                }

                //Track the object
                CamShiftTracker.Smooth = true;
                CamShiftTracker.ProcessFrame(im);

                try
                {
                    var backprojection = CamShiftTracker.GetBackprojection(PixelFormat.Format24bppRgb);
                    im = UnmanagedImage.FromManagedImage(backprojection);
                    //im = FcGauss.ApplyFilters(im);
                }
                catch
                {
                }
                finally
                {
                    image = im.ToManagedImage();
                }
            }
        }

        //Auto Resize
        private int _faceScaleX = 10;
        private int _faceScaleY = 0;
        private int _faceCropFromTop = 10;
        private int _faceCropFromBottem = 10;

        private int _noseScaleX = 10;
        private int _noseScaleY = 0;
        private int _noseCropFromTop = 0;
        private int _noseCropFromBottem = 0;


        public void Detecting(ref Bitmap image)
        {
            if (IsFlipVideo)
            {
                var filterFlipImage = new Mirror(false, true);

                filterFlipImage.ApplyInPlace(image);
            }

            if (!IsDetecting && !IsTracking)
                return;

            lock (this)
            {
                if (IsDetecting)
                {
                    IsDetecting = false;
                    IsTracking = false;

                    var im = UnmanagedImage.FromManagedImage(image);

                    var xscale = image.Width / 160f;
                    var yscale = image.Height / 120f;

                    var resize = new ResizeNearestNeighbor(160, 120);
                    var downSample = resize.Apply(im);

                    var regions = ETSettings.Instance.EtSettingsFace.Detector.ProcessFrame(downSample);

                    if (regions.Length > 0)
                    {
                        CamShiftTracker.Reset();

                        //Will track the first face found
                        var face = regions[0];

                        //Reduce the face size to avoid tracking background
                        var window = new Rectangle(
                            (int)((regions[0].X + regions[0].Width / 2f) * xscale),
                            (int)((regions[0].Y + regions[0].Height / 2f) * yscale),
                            1, 1);

                        window.Inflate(
                            (int)(0.2f * regions[0].Width * xscale),
                            (int)(0.4f * regions[0].Height * yscale));

                        //init tracker
                        CamShiftTracker.SearchWindow = window;
                        CamShiftTracker.ProcessFrame(im);

                        FaceMarker = new RectanglesMarker(window);
                        FaceMarker.ApplyInPlace(im);


                        IsTracking = true;
                        image = im.ToManagedImage();
                    }
                    else
                    {
                        IsDetecting = true;
                    }
                }
                else if (IsTracking)
                {
                    var im = UnmanagedImage.FromManagedImage(image);


                    //Track the object
                    CamShiftTracker.ProcessFrame(im);


                    //Get the obj position
                    var obj = CamShiftTracker.TrackingObject;
                    var wnd = CamShiftTracker.SearchWindow;
                    var wndNose = CamShiftTracker.SearchWindow;

                    ResizeBilinear resizeFace = new ResizeBilinear(SizePbFaceBackProjection.Width, SizePbFaceBackProjection.Height);

                    Crop cropFace = new Crop(wnd);
                    _unmanagedFace = cropFace.Apply(im);

                    wnd = Operations.GetCropRectangleByBottomPoint(wnd, _faceCropFromTop, _faceCropFromBottem, _faceScaleX, _faceScaleY);
                    Crop cropEyes = new Crop(wnd);

                    _unManagedBothEyes = cropEyes.Apply(im);

                    wndNose = Operations.GetCropRectangleByBottomPoint(wndNose, _noseCropFromTop, _noseCropFromBottem, _noseScaleX, _noseScaleY);
                    Crop CropNose = new Crop(wndNose);

                    _unmanagedNose = CropNose.Apply(im);


                    if (IsShowFaces)
                    {

                        _unmanagedFace = resizeFace.Apply(_unmanagedFace);
#if TRYNEWFILTER
                        _unmanagedFace = FcGauss.Apply(_unmanagedFace);
#endif
                        FcFace.ApplyFilter(_unmanagedFace);
                        BmpFilterFace = FcFace.FilterImage;
                        _unmanagedFace.Dispose();

                    }



                    if (IsBackProjektion)
                    {
                        var backprojection = CamShiftTracker.GetBackprojection(PixelFormat.Format24bppRgb);
                        UnmanagedImage imback = UnmanagedImage.FromManagedImage(backprojection);

                        imback = cropFace.Apply(imback);
                        imback = resizeFace.Apply(imback);

                        BmpFaceBackProjection = imback.ToManagedImage(true);
                        imback.Dispose();

                    }

                    if (IsNose)
                    {
                        _tiltTracker.DetectNose(_unmanagedNose);
                        RectStabNose.VelocitiyForLocs = 15;
                        RectStabNose.VelocitiyForRects = 15;
                        Rectangle rectNose = RectStabNose.GetAveravgeRectangle(_tiltTracker.RectangleNoseList, wndNose.Location);
                        Drawing.Rectangle(im, rectNose, _tiltTrackerColor);
                        Drawing.Rectangle(im, wndNose, Color.White);

                        //Auto resize eyes region
                        if (rectNose.Y != 0 && rectNose.Height != 0 && rectNose.Y != 0 && rectNose.Height != 0)
                        {

                            if ((rectNose.Y) - wndNose.Y >= 25)
                            {

                                _noseCropFromTop++;

                            }

                            if (wnd.Y + wndNose.Height - (rectNose.Y + rectNose.Height) >= 25)
                            {

                                _noseCropFromBottem++;

                            }


                        }
                        else
                        {

                            _noseCropFromTop = wnd.Height * 2 / 4;
                            _noseCropFromBottem = -(wnd.Height * 2 / 4);

                        }
                    }

                    if (IsDrawEyes)
                    {
                        ResizeBilinear resizeEye = new ResizeBilinear(154, 106);

                        _eyesTracker.DetectEyes(_unManagedBothEyes);

                        RectStabLeftEye.VelocitiyForRects = 15;
                        RectStabLeftEye.VelocitiyForLocs = 10;
                        RectStabLeftEye.RectSizeScale = -5;


                        RectStabRightEye.VelocitiyForRects = 15;
                        RectStabRightEye.VelocitiyForLocs = 10;
                        RectStabRightEye.RectSizeScale = -5;


                        Rectangle leftEye = RectStabLeftEye.GetAveravgeRectangle(_eyesTracker.LeftEye, wnd.Location);
                        Rectangle rightEye = RectStabRightEye.GetAveravgeRectangle(_eyesTracker.RightEye, wnd.Location);

                        //Auto resize eyes region
                        if (leftEye.Y != 0 && leftEye.Height != 0 && rightEye.Y != 0 && rightEye.Height != 0)
                        {

                            if ((leftEye.Y + rightEye.Y) / 2 - wnd.Y >= 25)
                            {

                                _faceCropFromTop++;

                            }

                            if (wnd.Y + wnd.Height - (leftEye.Y + leftEye.Height + rightEye.Y + rightEye.Height) / 2 >= 25)
                            {

                                _faceCropFromBottem++;

                            }


                        }
                        else
                        {

                            _faceCropFromTop = 10;
                            _faceCropFromBottem = 20;

                        }

                        // _faceCropFromTop = 20;


                        if (_eyesTracker.LeftEye != null && _eyesTracker.LeftEye.Count != 0 && leftEye.Y != 0 &&
                            leftEye.Height != 0)
                        {
                            _gAna.FoundLeftEye = true;
                            //Crop and resize Image
                            Crop filterCrop = new Crop(leftEye);

                            _unBmpLeftEye = filterCrop.Apply(im);
                            _unBmpLeftEye = resizeEye.Apply(_unBmpLeftEye);

                            //BlobsProcessing
                            FcCriteriaLeftEye.IsFilterTrackingBlobs = true;
                            FcCriteriaLeftEye.TrackingBlobs.IsFilterBlobs = true;
                            FcCriteriaLeftEye.TrackingBlobs.IsTrackingBoxFixSize = false;
                            FcCriteriaLeftEye.TrackingBlobs.TrackingVelocityLocs = 15;
                            FcCriteriaLeftEye.TrackingBlobs.TrackingVelocityRects = 15;
                            FcCriteriaLeftEye.TrackingBlobs.TrackingBoxFixSize = new Size(30, 30);
                            FcCriteriaLeftEye.TrackingBlobs.TrackingBoxSizeScale = 12;
                            FcCriteriaLeftEye.TrackingBlobs.BlobMinHeight = 2;
                            FcCriteriaLeftEye.TrackingBlobs.BlobMinWidth = 20;
                            FcCriteriaLeftEye.TrackingBlobs.BlobMaxHeight = 100;
                            FcCriteriaLeftEye.TrackingBlobs.BlobMaxWidth = 200;
                            FcCriteriaLeftEye.TrackingBlobs.IsCheckCircle = false;



                            //Filterring
                            FcCriteriaLeftEye.ApplyFilter(_unBmpLeftEye);

                            Rectangle rectPupil = FcCriteriaLeftEye.TrackingBlobs.StabledBlobRect;
                            Crop CropPupil = new Crop(rectPupil);
                            ResizeBilinear resizePupil = new ResizeBilinear(SizePbLeftPupil.Width,
                                SizePbLeftPupil.Height);

                            if (rectPupil.Height != 0 && rectPupil.Width != 0)
                            {
                                var pupil = UnmanagedImage.FromManagedImage(FcCriteriaLeftEye.FilterImage);
                                if (rectPupil.Height < SizePbLeftPupil.Height || rectPupil.Width < SizePbLeftPupil.Width)
                                {
                                    // Avoid Image Properties Exception
                                    pupil = CropPupil.Apply(pupil);
                                }

                                pupil = resizePupil.Apply(pupil);
                                BmpLeftPupil = pupil.ToManagedImage();
                            }


                            BmpLeftEye = FcCriteriaLeftEye.FilterImage;
                            _unBmpLeftEye.Dispose();
                            _eyesTracker.LeftEye.Clear();

                        }
                        else
                        {
                            _gAna.FoundLeftEye = false;
                        }



                        Drawing.Rectangle(im, leftEye, _leftEyeColor);

                        if (_eyesTracker.RightEye != null && _eyesTracker.RightEye.Count != 0 && rightEye.X != 0 &&
                            rightEye.Y != 0)
                        {

                            _gAna.FoundRightEye = true;

                            Crop filterCrop = new Crop(rightEye);
                            _unBmpRightEye = filterCrop.Apply(im);
                            _unBmpRightEye = resizeEye.Apply(_unBmpRightEye);

                            //Blobsprocessing 
                            FcCriteriaRightEye.IsFilterTrackingBlobs = true;
                            FcCriteriaRightEye.TrackingBlobs.IsFilterBlobs = true;
                            FcCriteriaRightEye.TrackingBlobs.IsTrackingBoxFixSize = false;
                            FcCriteriaRightEye.TrackingBlobs.TrackingVelocityLocs = 5;
                            FcCriteriaRightEye.TrackingBlobs.TrackingVelocityRects = 5;
                            FcCriteriaRightEye.TrackingBlobs.TrackingBoxFixSize = new Size(30, 30);
                            FcCriteriaRightEye.TrackingBlobs.TrackingBoxSizeScale = 12;
                            FcCriteriaRightEye.TrackingBlobs.BlobMinHeight = 2;
                            FcCriteriaRightEye.TrackingBlobs.BlobMinWidth = 20;
                            FcCriteriaRightEye.TrackingBlobs.BlobMaxHeight = 100;
                            FcCriteriaRightEye.TrackingBlobs.BlobMaxWidth = 200;



                            FcCriteriaRightEye.ApplyFilter(_unBmpRightEye);
                            //  FcCriteriaRightEye.TrackingBlobs.BlobsProcessing(_unBmpRightEye);


                            Rectangle rectPupil = FcCriteriaLeftEye.TrackingBlobs.StabledBlobRect;
                            Crop CropPupil = new Crop(rectPupil);
                            ResizeBilinear resizePupil = new ResizeBilinear(SizePbRightPupil.Width,
                                SizePbRightPupil.Height);

                            if (rectPupil.Height != 0 && rectPupil.Width != 0)
                            {
                                var pupil = UnmanagedImage.FromManagedImage(FcCriteriaRightEye.FilterImage);
                                if (rectPupil.Height < SizePbLeftPupil.Height || rectPupil.Width < SizePbLeftPupil.Width)
                                {
                                    // Avoid Image Properties Exception
                                    pupil = CropPupil.Apply(pupil);
                                }

                                pupil = resizePupil.Apply(pupil);
                                BmpRightPupil = pupil.ToManagedImage();
                            }


                            BmpRightEye = FcCriteriaRightEye.FilterImage;



                            _eyesTracker.RightEye.Clear();

                        }
                        else
                        {
                            _gAna.FoundRightEye = false;
                        }

                        Drawing.Rectangle(im, rightEye, _rightEyeColor);

                        _gAna.DoGestureAnalyser(FcCriteriaRightEye.TrackingBlobs.StabledBlobRect,
                            FcCriteriaLeftEye.TrackingBlobs.StabledBlobRect, FcCriteriaRightEye.TrackingBlobs.BlobCount,
                            FcCriteriaLeftEye.TrackingBlobs.BlobCount, RectStabRightEye.GetLocDats,
                            RectStabLeftEye.GetLocDats, RectStabLeftEye.GetLocDatsMax, RectStabRightEye.GetLocDatsMax);
                        _gAna.FoundRightEye = false;
                        _gAna.FoundLeftEye = false;

                        GetBlinkMessageRightEye = _gAna.StateTextRightEye;
                        GetBlinkMessageLeftEye = _gAna.StateTextLeftEye;
                        GetBlinkColorLeftEye = _gAna.StateColorLeftEye;
                        GetBlinkColorRightEye = _gAna.StateColorRightEye;


                        if (rightEye != null && leftEye != null && RectStabLeftEye != null && RectStabRightEye != null &&
                            RectStabLeftEye.CurrentRectangle.Width != 0 && RectStabRightEye.CurrentRectangle.Width != 0)
                        {

                            try
                            {
                                LineSegment segment = new LineSegment(RectStabRightEye.GetCenterPoint,
                                    RectStabLeftEye.GetCenterPoint);

                                Drawing.Line(im, segment.Start.Round(), segment.End.Round(), Color.DarkRed);
                                var angle =
                                    Math.Round(
                                        180 - Operations.GetAngleFromPoint(segment.Start.Round(), segment.End.Round()),
                                        2);
                                GetMessageAngleBetweenEyes = angle < 180 ? "Angle: " + angle : "Angle: " + (angle - 360);

                                GetMessangeLengthBeetwennEyes = "Distance " +
                                                                Math.Round(
                                                                    Operations.GetLengthFromAxis(segment.Start.Round(),
                                                                        segment.End.Round()), 2).ToString();

                            }
                            catch (Exception ex)
                            {
                                ErrorLogger.ProcessException(ex, false);
                            }
                        }


                    }




                    if (IsShowObjectAxis)
                    {
                        var axis = obj.GetAxis();
                        var axisVertical = obj.GetAxis(AxisOrientation.Vertical);



                        //Draw X/Y Axis
                        if (axis != null)
                        {
                            Drawing.Line(im, axis.Start.Round(), axis.End.Round(), Color.Red);
                            Drawing.Line(im, axisVertical.Start.Round(), axisVertical.End.Round(), Color.Red);

                            FaceAngle = Operations.GetAngleFromPoint(axis.Start.Round(), axis.End.Round());
                        }
                        else IsDetecting = true;
                    }

                    if (IsMauseMove)
                    {
                        var aH = obj.GetAxis();
                        var aV = obj.GetAxis(AxisOrientation.Vertical);


                        Point? interSect = aH.GetIntersectionWith(aV);

                        var width = 0;

                        if (IsTwoDesktop)
                        {
                            width = SizeDesktop.Width * 2;
                        }
                        else if (IsThreeDesktop)
                        {
                            width = SizeDesktop.Width * 3;
                        }
                        else
                        {
                            width = SizeDesktop.Width;
                        }


                        var screenXv = width / SizeVideoSource.Width;
                        var screenYv = SizeDesktop.Height / SizeVideoSource.Height;

                        var posX = interSect.Value.X * screenXv;
                        var posY = interSect.Value.Y * screenYv;


                        MouseController.MouseController.MoveTo((int)posX, (int)posY);


                    }


                    if (IsDrawObjectBox && IsDrawTrackingWindow)
                    {
                        FaceMarker = new RectanglesMarker(wnd, obj.Rectangle);
                    }
                    else if (IsDrawObjectBox)
                    {
                        FaceMarker = new RectanglesMarker(obj.Rectangle);
                    }
                    else if (IsDrawTrackingWindow)
                    {
                        FaceMarker = new RectanglesMarker(wnd);
                    }
                    else if (IsDrawEyes)
                    {

                    }
                    else
                    {
                        FaceMarker = null;
                    }

                    FaceMarker?.ApplyInPlace(im);
                    EyeLeftmarker?.ApplyInPlace(im);
                    EyeRightmarker?.ApplyInPlace(im);
                    image = im.ToManagedImage();

                    im.Dispose();
                }
                else
                {

                    if (FaceMarker != null)
                        image = FaceMarker.Apply(image);
                    if (EyeLeftmarker != null)
                        image = EyeLeftmarker.Apply(image);
                    if (EyeRightmarker != null)
                        image = EyeRightmarker.Apply(image);
                }

                //image.Dispose();

            }
        }
    }
}