using Accord.Imaging;
using Accord.Imaging.Filters;
using Accord.Math.Geometry;
using AForge;
using AForge.Imaging;
using AForge.Imaging.Filters;
using EyeTrackingMouseV03Lib.Helper;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;

namespace EyeTrackingMouseV03Lib.Filter
{
    public class ETFilterForEdgeDetection : INotifyBase
    {

        private UnmanagedImage _unmanagedImage;
        private EnumROI _instanceOf;

        public ETFilterForEdgeDetection(EnumROI instanceOf)
        {
            _instanceOf = instanceOf;
        }
        public UnmanagedImage Filtering(UnmanagedImage image)
        {

            lock (this)
            {

                _unmanagedImage = image;

                if (FilterProof())
                {

                    return _unmanagedImage;

                }
                else
                {
                    return image;
                }



            }
        }


        #region Filtering Proof

        private bool FilterProof()
        {
            IsHoughTransform = false; //doesn't work

            var erg = true;


            if (IsFilterContour) erg = erg && ProofIsContour();
            if (IsSobelEdgedetect) erg = erg && ProofIsSobelEdgeDetector();
            if (IsFastCornerDetection) erg = erg && ProofIsFastCornerDetector();
            if (IsCornerDetectionHarris) erg = erg && ProofIsCornerDetectionHarris();
            if (IsCanny) erg = erg && ProofIsCanny();
            if (IsSURFEdge) erg = erg && ProofIsSURFEdgeDetector();
            if (IsGaborFilter) erg = erg && ProofIsGabor();
            if (IsHoughTransform) erg = erg && ProofIsHough();

            return erg;
        }
        #endregion

        #region Filter Contour

        public bool IsFilterContour
        {
            get { return GetValue<bool>(_instanceOf); }
            set { SetValue(value, _instanceOf); }
        }

        public byte ContourThreshold
        {
            get { return GetValue<byte>(_instanceOf); }
            set { SetValue(value, _instanceOf); }
        }

        public int ContourKernelForPeaks
        {
            get { return GetValue<int>(_instanceOf); }
            set { SetValue(value, _instanceOf); }
        }

        public int ContourSupressionForPeaks
        {
            get { return GetValue<int>(_instanceOf); }
            set { SetValue(value, _instanceOf); }
        }

        public DoubleRange ContourThetaForPeaks
        {
            get { return GetValue<DoubleRange>(_instanceOf); }
            set { SetValue(value, _instanceOf); }
        }

        private readonly BorderFollowing Bf = new BorderFollowing(10);
        private KCurvature Kcurv = new KCurvature(30, new DoubleRange(0, 45));

        private bool ProofIsContour()
        {
            if (_unmanagedImage == null) return false;

            UnmanagedImage imageTemp = _unmanagedImage;

            if (imageTemp.PixelFormat != PixelFormat.Format8bppIndexed)
            {


                imageTemp = _unmanagedImage.ConvertToFormat(PixelFormat.Format8bppIndexed);

            }



            var rect = new Rectangle(new System.Drawing.Point(0, 0), new Size(_unmanagedImage.Width, _unmanagedImage.Height));


            try
            {

                Bf.Threshold = ContourThreshold;
                Kcurv.K = ContourKernelForPeaks;
                Kcurv.Suppression = ContourSupressionForPeaks;
                Kcurv.Theta = ContourThetaForPeaks;


                var contour = Bf.FindContour(imageTemp);

                for (var i = 0; i < contour.Count; i++)
                    contour[i] += new IntPoint(rect.X, rect.Y);

                Drawing.Polygon(_unmanagedImage, contour, Color.Red);


                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        #endregion

        #region Filter FastCornersDetector

        //filter Invert
        private readonly FastCornersDetector _fastCorners = new FastCornersDetector();
        public bool IsFastCornerDetection
        {
            get { return GetValue<bool>(_instanceOf); }
            set { SetValue(value, _instanceOf); }
        }

        public bool FASTSuppress
        {
            get { return GetValue<bool>(_instanceOf); }
            set { SetValue(value, _instanceOf); }
        }
        public List<IntPoint> FASTGetPoints
        {
            get { return GetValue<List<IntPoint>>(_instanceOf); }
            set { SetValue(value, _instanceOf); }
        }

        public int FASTThreshold
        {
            get { return GetValue<int>(_instanceOf); }
            set { SetValue(value, _instanceOf); }
        }


        private bool ProofIsFastCornerDetector()
        {
            try
            {

                _fastCorners.Threshold = FASTThreshold;
                _fastCorners.Suppress = FASTSuppress;

                FASTGetPoints = _fastCorners.ProcessImage(_unmanagedImage);


                CornersMarker cMaker = new CornersMarker(_fastCorners, Color.Red);

                _unmanagedImage = cMaker.Apply(_unmanagedImage);
                return true;
            }
            catch
            {
                return false;
            }
        }

        #endregion

        #region Filter HarrisCornersDetector

        //Noise smooth
        private readonly HarrisCornersDetector _harrisCornersDetector = new HarrisCornersDetector();

        public bool IsCornerDetectionHarris
        {
            get { return GetValue<bool>(_instanceOf); }
            set { SetValue(value, _instanceOf); }
        }

        public float HarrisKValue
        {
            get { return GetValue<float>(_instanceOf); }
            set { SetValue(value, _instanceOf); }
        }

        public float HarrisSigma
        {
            get { return GetValue<float>(_instanceOf); }
            set { SetValue(value, _instanceOf); }
        }

        public float HarrisThreshold
        {
            get { return GetValue<float>(_instanceOf); }
            set { SetValue(value, _instanceOf); }
        }

        public int HarrisSupression
        {
            get { return GetValue<int>(_instanceOf); }
            set { SetValue(value, _instanceOf); }
        }

        public HarrisCornerMeasure HarrisMesure
        {
            get { return GetValue<HarrisCornerMeasure>(_instanceOf); }
            set { SetValue(value, _instanceOf); }
        }

        public List<IntPoint> HarrisGetPoints
        {
            get { return GetValue<List<IntPoint>>(_instanceOf); }
            set { SetValue(value, _instanceOf); }
        }




        private bool ProofIsCornerDetectionHarris()
        {
            try
            {
                _harrisCornersDetector.K = HarrisKValue;
                _harrisCornersDetector.Threshold = HarrisThreshold;
                _harrisCornersDetector.Sigma = HarrisSigma;
                _harrisCornersDetector.Measure = HarrisMesure;
                _harrisCornersDetector.Suppression = HarrisSupression;
                HarrisGetPoints = _harrisCornersDetector.ProcessImage(_unmanagedImage);



                CornersMarker filter = new CornersMarker(_harrisCornersDetector, Color.Red);
                _unmanagedImage = filter.Apply(_unmanagedImage);



                return true;
            }
            catch
            {
                return false;
            }
        }

        #endregion

        #region Filter SobelEdgeDetector

        //Noise smooth
        private readonly SobelEdgeDetector _sobelEdge = new SobelEdgeDetector();

        public bool IsSobelEdgedetect
        {
            get { return GetValue<bool>(_instanceOf); }
            set { SetValue(value, _instanceOf); }
        }

        public bool SobelScaleIntensity
        {
            get { return GetValue<bool>(_instanceOf); }
            set { SetValue(value, _instanceOf); }
        }



        private bool ProofIsSobelEdgeDetector()
        {
            try
            {


                if (!FilterInformationHelper.FilterSupportsImageFormat(_unmanagedImage, (IFilterInformation)_sobelEdge))
                {
                    _unmanagedImage = _unmanagedImage.ConvertToFormat(PixelFormat.Format8bppIndexed);

                }


                _sobelEdge.ScaleIntensity = SobelScaleIntensity;

                _unmanagedImage = _sobelEdge.Apply(_unmanagedImage);

                return true;
            }
            catch
            {
                return false;
            }
        }

        #endregion

        #region Filter SpeededUpRobustFeaturesDetector

        //Noise smooth
        private SpeededUpRobustFeaturesDetector _SURFEdge;

        public bool IsSURFEdge
        {
            get { return GetValue<bool>(_instanceOf); }
            set { SetValue(value, _instanceOf); }
        }

        public int SURFOctaves
        {
            get { return GetValue<int>(_instanceOf); }
            set { SetValue(value, _instanceOf); }
        }

        public float SURFThres
        {
            get { return GetValue<float>(_instanceOf); }
            set { SetValue(value, _instanceOf); }
        }

        public int SURFStep
        {
            get { return GetValue<int>(_instanceOf); }
            set { SetValue(value, _instanceOf); }
        }

        public SpeededUpRobustFeaturesDescriptor SURFDesciptor
        {
            get { return GetValue<SpeededUpRobustFeaturesDescriptor>(_instanceOf); }
            set { SetValue(value, _instanceOf); }
        }

        public SpeededUpRobustFeatureDescriptorType SURFDesciptorType
        {
            get { return GetValue<SpeededUpRobustFeatureDescriptorType>(_instanceOf); }
            set { SetValue(value, _instanceOf); }
        }

        public bool SURFIsOrientation
        {
            get { return GetValue<bool>(_instanceOf); }
            set { SetValue(value, _instanceOf); }
        }

        public List<SpeededUpRobustFeaturePoint> SURFGetFeaturePoints
        {
            get { return GetValue<List<SpeededUpRobustFeaturePoint>>(_instanceOf); }
            set { SetValue(value, _instanceOf); }
        }

        public SpeededUpRobustFeaturePoint SURFFeatureMaxPoint
        {
            get
            {
                return SURFGetFeaturePoints.Find(p => p.Scale == SURFGetFeaturePoints.Max(point => point.Scale));
            }
        }


        private bool ProofIsSURFEdgeDetector()
        {
            try
            {
                _SURFEdge = new SpeededUpRobustFeaturesDetector();
                _SURFEdge.Octaves = SURFOctaves;
                _SURFEdge.Step = SURFStep;
                _SURFEdge.Threshold = SURFThres;
                SURFDesciptor = _SURFEdge.GetDescriptor();
                _SURFEdge.ComputeDescriptors = SURFDesciptorType;
                _SURFEdge.ComputeOrientation = SURFIsOrientation;
                SURFGetFeaturePoints = _SURFEdge.ProcessImage(_unmanagedImage);


                FeaturesMarker marker = new FeaturesMarker(SURFGetFeaturePoints);
                _unmanagedImage = marker.Apply(_unmanagedImage);

                _unmanagedImage = DrawingShapes.DrawEllipseUnmanagedImage(_unmanagedImage, SURFFeatureMaxPoint,
                    Color.Chocolate);

                return true;
            }
            catch
            {
                return false;
            }
        }

        #endregion

        #region Filter GaborFilter

        //Noise smooth
        private GaborFilter _gaborFilter;

        public bool IsGaborFilter
        {
            get { return GetValue<bool>(_instanceOf); }
            set { SetValue(value, _instanceOf); }
        }

        public int GABORSize
        {
            get { return GetValue<int>(_instanceOf); }
            set { SetValue(value, _instanceOf); }
        }

        public float GABORLambda
        {
            get { return GetValue<float>(_instanceOf); }
            set { SetValue(value, _instanceOf); }
        }

        public float GABORSigma
        {
            get { return GetValue<float>(_instanceOf); }
            set { SetValue(value, _instanceOf); }
        }

        public float GABORTheta
        {
            get { return GetValue<float>(_instanceOf); }
            set { SetValue(value, _instanceOf); }
        }

        public float GABORGamma
        {
            get { return GetValue<float>(_instanceOf); }
            set { SetValue(value, _instanceOf); }
        }






        private bool ProofIsGabor()
        {
            try
            {
                _gaborFilter = new GaborFilter();
                _gaborFilter.Size = GABORSize;
                _gaborFilter.Gamma = GABORGamma;
                _gaborFilter.Lambda = GABORLambda;
                _gaborFilter.Sigma = GABORSigma;
                _gaborFilter.Theta = GABORTheta;

                _unmanagedImage = _gaborFilter.Apply(_unmanagedImage);

                return true;
            }
            catch
            {
                return false;
            }
        }

        #endregion

        #region Filter Canny

        //CannyEdge
        private readonly CannyEdgeDetector cannyEdgeDetector = new CannyEdgeDetector(20, 20, double.NaN);
        public bool IsCanny
        {
            get { return GetValue<bool>(_instanceOf); }
            set { SetValue(value, _instanceOf); }
        }
        public int CannySigma
        {
            get { return GetValue<int>(_instanceOf); }
            set { SetValue(value, _instanceOf); }
        }
        public int CannyGaussianSize
        {
            get { return GetValue<int>(_instanceOf); }
            set { SetValue(value, _instanceOf); }
        }
        public int CannyHighThreshold
        {
            get { return GetValue<int>(_instanceOf); }
            set { SetValue(value, _instanceOf); }
        }
        public int CannyLowThreshold
        {
            get { return GetValue<int>(_instanceOf); }
            set { SetValue(value, _instanceOf); }
        }


        private bool ProofIsCanny()
        {
            try
            {
                cannyEdgeDetector.GaussianSigma = CannySigma;
                cannyEdgeDetector.GaussianSize = CannyGaussianSize;
                cannyEdgeDetector.HighThreshold = (byte)CannyHighThreshold;
                cannyEdgeDetector.LowThreshold = (byte)CannyLowThreshold;

                if (!FilterInformationHelper.FilterSupportsImageFormat(_unmanagedImage, cannyEdgeDetector))
                {
                    _unmanagedImage = _unmanagedImage.ConvertToFormat(PixelFormat.Format8bppIndexed);
                }

                _unmanagedImage = cannyEdgeDetector.Apply(_unmanagedImage);


                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        #endregion

        #region Filter HoughCircleTransformation

        //CannyEdge
        private readonly HoughCircleTransformation houghCircleTransformation = new HoughCircleTransformation(30);
        public bool IsHoughTransform
        {
            get { return GetValue<bool>(_instanceOf); }
            set { SetValue(value, _instanceOf); }
        }

        private bool ProofIsHough()
        {
            try
            {



                _unmanagedImage = _unmanagedImage.ConvertToFormat(PixelFormat.Format8bppIndexed);



                houghCircleTransformation.ProcessImage(_unmanagedImage);

                HoughCircle[] circles = houghCircleTransformation.GetCirclesByRelativeIntensity(0.8);

                _unmanagedImage = DrawingShapes.DrawHoughCirclesUnmanagedImage(_unmanagedImage, circles, Color.BlueViolet);


                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        #endregion

    }
}
