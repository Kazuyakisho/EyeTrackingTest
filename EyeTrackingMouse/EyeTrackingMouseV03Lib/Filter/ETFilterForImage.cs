using AForge.Imaging;
using AForge.Imaging.Filters;
using EyeTrackingMouseV03Lib.Helper;
using System;
using System.Drawing;
using System.Drawing.Imaging;

namespace EyeTrackingMouseV03Lib.Filter
{



    public class ETFilterForImage : INotifyBase
    {
        private readonly GrayscaleToRGB _grayToRgb = new GrayscaleToRGB();


        #region Filtering Proof

        private EnumROI _instanceOf;

        public ETFilterForImage(EnumROI instanceOf)
        {
            _instanceOf = instanceOf;
        }
        private bool FilterProof()
        {


            var erg = true;
            if (IsFilterGrayScale) erg = erg && ProofIsGrayScal();
            if (IsEuclidianColorFilter) erg = erg && ProofIsEuc();
            if (IsFilterInvert) erg = erg && ProofIsInvert();
            if (IsExtraChannelExtraction) erg = erg && ProofIsEch();
            if (IsFilterGaussianBlur) erg = erg && ProofIsGaussianBlur();
            if (IsBrightnessCorrection) erg = erg && ProofIsBrightness();
            if (IsGammaCorrection) erg = erg && ProofIsGc();
            if (IsNoiseSmooth) erg = erg && ProofIsCons();
            if (IsSharpen) erg = erg && ProofIsSh();
            if (IsThreshold) erg = erg && ProofIsThres();
            if (IsAdaptiveThreshold) erg = erg && ProofIsAdaptiveThreshold();
            if (IsConclusion) erg = erg && ProofIsConclusion();


            return erg;
        }
        #endregion

        private UnmanagedImage _unmanagedImage;
        public Bitmap FilterImage;

        public UnmanagedImage Filtering(UnmanagedImage image)
        {

            lock (this)
            {

                _unmanagedImage = image;

                if (FilterProof())
                {

                    return _unmanagedImage;
                    ;
                }
                else
                {
                    return image;
                }



            }
        }


        //Test for CallBack Function
        public void OnChange(object value)
        {
            //MessageBox.Show(value.ToString());
        }



        public bool IsTrackingPupil { private get; set; } = false;



        #region Filter Gaussian Blur

        private GaussianBlur Blur;

        public bool IsFilterGaussianBlur
        {
            get { return GetValue<bool>(_instanceOf); }
            set { SetValue(value, _instanceOf); }
        }
        public int GaussionKernel
        {
            get { return GetValue<int>(_instanceOf); }
            set { SetValue(value, _instanceOf); }
        }
        public double GaussionWert
        {
            get { return GetValue<int>(_instanceOf); }
            set { SetValue(value, _instanceOf); }
        }

        private bool ProofIsGaussianBlur()
        {
            try
            {
                Blur = new GaussianBlur(GaussionWert, GaussionKernel);
                
                _unmanagedImage = Blur.Apply(_unmanagedImage);

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        #endregion

        #region Filter Convolution

        //Noise smooth
        private Convolution _convolution;

        public bool IsConclusion
        {
            get { return GetValue<bool>(_instanceOf); }
            set { SetValue(value, _instanceOf); }
        }

        public int ConvThreshold
        {
            get { return GetValue<int>(_instanceOf); }
            set { SetValue(value, _instanceOf); }
        }

        public bool ConvIsDynamicDivisorForEdges
        {
            get { return GetValue<bool>(_instanceOf); }
            set { SetValue(value, _instanceOf); }
        }

        public bool ConIsProcessAlpha
        {
            get { return GetValue<bool>(_instanceOf); }
            set { SetValue(value, _instanceOf); }
        }





        private bool ProofIsConclusion()
        {
            try
            {

                _convolution = new Convolution(new int[,] {
                                { 1, 2, 3, 2, 1 },
                                { 2, 4, 5, 4, 2 },
                                { 3, 5, 6, 5, 3 },
                                { 2, 4, 5, 4, 2 },
                                { 1, 2, 3, 2, 1 } });

                _convolution.Threshold = ConvThreshold;
                _convolution.ProcessAlpha = ConIsProcessAlpha;
                _convolution.DynamicDivisorForEdges = ConvIsDynamicDivisorForEdges;

                _unmanagedImage = _convolution.Apply(_unmanagedImage);




                return true;
            }
            catch
            {
                return false;
            }
        }

        #endregion

        #region Filter SISThreshold

        //Noise smooth
        private readonly SISThreshold sisThreshold = new SISThreshold();

        public bool IsAdaptiveThreshold
        {
            get { return GetValue<bool>(_instanceOf); }
            set { SetValue(value, _instanceOf); }
        }

        public int GetThresHoldValue
        {
            get { return GetValue<int>(_instanceOf); }
            set { SetValue(value, _instanceOf); }
        }



        private bool ProofIsAdaptiveThreshold()
        {
            try
            {
                if (!IsFilterGrayScale) IsFilterGrayScale = true;

                _unmanagedImage = sisThreshold.Apply(_unmanagedImage);
                GetThresHoldValue = sisThreshold.ThresholdValue;

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        #endregion

        #region Filter ConservativeSmoothing

        //Noise smooth
        private readonly ConservativeSmoothing cons = new ConservativeSmoothing();

        public bool IsNoiseSmooth
        {
            get { return GetValue<bool>(_instanceOf); }
            set { SetValue(value, _instanceOf); }
        }


        public int ConservativeKernelSizeValue
        {
            get { return GetValue<int>(_instanceOf); }
            set { SetValue(value, _instanceOf); }
        }

        private bool ProofIsCons()
        {
            try
            {
                cons.KernelSize = ConservativeKernelSizeValue;

                _unmanagedImage = cons.Apply(_unmanagedImage);
                return true;
            }
            catch
            {
                return false;
            }
        }

        #endregion

        #region Filter ExtractChannel

        //Sharpen

        //extract channel
        private readonly ExtractChannel ech = new ExtractChannel();
        public short ExtraChannelExetraction
        {
            get { return GetValue<short>(_instanceOf); }
            set { SetValue(value, _instanceOf); }
        }
        public bool IsExtraChannelExtraction
        {
            get { return GetValue<bool>(_instanceOf); }
            set { SetValue(value, _instanceOf); }
        }

        private bool ProofIsEch()
        {
            try
            {
                ech.Channel = ExtraChannelExetraction;

                _unmanagedImage = ech.Apply(_unmanagedImage);
                return true;
            }
            catch
            {
                return false;
            }
        }

        #endregion

        #region Filter EuclideanColorFiltering

        //EuclideanColor Filter

        public bool IsEuclidianColorFilter
        {
            get { return GetValue<bool>(_instanceOf); }
            set { SetValue(value, _instanceOf); }
        }
        public byte EucAlpha
        {
            get { return GetValue<byte>(_instanceOf); }
            set { SetValue(value, _instanceOf); }
        }
        public byte EucRed
        {
            get { return GetValue<byte>(_instanceOf); }
            set { SetValue(value, _instanceOf); }
        }
        public byte EucGreen
        {
            get { return GetValue<byte>(_instanceOf); }
            set { SetValue(value, _instanceOf); }
        }
        public byte EucBlue
        {
            get { return GetValue<byte>(_instanceOf); }
            set { SetValue(value, _instanceOf); }
        }
        public short EuclidianColorRadius
        {
            get { return GetValue<short>(_instanceOf); }
            set { SetValue(value, _instanceOf); }
        }
        public bool EuclidianIsFillOutsideColor
        {
            get { return GetValue<bool>(_instanceOf); }
            set { SetValue(value, _instanceOf); }
        }


        private bool ProofIsEuc()
        {
            try
            {

                EuclideanColorFiltering euc = new EuclideanColorFiltering();
                euc.FillOutside = EuclidianIsFillOutsideColor;
                euc.Radius = EuclidianColorRadius;
                euc.CenterColor.Alpha = EucAlpha;
                euc.CenterColor.Blue = EucBlue;
                euc.CenterColor.Red = EucRed;
                euc.CenterColor.Green = EucGreen;

                _unmanagedImage = _unmanagedImage.ConvertToFormat(PixelFormat.Format24bppRgb);

                //if (!FilterInformationHelper.FilterSupportsImageFormat(_unmanagedImage, th))
                //{
                //    _unmanagedImage = _unmanagedImage.ConvertToFormat(PixelFormat.Format24bppRgb);
                //}
                _unmanagedImage = euc.Apply(_unmanagedImage);
                return true;
            }
            catch
            {
                return false;
            }
        }

        #endregion

        #region Filter GammaCorrection

        //GammaCorrection
        private readonly GammaCorrection gc = new GammaCorrection(1.5);
        public bool IsGammaCorrection
        {
            get { return GetValue<bool>(_instanceOf); }
            set { SetValue(value, _instanceOf); }
        }
        public double GammaCorrectionValue
        {
            get { return GetValue<double>(_instanceOf); }
            set { SetValue(value, _instanceOf); }
        }


        private bool ProofIsGc()
        {
            try
            {
                gc.Gamma = GammaCorrectionValue;

                _unmanagedImage = gc.Apply(_unmanagedImage);
                return true;
            }
            catch
            {
                return false;
            }
        }

        #endregion

        #region Filter Sharpen

        //Sharpen
        private readonly Sharpen sh = new Sharpen();

        public bool IsSharpen
        {
            get { return GetValue<bool>(_instanceOf); }
            set { SetValue(value, _instanceOf); }
        }

        private bool ProofIsSh()
        {
            try
            {
                _unmanagedImage = sh.Apply(_unmanagedImage);
                return true;
            }
            catch
            {
                return false;
            }
        }

        #endregion

        #region Filter Threshold

        //Threshol
        private Threshold th;

        public bool IsThreshold
        {
            get { return GetValue<bool>(_instanceOf); }
            set { SetValue(value, _instanceOf); }
        }

        public int ThresHoldValue
        {
            get { return GetValue<int>(_instanceOf); }
            set { SetValue(value, _instanceOf); }
        }


        private bool ProofIsThres()
        {
            try
            {
                th = new Threshold(ThresHoldValue);

                if (!FilterInformationHelper.FilterSupportsImageFormat(_unmanagedImage, th))
                {
                    _unmanagedImage = _unmanagedImage.ConvertToFormat(PixelFormat.Format8bppIndexed);
                }
                _unmanagedImage = th.Apply(_unmanagedImage);

                return true;
            }
            catch
            {
                return false;
            }
        }

        #endregion

        #region Filter Brightness

        //brightness
        private readonly BrightnessCorrection bCor = new BrightnessCorrection();
        public bool IsBrightnessCorrection
        {
            get { return GetValue<bool>(_instanceOf); }
            set { SetValue(value, _instanceOf); }
        }
        public int BrightnessValue
        {
            get { return GetValue<int>(_instanceOf); }
            set { SetValue(value, _instanceOf); }
        }

        private bool ProofIsBrightness()
        {
            try
            {
                bCor.AdjustValue = BrightnessValue;
                _unmanagedImage = bCor.Apply(_unmanagedImage);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        #endregion

        #region Filter Invert

        //filter Invert
        private readonly Invert invert = new Invert();
        public bool IsFilterInvert
        {
            get { return GetValue<bool>(_instanceOf); }
            set { SetValue(value, _instanceOf); }
        }

        private bool ProofIsInvert()
        {
            try
            {
                _unmanagedImage = invert.Apply(_unmanagedImage);
                return true;
            }
            catch
            {
                return false;
            }
        }

        #endregion

        #region Filter GrayScale

        //grayscale
        private readonly IFilter _CommonGray = Grayscale.CommonAlgorithms.BT709;
        private Grayscale grayscale;
        public bool IsFilterGrayScale
        {
            get { return GetValue<bool>(_instanceOf); }
            set { SetValue(value, _instanceOf); }
        }
        public bool IsGrayCommon
        {
            get { return GetValue<bool>(_instanceOf); }
            set { SetValue(value, _instanceOf); }
        }
        public float GrayScaleCr
        {
            get { return GetValue<float>(_instanceOf); }
            set { SetValue(value, _instanceOf); }
        }
        public float GrayScaleCg
        {
            get { return GetValue<float>(_instanceOf); }
            set { SetValue(value, _instanceOf); }
        }
        public float GrayScaleCb
        {
            get { return GetValue<float>(_instanceOf); }
            set { SetValue(value, _instanceOf); }
        }

        private bool ProofIsGrayScal()
        {
            try
            {
                if (IsGrayCommon)
                {
                    _unmanagedImage = _CommonGray.Apply(_unmanagedImage);
                }
                else
                {
                    grayscale = new Grayscale(GrayScaleCr, GrayScaleCg, GrayScaleCb);
                    _unmanagedImage = grayscale.Apply(_unmanagedImage);
                }



                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        #endregion

        //#region Filter Median

        ////GammaCorrection
        //private readonly Median median = new Median();
        //public bool IsMedian
        //{
        //    get { return GetValue<bool>(_instanceOf); }
        //    set { SetValue(value, _instanceOf); }
        //}
        //public double GammaCorrectionValue
        //{
        //    get { return GetValue<double>(_instanceOf); }
        //    set { SetValue(value, _instanceOf); }
        //}


        //private bool ProofIsMedian()
        //{
        //    try
        //    {
        //        gc.Gamma = GammaCorrectionValue;

        //        _unmanagedImage = gc.Apply(_unmanagedImage);
        //        return true;
        //    }
        //    catch
        //    {
        //        return false;
        //    }
        //}

        //#endregion


    }
}