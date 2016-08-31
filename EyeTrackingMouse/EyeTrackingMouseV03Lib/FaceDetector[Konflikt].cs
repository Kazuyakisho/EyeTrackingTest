using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using Accord.Imaging.Filters;
using Accord.Math;
using Accord.Vision.Detection;
using Accord.Vision.Detection.Cascades;
using Accord.Vision.Tracking;
using AForge;
using AForge.Imaging;
using AForge.Imaging.Filters;
using AForge.Math.Geometry;
using AForge.Video;
using DotImaging.Primitives2D;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Image = AForge.Imaging.Image;
using Matrix = System.Drawing.Drawing2D.Matrix;
using Point = System.Drawing.Point;
using Rectangle = System.Drawing.Rectangle;
using Size = System.Drawing.Size;

namespace EyeTrackingMouseV03Lib
{
    public class FaceDetector
    {
       
        //object detector
        private HaarObjectDetector detector { get; set; }

        //objeckt tracker
        public Camshift tracker { get; set; } 

        //HaarCascade
        private HaarCascade haarCascade { get; set; }

        //window marker
        public RectanglesMarker marker { get; set; }

       
        //bitmab face


        //Faces
        public Bitmap bmpFaceRGB { get; set; }
        // bitmap face gray
        public Bitmap bmpFaceGray { get; set; }

        //Face angle / object angle
        public Bitmap bmpFaceRotate { get; set; }
        public double faceAngle { get; set; }


        //Backprojektion
        public Bitmap bmpFaceBackProjection { get; set; }


        //PbBox Eyes
        public  Bitmap bmpRightEye { get; set; }
        public Bitmap bmpLeftEye { get; set; }

        public Bitmap bmpRightEyeFilter { get; set; }
        public Bitmap bmpLeftEyeFilter { get; set; }



        //Picture Box Size
        public Size pbFaceBoxSize { get; set; }
        public Size pbRightEye { get; set; }
        public Size pbLeftEye { get; set; }
        public Size pbFaceBackProjection { get; set; }

        //bool
        public bool isDetecting { get; set; }
        public bool isTracking { get; set; }
        public bool isFlipVideo { get; set; }
        public bool isTrackingEyes { get; set; }
        public bool isShowEyes { get; set; }
        public bool isStabelizeHeadPosition { get; set; }
        public bool isShowBackProjection { get; set; }
        public bool isShowObjectAxis { get; set; }
        public bool isDrawObjectBox { get; set; }
        public bool isDrawTrackingWindow { get; set; }
        public bool isShowFaces { get; set; }
        public bool isCameraDetected { get; set; }

        //Face Filter Bool
        public bool isFaceFilterGrayScale { get; set; }
        public bool isFaceFilterInvert { get; set; }
        public bool isFaceFilterColorChange { get; set; }
        public bool isFaceFilterThresHold { get; set; }
        public bool isFaceFilterContour { get; set; }
        public bool isEyeFilterEllipse { get; set; }
        public bool isEyeFilterCircle{ get; set; }

        //statistic length
        private const int STAT_LENGTH = 15;
        //current statistic index
        public int statIndex = 0;
        //ready statistics values
        public int statReady = 0;
        //statistic array
        private int[] statCount = new int[STAT_LENGTH];

        //Filter
        private readonly Filter[] filCrop;
        private readonly Filter[] filResize;
        private readonly Filter[] filCropAndResize;
        private readonly Filter[] filGray;
        private readonly Filter[] filRotate;
        private readonly Filter[] filFlipVertikal;


        public FaceDetector()
        {
            haarCascade = new FaceHaarCascade();
            detector = new HaarObjectDetector(haarCascade, 25, ObjectDetectorSearchMode.Single, 1.2f, ObjectDetectorScalingMode.GreaterToSmaller);

            filFlipVertikal = new[]
            {
                Filter.ImgFilterFlipVertikal
            };

            filResize = new[]
            {
                Filter.ImgFilterResizeBilinear
            };

            filCrop = new[]
            {
                Filter.ImgFilterCrop
            };
            filCropAndResize = new[]
            {
                Filter.ImgFilterCrop,
                Filter.ImgFilterResizeBilinear
            };


            filGray = new[]
            {
                Filter.ImgFilterCrop,
                Filter.ImgFilterGrayScale,
                Filter.ImgFilterResizeBilinear
            };



            filRotate = new[]
            {
                Filter.ImgFilterCrop,
                Filter.ImgFilterRotate,
                Filter.ImgFilterResizeBilinear
            };



        }

        public string calculateFPS(IVideoSource source)
        {
            

            if (source != null)
            {
                // get number of frames for the last second
                statCount[statIndex] = source.FramesReceived;

                // increment indexes
                if (++statIndex >= STAT_LENGTH)
                    statIndex = 0;
                if (statReady < STAT_LENGTH)
                    statReady++;

                float fps = 0;

                // calculate average value
                for (int i = 0; i < statReady; i++)
                {
                    fps += statCount[i];
                }
                fps /= statReady;

                statCount[statIndex] = 0;

                fps *= 10;

                return fps.ToString("F2") + " fps";
            }
            return "";
        }

       

        //show PixelFormat
        public void BackProjektion(ref Bitmap image)
        {
            if (!isTracking && !isDetecting) return;
          
            lock (this)
            {
               
                    UnmanagedImage im = UnmanagedImage.FromManagedImage(image);

                if (isFlipVideo)
                {
                    Mirror filterFlipImage = new Mirror(false, true);

                    filterFlipImage.ApplyInPlace(im);
                }

                //Track the object
                tracker.ProcessFrame(im);

                    Bitmap backprojection = tracker.GetBackprojection(PixelFormat.Format24bppRgb);
                        im = UnmanagedImage.FromManagedImage(backprojection);

                    image = im.ToManagedImage();

             
            }
        }


        public void Detecting(ref Bitmap image )
        {
            if (isFlipVideo)
            {
                Mirror filterFlipImage = new Mirror(false, true);

                filterFlipImage.ApplyInPlace(image);
            }

            if (!isDetecting && !isTracking)
                return ;

            lock (this)
            {
               

                if (isDetecting) { 
                    isDetecting = false;
                    isTracking = false;

                    UnmanagedImage im = UnmanagedImage.FromManagedImage(image);

                    float xscale = image.Width/160f;
                    float yscale = image.Height/120f;

                    ResizeNearestNeighbor resize = new ResizeNearestNeighbor(160, 120);
                    UnmanagedImage downSample = resize.Apply(im);

                    Rectangle[] regions = detector.ProcessFrame(downSample);

                    if (regions.Length > 0)
                    {
                        tracker.Reset();

                        //Will track the first face found
                        Rectangle face = regions[0];

                        //Reduce the face size to avoid tracking background
                        Rectangle window = new Rectangle(
                            (int) ((regions[0].X + regions[0].Width/2f)*xscale),
                            (int) ((regions[0].Y + regions[0].Height/2f)*yscale),
                            1, 1);

                        window.Inflate(
                            (int) (0.2f*regions[0].Width*xscale),
                            (int) (0.4f*regions[0].Height*yscale));

                        //init tracker
                        tracker.SearchWindow = window;
                        tracker.ProcessFrame(im);

                        marker = new RectanglesMarker(window);
                        marker.ApplyInPlace(im);

                        
                        isTracking = true;
                         image=  im.ToManagedImage();




                    }
                    else
                    {
                        isDetecting = true;
                        
                    }
                }else if (isTracking)
                {
                    UnmanagedImage im = UnmanagedImage.FromManagedImage(image);

                    //Track the object
                    tracker.ProcessFrame(im);

                    //Get the obj position
                    var obj = tracker.TrackingObject;
                    var wnd = tracker.SearchWindow;

                    if (isTrackingEyes)
                    {
                        //Errors
                        Rectangle rectRightEye = new Rectangle(wnd.Location + new Size(0, wnd.Height/4), new Size(wnd.Width/2, wnd.Height/3));
                        Rectangle rectLeftEye = new Rectangle(wnd.Location+new Size(wnd.Width / 2, wnd.Height/4), new Size(wnd.Width/2, wnd.Height /3)); ;

                        Rectangle bigRectAroundFace = new Rectangle(wnd.Location, new Size(wnd.Width + 20, wnd.Height + 20)); ;
                        try
                        {
                         
                            Bitmap bmp = GetFilter(filRotate, image, pbFaceBoxSize.Width, pbFaceBoxSize.Height, 0,
                                bigRectAroundFace);

                            //Test track eyes
                            Bitmap bmpClone = bmp.Clone() as Bitmap;

                            //FaceDetectorHaarCascade.HighlightAndDisplayFaces(bmp);

                            bmpFaceRotate = FaceDetectorHaarCascade.HighlightAndDisplayFaces(bmp) as Bitmap;
                            

                            //DoesntWork

                            Invert a = new Invert();
                            bmpClone = a.Apply(bmpClone);
                            //Image.FormatImage(ref bmpClone);
                            //apply grayscale
                            //IFilter filterGrayScale = Grayscale.CommonAlgorithms.BT709;

                            //bmpClone = filterGrayScale.Apply(bmpClone);

                            Threshold th = new Threshold(220);

                            bmpClone = th.Apply(bmpClone);
                            
                            //find biggels object
                            BlobCounter bl = new BlobCounter();
                            int i = bl.ObjectsCount;
                            ExtractBiggestBlob fil = new ExtractBiggestBlob();
                          //  bmpClone = fil.Apply(bmpClone);

                            bmpFaceRGB = bmpClone;

                            //find eye pupils
                            //int x = 0;
                            //int y = 0;
                            //int h = 0;
                            //if (i > 0)
                            //{
                            //    fil.Apply(bmpClone);
                            //    x = fil.BlobPosition.X;
                            //    y = fil.BlobPosition.Y;
                            //    h = fil.Apply(bmpClone).Height;
                            //}

                            //Rectangle section = new Rectangle(new Point(x - h, y - h), new Size(3 * h, 3 * h));
                            //Drawing.Rectangle(im, section, Color.Red);
                         

                            bmpLeftEye = GetFilter(filCropAndResize, bmpClone, pbLeftEye.Width, pbLeftEye.Height, 0,
                               rectLeftEye);

                           
                       

                        }
                        catch
                        {

                        }
                       
                    }


                    if (isShowObjectAxis || isStabelizeHeadPosition)
                    {
                        LineSegment axis = obj.GetAxis();
                        LineSegment axisVertical = obj.GetAxis(AxisOrientation.Vertical);
                        
                        
                        //Draw X Axis
                        if (axis != null)
                        {
                            Drawing.Line(im, axis.Start.Round(), axis.End.Round(), Color.Red);
                            Drawing.Line(im, axisVertical.Start.Round(), axisVertical.End.Round(), Color.Red);

                            faceAngle = GetAngleFromPoint(axis.Start.Round(), axis.End.Round());

                            

                            if(isStabelizeHeadPosition)
                            {
                                Rectangle test = obj.Rectangle;

                                test.Height += 20;
                                test.Width += 20;
                                test.X -= 10;
                                test.Y -= 10;

                                Drawing.Rectangle(im, test, Color.Red);

                                if (isTrackingEyes)
                                {
                                    Bitmap bmp = GetFilter(filRotate, image, pbFaceBoxSize.Width,
                                        pbFaceBoxSize.Height,
                                        faceAngle, test);
                                   // bmpFaceRotate = FaceDetectorHaarCascade.HighlightAndDisplayFaces(bmp) as Bitmap;
                                }
                                else
                                {
                                    bmpFaceRotate = GetFilter(filRotate, image, pbFaceBoxSize.Width, pbFaceBoxSize.Height,
                                  faceAngle, test);
                                }
                               
                               
                            }

                        }
                        else isDetecting = true;
                        
                    }



                    if (isDrawObjectBox && isDrawTrackingWindow)
                    {
                        marker = new RectanglesMarker(new Rectangle[] {wnd, obj.Rectangle});
                       

                    }
                    else if (isDrawObjectBox)
                    {
                        marker = new RectanglesMarker(obj.Rectangle);

                        
                    }
                    else if (isDrawTrackingWindow)
                    {
                        marker = new RectanglesMarker((Rectangle) wnd);

                      
                    } 
                    else
                    {
                        marker = null;
                    }



                    if (isShowFaces)
                    {
                        try
                        {

                             
                            if(!isTrackingEyes) bmpFaceRGB = GetFilter(filCropAndResize, image, pbFaceBoxSize.Width, pbFaceBoxSize.Height, 0, wnd);

                           
                            bmpFaceGray = GetFilter(filGray, image, pbFaceBoxSize.Width, pbFaceBoxSize.Height, 0, wnd);

                            Bitmap backprojection = tracker.GetBackprojection(PixelFormat.Format24bppRgb);
                            bmpFaceBackProjection = GetFilter(filCropAndResize, backprojection,
                                pbFaceBackProjection.Width, pbFaceBackProjection.Height,0, wnd);
                            
                        }
                        catch (ArgumentException)
                        {
                            
                        }

                    }

                    if (marker != null)
                        marker.ApplyInPlace(im);
                    image=  im.ToManagedImage();
                }
                else
                {
                    if(marker != null)
                        image = marker.Apply(image);
                }
            }
        }

        private static double GetAngleFromPoint(IntPoint startPoint, IntPoint endPoint)
        {
            double xDiff = startPoint.X - endPoint.X;
            double yDiff = startPoint.Y - endPoint.Y;

            return Math.Atan2(yDiff, xDiff)*180.0/Math.PI;
        }

        private static double GetLengthFromAxis(IntPoint startPoint, IntPoint endPoint)
        {
            return Math.Sqrt(Math.Pow(endPoint.X - startPoint.X, 2)+ Math.Pow(endPoint.Y - startPoint.Y, 2));
        }


         public enum Filter
        {
            ImgFilterResizeBilinear,
            ImgFilterCrop,
            ImgFilterGrayScale,
            ImgFilterGrayScaleCommon,
            ImgFilterRotate,
            ImgFilterFlipVertikal

        }

        static Bitmap GetFilter(Filter[] filter, Bitmap bmp, int width = 0, int height = 0, double angle = 0, Rectangle rect = new Rectangle())
        {
            
           
          //  Bitmap bmpFilter = new Bitmap(bmp);

            foreach (Filter fil in filter)
            {
                if (fil == Filter.ImgFilterCrop)
                {
                    if (!rect.IsEmpty)
                    {
                        Crop filterCrop = new Crop(rect);
                        bmp = filterCrop.Apply(bmp);

                    }

                }else if (fil == Filter.ImgFilterResizeBilinear && width != 0 && height!=0)
                {
                    ResizeBilinear filterResize = new ResizeBilinear(width, height);
                    bmp = filterResize.Apply(bmp);

                }
                else if (fil == Filter.ImgFilterGrayScale)
                {
                    Grayscale filterGray = new Grayscale(0.2125, 0.7154, 0.0721);
                    bmp = filterGray.Apply(bmp);
                }
                else if (fil == Filter.ImgFilterGrayScaleCommon)
                {

                }else if (fil == Filter.ImgFilterRotate && angle != 0)
                {
                    RotateBilinear filterRotate = new RotateBilinear(angle);
                    bmp = filterRotate.Apply(bmp);

                }else if (fil == Filter.ImgFilterFlipVertikal)
                {
                    Mirror filterFlipImage = new Mirror(false, true);

                    bmp = filterFlipImage.Apply(bmp);
                }
            }

            return bmp;


        }

        
        

       
    }
}
