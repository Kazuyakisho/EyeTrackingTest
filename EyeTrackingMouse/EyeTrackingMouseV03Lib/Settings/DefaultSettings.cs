using Accord.Imaging;
using Accord.Vision.Detection;
using AForge;
using AForge.Imaging;
using EyeTrackingMouseV03Lib.Filter;
using EyeTrackingMouseV03Lib.Helper;
using System.Drawing;

namespace EyeTrackingMouseV03Lib.Settings
{
    public static class DefaultSettings
    {

        public static void DefaultSettingsAforge(EnumROI enumRoi)
        {
            switch (enumRoi)
            {
                case (EnumROI.RightEye):
                    //Aforge: has to load on Start
                    ETSettings.Instance.EtSettingsEyes.EyesDetectorRightEyeAforge.MinSize = new Size(20, 20);
                    // ETSettings.Instance.EtSettingsEyes.EyesDetectorRightEyeAforge.MaxSize = new Size(100, 100);
                    ETSettings.Instance.EtSettingsEyes.EyesDetectorRightEyeAforge.ScalingFactor = 1.4f;
                    ETSettings.Instance.EtSettingsEyes.EyesDetectorRightEyeAforge.ScalingMode =
                        ObjectDetectorScalingMode.GreaterToSmaller;
                    ETSettings.Instance.EtSettingsEyes.EyesDetectorRightEyeAforge.SearchMode =
                        ObjectDetectorSearchMode.Default;
                    ETSettings.Instance.EtSettingsEyes.EyesDetectorRightEyeAforge.UseParallelProcessing = true;
                    ETSettings.Instance.EtSettingsEyes.EyesDetectorRightEyeAforge.Suppression = 3;
                    break;
                case (EnumROI.Nose):
                    ETSettings.Instance.EtSettingsNose.HaarObjectDetectorNose.MinSize = new Size(20, 20);
                    ETSettings.Instance.EtSettingsNose.HaarObjectDetectorNose.MaxSize = new Size(200, 200);
                    ETSettings.Instance.EtSettingsNose.HaarObjectDetectorNose.ScalingFactor = 1.3f;
                    ETSettings.Instance.EtSettingsNose.HaarObjectDetectorNose.ScalingMode =
                        ObjectDetectorScalingMode.GreaterToSmaller;
                    ETSettings.Instance.EtSettingsNose.HaarObjectDetectorNose.SearchMode =
                        ObjectDetectorSearchMode.Average;
                    ETSettings.Instance.EtSettingsNose.HaarObjectDetectorNose.UseParallelProcessing = true;
                    ETSettings.Instance.EtSettingsNose.HaarObjectDetectorNose.Suppression = 3;
                    break;
                case (EnumROI.LeftEye):
                    ETSettings.Instance.EtSettingsEyes.EyesDetectorLeftEyeAforge.MinSize = new Size(20, 20);
                    //ETSettings.Instance.EtSettingsEyes.EyesDetectorLeftEyeAforge.MaxSize = new Size(100, 100);
                    ETSettings.Instance.EtSettingsEyes.EyesDetectorLeftEyeAforge.ScalingFactor = 1.4f;
                    ETSettings.Instance.EtSettingsEyes.EyesDetectorLeftEyeAforge.ScalingMode =
                        ObjectDetectorScalingMode.GreaterToSmaller;
                    ETSettings.Instance.EtSettingsEyes.EyesDetectorLeftEyeAforge.SearchMode =
                        ObjectDetectorSearchMode.Default;
                    ETSettings.Instance.EtSettingsEyes.EyesDetectorLeftEyeAforge.UseParallelProcessing = true;
                    ETSettings.Instance.EtSettingsEyes.EyesDetectorLeftEyeAforge.Suppression = 4;
                    break;

                case (EnumROI.Face):
                    ETSettings.Instance.EtSettingsFace.Detector.MinSize = new Size(25, 25);
                    ETSettings.Instance.EtSettingsFace.Detector.ScalingFactor = 1.5f;
                    ETSettings.Instance.EtSettingsFace.Detector.ScalingMode =
                        ObjectDetectorScalingMode.GreaterToSmaller;
                    ETSettings.Instance.EtSettingsFace.Detector.SearchMode =
                        ObjectDetectorSearchMode.Single; //Only one Face
                    ETSettings.Instance.EtSettingsFace.Detector.UseParallelProcessing = true;
                    ETSettings.Instance.EtSettingsFace.Detector.Suppression = 3;
                    break;
            }
        }

        public static void DefaultSettingsEmgu(EnumROI enumRoi)
        {


            switch (enumRoi)
            {
                case (EnumROI.RightEye):
                    // ETSettings.Instance.EtSettingsEyes.MaxSizeRightEye = new Size(100, 100);
                    ETSettings.Instance.EtSettingsEyes.MinSizeRightEye = new Size(20, 20);
                    ETSettings.Instance.EtSettingsEyes.NeighboursRightEye = 2;
                    ETSettings.Instance.EtSettingsEyes.ScaleFactorRightEye = 1.2;
                    break;
                case (EnumROI.Nose):
                    //  ETSettings.Instance.EtSettingsNose.MaxSize = new Size(100, 100);
                    ETSettings.Instance.EtSettingsNose.MinSize = new Size(20, 20);
                    ETSettings.Instance.EtSettingsNose.Neighbours = 3;
                    ETSettings.Instance.EtSettingsNose.ScaleFactor = 1.2;

                    break;
                case (EnumROI.LeftEye):
                    //  ETSettings.Instance.EtSettingsEyes.MaxSizeLeftEye = new Size(100, 100);
                    ETSettings.Instance.EtSettingsEyes.MinSizeLeftEye = new Size(20, 20);
                    ETSettings.Instance.EtSettingsEyes.NeighboursLeftEye = 2;
                    ETSettings.Instance.EtSettingsEyes.ScaleFactorLeftEye = 1.2;


                    break;
                case (EnumROI.Face):
                    //Nothing: Only Aforge

                    break;

            }
        }


        public static ETFilterManager DefaultFilterSettings(EnumROI enumEye, ETFilterManager filter = null)
        {
            if (filter == null)
                filter = new ETFilterManager(enumEye);


            switch (enumEye)
            {
                case (EnumROI.RightEye):

                    filter.EtFilterForImage.IsFilterGrayScale = true;
                    filter.EtFilterForImage.IsGrayCommon = false;
                    filter.EtFilterForImage.IsFilterInvert = true;
                    filter.EtFilterForImage.IsThreshold = true;
                    filter.EtFilterForImage.IsGammaCorrection = false;
                    filter.EtFilterForImage.IsBrightnessCorrection = false;
                    filter.EtFilterForImage.IsEuclidianColorFilter = false;
                    filter.EtFilterForImage.IsExtraChannelExtraction = false;
                    filter.EtFilterForImage.IsFilterGaussianBlur = false;
                    filter.EtFilterForImage.EuclidianIsFillOutsideColor = false;
                    filter.EtFilterForImage.IsNoiseSmooth = false;
                    filter.EtFilterForImage.IsSharpen = false;
                    filter.EtFilterForImage.ConservativeKernelSizeValue = 5;
                    filter.EtFilterForImage.GammaCorrectionValue = 3;
                    filter.EtFilterForImage.ThresHoldValue = 220;
                    filter.EtFilterForImage.BrightnessValue = 10;
                    filter.EtFilterForImage.EucAlpha = 255;
                    filter.EtFilterForImage.EucBlue = 20;
                    filter.EtFilterForImage.EucRed = 20;
                    filter.EtFilterForImage.EucGreen = 20;
                    filter.EtFilterForImage.EuclidianColorRadius = 15;
                    filter.EtFilterForImage.GrayScaleCb = 0.0721f;
                    filter.EtFilterForImage.GrayScaleCg = 0.7154f;
                    filter.EtFilterForImage.GrayScaleCr = 0.2125f;
                    filter.EtFilterForImage.GaussionKernel = 5;
                    filter.EtFilterForImage.GaussionWert = 5;
                    filter.EtFilterForImage.IsConclusion = false;
                    filter.EtFilterForImage.IsAdaptiveThreshold = false;
                    filter.EtFilterForImage.IsFilterGaussianBlur = false;
                    filter.EtFilterForImage.ConvThreshold = 10;
                    filter.EtFilterForImage.ConIsProcessAlpha = false;
                    filter.EtFilterForImage.ConvIsDynamicDivisorForEdges = false;
                    filter.EtFilterForImage.GaussionKernel = 5;
                    filter.EtFilterForImage.GaussionWert = 0.5;
                    filter.EtFilterForImage.ExtraChannelExetraction = RGB.G;

                    filter.EtFilterForEdgeDetection.IsFilterContour = false;
                    filter.EtFilterForEdgeDetection.IsCanny = false;
                    filter.EtFilterForEdgeDetection.CannyGaussianSize = 5;
                    filter.EtFilterForEdgeDetection.CannyHighThreshold = 100;
                    filter.EtFilterForEdgeDetection.CannyLowThreshold = 20;
                    filter.EtFilterForEdgeDetection.CannySigma = 2;
                    filter.EtFilterForEdgeDetection.IsCornerDetectionHarris = false;
                    filter.EtFilterForEdgeDetection.IsFastCornerDetection = false;
                    filter.EtFilterForEdgeDetection.FASTThreshold = 10;
                    filter.EtFilterForEdgeDetection.FASTSuppress = false;
                    filter.EtFilterForEdgeDetection.SobelScaleIntensity = false;
                    filter.EtFilterForEdgeDetection.HarrisMesure = HarrisCornerMeasure.Harris;
                    filter.EtFilterForEdgeDetection.HarrisKValue = 0.04f;
                    filter.EtFilterForEdgeDetection.HarrisSigma = 1.4f;
                    filter.EtFilterForEdgeDetection.HarrisSupression = 3;
                    filter.EtFilterForEdgeDetection.HarrisThreshold = 5;
                    filter.EtFilterForEdgeDetection.IsSobelEdgedetect = false;
                    filter.EtFilterForEdgeDetection.ContourKernelForPeaks = 30;
                    filter.EtFilterForEdgeDetection.ContourSupressionForPeaks = 1;
                    filter.EtFilterForEdgeDetection.ContourThetaForPeaks = new DoubleRange(0, 45);
                    filter.EtFilterForEdgeDetection.ContourThreshold = (byte)10;
                    filter.EtFilterForEdgeDetection.IsSURFEdge = false;
                    filter.EtFilterForEdgeDetection.SURFThres = 0.0002f;
                    filter.EtFilterForEdgeDetection.SURFIsOrientation = false;
                    filter.EtFilterForEdgeDetection.SURFOctaves = 3;
                    filter.EtFilterForEdgeDetection.SURFStep = 2;
                    filter.EtFilterForEdgeDetection.GABORLambda = 4.0f;
                    filter.EtFilterForEdgeDetection.GABORTheta = 0.6f;
                    filter.EtFilterForEdgeDetection.GABORGamma = 0.3f;
                    filter.EtFilterForEdgeDetection.GABORSize = 3;
                    filter.EtFilterForEdgeDetection.GABORSigma = 2;
                    filter.EtFilterForEdgeDetection.IsGaborFilter = false;

                    break;
                case (EnumROI.LeftEye):

                    filter.EtFilterForImage.IsFilterGrayScale = false;
                    filter.EtFilterForImage.IsGrayCommon = false;
                    filter.EtFilterForImage.IsFilterInvert = false;
                    filter.EtFilterForImage.IsThreshold = false;
                    filter.EtFilterForImage.IsGammaCorrection = false;
                    filter.EtFilterForImage.IsBrightnessCorrection = false;
                    filter.EtFilterForImage.IsEuclidianColorFilter = false;
                    filter.EtFilterForImage.IsExtraChannelExtraction = false;
                    filter.EtFilterForImage.IsFilterGaussianBlur = false;
                    filter.EtFilterForImage.EuclidianIsFillOutsideColor = false;
                    filter.EtFilterForImage.IsNoiseSmooth = false;
                    filter.EtFilterForImage.IsSharpen = false;
                    filter.EtFilterForImage.ConservativeKernelSizeValue = 5;
                    filter.EtFilterForImage.GammaCorrectionValue = 3;
                    filter.EtFilterForImage.ThresHoldValue = 220;
                    filter.EtFilterForImage.BrightnessValue = 10;
                    filter.EtFilterForImage.EucAlpha = 255;
                    filter.EtFilterForImage.EucBlue = 20;
                    filter.EtFilterForImage.EucRed = 20;
                    filter.EtFilterForImage.EucGreen = 20;
                    filter.EtFilterForImage.EuclidianColorRadius = 15;
                    filter.EtFilterForImage.GrayScaleCb = 0.0721f;
                    filter.EtFilterForImage.GrayScaleCg = 0.7154f;
                    filter.EtFilterForImage.GrayScaleCr = 0.2125f;
                    filter.EtFilterForImage.GaussionKernel = 5;
                    filter.EtFilterForImage.GaussionWert = 5;
                    filter.EtFilterForImage.IsConclusion = false;
                    filter.EtFilterForImage.IsAdaptiveThreshold = false;
                    filter.EtFilterForImage.IsFilterGaussianBlur = false;
                    filter.EtFilterForImage.ConvThreshold = 10;
                    filter.EtFilterForImage.ConIsProcessAlpha = false;
                    filter.EtFilterForImage.ConvIsDynamicDivisorForEdges = false;
                    filter.EtFilterForImage.GaussionKernel = 5;
                    filter.EtFilterForImage.GaussionWert = 0.5;
                    filter.EtFilterForImage.ExtraChannelExetraction = RGB.G;

                    filter.EtFilterForEdgeDetection.IsFilterContour = false;
                    filter.EtFilterForEdgeDetection.IsCanny = false;
                    filter.EtFilterForEdgeDetection.CannyGaussianSize = 5;
                    filter.EtFilterForEdgeDetection.CannyHighThreshold = 100;
                    filter.EtFilterForEdgeDetection.CannyLowThreshold = 20;
                    filter.EtFilterForEdgeDetection.CannySigma = 2;
                    filter.EtFilterForEdgeDetection.IsCornerDetectionHarris = false;
                    filter.EtFilterForEdgeDetection.IsFastCornerDetection = false;
                    filter.EtFilterForEdgeDetection.FASTThreshold = 10;
                    filter.EtFilterForEdgeDetection.FASTSuppress = false;
                    filter.EtFilterForEdgeDetection.SobelScaleIntensity = false;
                    filter.EtFilterForEdgeDetection.HarrisMesure = HarrisCornerMeasure.Noble;
                    filter.EtFilterForEdgeDetection.HarrisKValue = 0.04f;
                    filter.EtFilterForEdgeDetection.HarrisSigma = 1.4f;
                    filter.EtFilterForEdgeDetection.HarrisSupression = 0;
                    filter.EtFilterForEdgeDetection.HarrisThreshold = 5f;
                    filter.EtFilterForEdgeDetection.IsSobelEdgedetect = false;
                    filter.EtFilterForEdgeDetection.ContourKernelForPeaks = 30;
                    filter.EtFilterForEdgeDetection.ContourSupressionForPeaks = 1;
                    filter.EtFilterForEdgeDetection.ContourThetaForPeaks = new DoubleRange(0, 45);
                    filter.EtFilterForEdgeDetection.ContourThreshold = (byte)10;
                    filter.EtFilterForEdgeDetection.IsSURFEdge = false;
                    filter.EtFilterForEdgeDetection.SURFThres = 0.0002f;
                    filter.EtFilterForEdgeDetection.SURFIsOrientation = false;
                    filter.EtFilterForEdgeDetection.SURFOctaves = 3;
                    filter.EtFilterForEdgeDetection.SURFStep = 2;
                    filter.EtFilterForEdgeDetection.GABORLambda = 4.0f;
                    filter.EtFilterForEdgeDetection.GABORTheta = 0.6f;
                    filter.EtFilterForEdgeDetection.GABORGamma = 0.3f;
                    filter.EtFilterForEdgeDetection.GABORSize = 3;
                    filter.EtFilterForEdgeDetection.GABORSigma = 2;
                    filter.EtFilterForEdgeDetection.IsGaborFilter = false;



                    return filter;
                    break;
                case (EnumROI.Face):

                    filter.EtFilterForImage.IsFilterGrayScale = true;
                    filter.EtFilterForImage.IsGrayCommon = false;
                    filter.EtFilterForImage.IsFilterInvert = true;
                    filter.EtFilterForImage.IsThreshold = true;
                    filter.EtFilterForImage.IsGammaCorrection = false;
                    filter.EtFilterForImage.IsBrightnessCorrection = false;
                    filter.EtFilterForImage.IsEuclidianColorFilter = false;
                    filter.EtFilterForImage.IsExtraChannelExtraction = false;
                    filter.EtFilterForImage.IsFilterGaussianBlur = false;
                    filter.EtFilterForImage.EuclidianIsFillOutsideColor = false;
                    filter.EtFilterForImage.IsNoiseSmooth = false;
                    filter.EtFilterForImage.IsSharpen = false;
                    filter.EtFilterForImage.ConservativeKernelSizeValue = 5;
                    filter.EtFilterForImage.GammaCorrectionValue = 3;
                    filter.EtFilterForImage.ThresHoldValue = 220;
                    filter.EtFilterForImage.BrightnessValue = 10;
                    filter.EtFilterForImage.EucAlpha = 255;
                    filter.EtFilterForImage.EucBlue = 20;
                    filter.EtFilterForImage.EucRed = 20;
                    filter.EtFilterForImage.EucGreen = 20;
                    filter.EtFilterForImage.EuclidianColorRadius = 15;
                    filter.EtFilterForImage.GrayScaleCb = 0.0721f;
                    filter.EtFilterForImage.GrayScaleCg = 0.7154f;
                    filter.EtFilterForImage.GrayScaleCr = 0.2125f;
                    filter.EtFilterForImage.GaussionKernel = 5;
                    filter.EtFilterForImage.GaussionWert = 5;
                    filter.EtFilterForImage.IsConclusion = false;
                    filter.EtFilterForImage.IsAdaptiveThreshold = false;
                    filter.EtFilterForImage.IsFilterGaussianBlur = false;
                    filter.EtFilterForImage.ConvThreshold = 10;
                    filter.EtFilterForImage.ConIsProcessAlpha = false;
                    filter.EtFilterForImage.ConvIsDynamicDivisorForEdges = false;
                    filter.EtFilterForImage.GaussionKernel = 5;
                    filter.EtFilterForImage.GaussionWert = 0.5;
                    filter.EtFilterForImage.ExtraChannelExetraction = RGB.G;

                    filter.EtFilterForEdgeDetection.IsFilterContour = false;
                    filter.EtFilterForEdgeDetection.IsCanny = false;
                    filter.EtFilterForEdgeDetection.CannyGaussianSize = 5;
                    filter.EtFilterForEdgeDetection.CannyHighThreshold = 100;
                    filter.EtFilterForEdgeDetection.CannyLowThreshold = 20;
                    filter.EtFilterForEdgeDetection.CannySigma = 2;
                    filter.EtFilterForEdgeDetection.IsCornerDetectionHarris = false;
                    filter.EtFilterForEdgeDetection.IsFastCornerDetection = false;
                    filter.EtFilterForEdgeDetection.FASTThreshold = 10;
                    filter.EtFilterForEdgeDetection.FASTSuppress = false;
                    filter.EtFilterForEdgeDetection.SobelScaleIntensity = false;
                    filter.EtFilterForEdgeDetection.HarrisMesure = HarrisCornerMeasure.Noble;
                    filter.EtFilterForEdgeDetection.HarrisKValue = 0.04f;
                    filter.EtFilterForEdgeDetection.HarrisSigma = 1.2f;
                    filter.EtFilterForEdgeDetection.HarrisSupression = 3;
                    filter.EtFilterForEdgeDetection.HarrisThreshold = 5;
                    filter.EtFilterForEdgeDetection.IsSobelEdgedetect = false;
                    filter.EtFilterForEdgeDetection.ContourKernelForPeaks = 30;
                    filter.EtFilterForEdgeDetection.ContourSupressionForPeaks = 1;
                    filter.EtFilterForEdgeDetection.ContourThetaForPeaks = new DoubleRange(0, 45);
                    filter.EtFilterForEdgeDetection.ContourThreshold = (byte)10;
                    filter.EtFilterForEdgeDetection.IsSURFEdge = false;
                    filter.EtFilterForEdgeDetection.SURFThres = 0.0002f;
                    filter.EtFilterForEdgeDetection.SURFIsOrientation = false;
                    filter.EtFilterForEdgeDetection.SURFOctaves = 3;
                    filter.EtFilterForEdgeDetection.SURFStep = 2;
                    filter.EtFilterForEdgeDetection.GABORLambda = 4.0f;
                    filter.EtFilterForEdgeDetection.GABORTheta = 0.6f;
                    filter.EtFilterForEdgeDetection.GABORGamma = 0.3f;
                    filter.EtFilterForEdgeDetection.GABORSize = 3;
                    filter.EtFilterForEdgeDetection.GABORSigma = 2.0f;
                    filter.EtFilterForEdgeDetection.IsGaborFilter = false;
                    break;

            }
            return filter;

        }


    }
}
