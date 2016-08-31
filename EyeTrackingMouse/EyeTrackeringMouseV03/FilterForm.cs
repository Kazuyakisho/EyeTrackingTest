using Accord.Imaging;
using AForge;
using AForge.Imaging;
using EyeTrackingMouseV03Lib.EventArgs;
using EyeTrackingMouseV03Lib.Filter;
using EyeTrackingMouseV03Lib.Helper;
using EyeTrackingMouseV03Lib.Settings;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace EyeTrackeringMouseV03
{

    public sealed partial class FilterForm : Form
    {
        private readonly ETFilterManager _filterManager;
        private readonly FilterCriteriaEventArgs _fcEventArgs = new FilterCriteriaEventArgs();
        public delegate void ValueChangeEventHandler(object source, FilterCriteriaEventArgs e);

        public event ValueChangeEventHandler ValueChanged;

        private void OnValueChanged(FilterCriteriaEventArgs e)
        {
            ValueChanged?.Invoke(this, e);
        }


        public FilterForm(EnumROI eye)
        {

            InitializeComponent();

            _filterManager = (eye == EnumROI.LeftEye)
                ? DefaultSettings.DefaultFilterSettings(EnumROI.LeftEye)
                : (eye == EnumROI.Face)
                    ? DefaultSettings.DefaultFilterSettings(EnumROI.Face)
                    : DefaultSettings.DefaultFilterSettings(EnumROI.RightEye);

            _fcEventArgs.eye = eye;

            tBarThres.SetRange(0, 255);
            tBarThres.Value = _filterManager.EtFilterForImage.ThresHoldValue;
            lblThresValue.Text = _filterManager.EtFilterForImage.ThresHoldValue.ToString();


            tBarBrightness.SetRange(-50, 50);
            tBarBrightness.Value = _filterManager.EtFilterForImage.BrightnessValue;
            lblBrithValue.Text = _filterManager.EtFilterForImage.BrightnessValue.ToString();

            tBarCons.SetRange(3, 25);
            tBarCons.Value = _filterManager.EtFilterForImage.ConservativeKernelSizeValue;
            lblConsValue.Text = _filterManager.EtFilterForImage.ConservativeKernelSizeValue.ToString();

            tBarEucBlue.SetRange(0, 255);
            tBarEucBlue.Value = _filterManager.EtFilterForImage.EucBlue;
            lblEucBlueValue.Text = _filterManager.EtFilterForImage.EucBlue.ToString();

            lblColor.BackColor = Color.FromArgb(255, _filterManager.EtFilterForImage.EucRed, _filterManager.EtFilterForImage.EucGreen,
                _filterManager.EtFilterForImage.EucBlue);

            tBarEucGreen.SetRange(0, 255);
            tBarEucGreen.Value = _filterManager.EtFilterForImage.EucGreen;
            lblEucGreenValue.Text = _filterManager.EtFilterForImage.EucGreen.ToString();

            tBarEucRa.SetRange(0, 100);
            tBarEucRa.Value = _filterManager.EtFilterForImage.EuclidianColorRadius;
            lblEucRadValue.Text = _filterManager.EtFilterForImage.EuclidianColorRadius.ToString();

            tBarEucRed.SetRange(0, 255);
            tBarEucRed.Value = _filterManager.EtFilterForImage.EucRed;
            lblEucValue.Text = _filterManager.EtFilterForImage.EucRed.ToString();

            tBarGrayCb.SetRange(0, 4000);
            tBarGrayCb.Value = (int)_filterManager.EtFilterForImage.GrayScaleCb * 1000;
            lblGrayCbValue.Text = _filterManager.EtFilterForImage.GrayScaleCb.ToString();
            tBarGrayCb.Text = "test";

            tBarGrayCg.SetRange(0, 4000);
            tBarGrayCg.Value = (int)_filterManager.EtFilterForImage.GrayScaleCg * 1000;
            lblGrayCgValue.Text = _filterManager.EtFilterForImage.GrayScaleCg.ToString();

            tBarGrayCr.SetRange(0, 4000);
            tBarGrayCr.Value = (int)_filterManager.EtFilterForImage.GrayScaleCg * 1000;
            lblGrayCrValue.Text = _filterManager.EtFilterForImage.GrayScaleCr.ToString();

            tBarGamma.SetRange(-10, 40);
            tBarGamma.Value = (int)_filterManager.EtFilterForImage.GammaCorrectionValue;
            lblGammaValue.Text = _filterManager.EtFilterForImage.GammaCorrectionValue.ToString();

            tBarGausKernel.SetRange(3, 23);
            tBarGausKernel.Value = _filterManager.EtFilterForImage.GaussionKernel;
            lblGausKernel.Text = _filterManager.EtFilterForImage.GaussionKernel.ToString();

            tBarGausValue.SetRange(0, 50);
            tBarGausValue.Value = (int)_filterManager.EtFilterForImage.GaussionWert * 10;
            lblGausValue.Text = _filterManager.EtFilterForImage.GaussionKernel.ToString();


            cbFilterGrayScale.Checked = _filterManager.EtFilterForImage.IsFilterGrayScale;
            checkBox1.Checked = _filterManager.EtFilterForImage.IsGrayCommon;
            cbInvert.Checked = _filterManager.EtFilterForImage.IsFilterInvert;
            cbThres.Checked = _filterManager.EtFilterForImage.IsThreshold;
            cbGamma.Checked = _filterManager.EtFilterForImage.IsGammaCorrection;
            cbBrightness.Checked = _filterManager.EtFilterForImage.IsBrightnessCorrection;
            cbEuc.Checked = _filterManager.EtFilterForImage.IsEuclidianColorFilter;
            cbChannelExtr.Checked = _filterManager.EtFilterForImage.IsExtraChannelExtraction;
            cbGaus.Checked = _filterManager.EtFilterForImage.IsFilterGaussianBlur;
            cbFillOutSide.Checked = _filterManager.EtFilterForImage.EuclidianIsFillOutsideColor;
            cbCons.Checked = _filterManager.EtFilterForImage.IsNoiseSmooth;
            cbSharpen.Checked = _filterManager.EtFilterForImage.IsSharpen;
            cbSISThreshold.Checked = _filterManager.EtFilterForImage.IsAdaptiveThreshold;
            cbConvProcessAlpha.Checked = _filterManager.EtFilterForImage.ConIsProcessAlpha;
            cbConvDynamic.Checked = _filterManager.EtFilterForImage.ConvIsDynamicDivisorForEdges;

            cbContour.Checked = _filterManager.EtFilterForEdgeDetection.IsFilterContour;
            cbCanny.Checked = _filterManager.EtFilterForEdgeDetection.IsCanny;
            cbSobel.Checked = _filterManager.EtFilterForEdgeDetection.IsSobelEdgedetect;
            cbFASTSuppress.Checked = _filterManager.EtFilterForEdgeDetection.FASTSuppress;
            cbFastCornerDetector.Checked = _filterManager.EtFilterForEdgeDetection.IsFastCornerDetection;
            cbHarrisCornerDetector.Checked = _filterManager.EtFilterForEdgeDetection.IsCornerDetectionHarris;
            cbSolbelScaleIntens.Checked = _filterManager.EtFilterForEdgeDetection.SobelScaleIntensity;
            if (_filterManager.EtFilterForEdgeDetection.HarrisMesure == HarrisCornerMeasure.Noble) cbHarrisIsNoble.Checked = true;
            else cbHarrisIsNoble.Checked = false;

            tBarHarrisK.SetRange(0, 4000);
            tBarHarrisK.Value = (int)_filterManager.EtFilterForEdgeDetection.HarrisKValue * 1000;
            lblHarrisKValue.Text = _filterManager.EtFilterForEdgeDetection.HarrisKValue.ToString();

            tBarHarrisSigma.SetRange(0, 4000);
            tBarHarrisSigma.Value = (int)_filterManager.EtFilterForEdgeDetection.HarrisKValue * 1000;
            lblHarrisSigmaValue.Text = _filterManager.EtFilterForEdgeDetection.HarrisKValue.ToString();

            tBarHarrisThres.SetRange(0, 10000);
            tBarHarrisThres.Value = (int)_filterManager.EtFilterForEdgeDetection.HarrisThreshold * 100;
            lblHarrisThresValue.Text = _filterManager.EtFilterForEdgeDetection.HarrisThreshold.ToString();

            tBarHarristBar.SetRange(0, 10);
            tBarHarristBar.Value = _filterManager.EtFilterForEdgeDetection.HarrisSupression;
            lblHarrisSupressValue.Text = _filterManager.EtFilterForEdgeDetection.HarrisSupression.ToString();

            tBarContourKernel.SetRange(0, 30);
            tBarContourKernel.Value = _filterManager.EtFilterForEdgeDetection.ContourKernelForPeaks;
            lblContourKernel.Text = _filterManager.EtFilterForEdgeDetection.ContourKernelForPeaks.ToString();

            tBarContourSupression.SetRange(0, 50);
            tBarContourSupression.Value = _filterManager.EtFilterForEdgeDetection.ContourSupressionForPeaks;
            lblContourSuppresion.Text = _filterManager.EtFilterForEdgeDetection.ContourSupressionForPeaks.ToString();

            tBarContourThreshold.SetRange(0, 255);
            tBarContourThreshold.Value = _filterManager.EtFilterForEdgeDetection.ContourThreshold;
            lblContourThres.Text = _filterManager.EtFilterForEdgeDetection.ContourThreshold.ToString();

            tbContourDRangeMin.Text = _filterManager.EtFilterForEdgeDetection.ContourThetaForPeaks.Min.ToString();
            tbContourDRangeMax.Text = _filterManager.EtFilterForEdgeDetection.ContourThetaForPeaks.Max.ToString();

            tBarFASTThres.SetRange(0, 255);
            tBarFASTThres.Value = _filterManager.EtFilterForEdgeDetection.FASTThreshold;
            lblFASTGetValueAvr.Text = _filterManager.EtFilterForEdgeDetection.FASTThreshold.ToString();

            tBarConvThres.SetRange(0, 255);
            tBarConvThres.Value = _filterManager.EtFilterForImage.ConvThreshold;
            lblConvValue.Text = _filterManager.EtFilterForImage.ConvThreshold.ToString();

            tBarCanGaus.SetRange(0, 50);
            tBarCanGaus.Value = _filterManager.EtFilterForEdgeDetection.CannyGaussianSize;
            lblCanGausValue.Text = _filterManager.EtFilterForEdgeDetection.CannyGaussianSize.ToString();

            tBarCanHThres.SetRange(0, 255);
            tBarCanHThres.Value = _filterManager.EtFilterForEdgeDetection.CannyHighThreshold;
            lblCanHThresValue.Text = _filterManager.EtFilterForEdgeDetection.CannyHighThreshold.ToString();

            tBarCanLThres.SetRange(0, 255);
            tBarCanLThres.Value = _filterManager.EtFilterForEdgeDetection.CannyLowThreshold;
            lblCanLThresValue.Text = _filterManager.EtFilterForEdgeDetection.CannyLowThreshold.ToString();

            tBarCanSig.SetRange(0, 15);
            tBarCanSig.Value = _filterManager.EtFilterForEdgeDetection.CannySigma;
            lblCanSigmaValue.Text = _filterManager.EtFilterForEdgeDetection.CannySigma.ToString();

            tBarSURFOctaves.SetRange(0, 10);
            tBarSURFOctaves.Value = _filterManager.EtFilterForEdgeDetection.SURFOctaves;
            lblSURFOctave.Text = _filterManager.EtFilterForEdgeDetection.SURFOctaves.ToString();

            tBarSURFStep.SetRange(0, 10);
            tBarSURFStep.Value = _filterManager.EtFilterForEdgeDetection.SURFStep;
            lblSURFStep.Text = _filterManager.EtFilterForEdgeDetection.SURFStep.ToString();

            tBarSURFThres.SetRange(0, 100);
            tBarSURFThres.Value = (int)_filterManager.EtFilterForEdgeDetection.SURFThres * 100000;
            lblSURFThres.Text = _filterManager.EtFilterForEdgeDetection.SURFThres.ToString();

            cbSURFCompute.Checked = _filterManager.EtFilterForEdgeDetection.SURFIsOrientation;
            cbSURF.Checked = _filterManager.EtFilterForEdgeDetection.IsSURFEdge;
            rbSURFDTExtended.Checked = true;


            tBarGaborSize.SetRange(0, 10);
            tBarGaborSize.Value = (int)_filterManager.EtFilterForEdgeDetection.GABORSize;
            lblGaborSize.Text = _filterManager.EtFilterForEdgeDetection.GABORSize.ToString();

            tBarGaborGamma.SetRange(0, 100);
            tBarGaborGamma.Value = (int)_filterManager.EtFilterForEdgeDetection.GABORGamma * 100;
            lblGaborGamma.Text = _filterManager.EtFilterForEdgeDetection.GABORGamma.ToString();

            tBarGaborLambda.SetRange(0, 100);
            tBarGaborLambda.Value = (int)_filterManager.EtFilterForEdgeDetection.GABORLambda * 10;
            lblGaborLambda.Text = _filterManager.EtFilterForEdgeDetection.GABORLambda.ToString();

            tBarGaborSigma.SetRange(0, 100);
            tBarGaborSigma.Value = (int)_filterManager.EtFilterForEdgeDetection.GABORLambda * 10;
            lblGaborSigma.Text = _filterManager.EtFilterForEdgeDetection.GABORLambda.ToString();

            tBarGaborTheta.SetRange(0, 100);
            tBarGaborTheta.Value = (int)_filterManager.EtFilterForEdgeDetection.GABORTheta * 100;
            lblGaborTheta.Text = _filterManager.EtFilterForEdgeDetection.GABORTheta.ToString();

            cbGabor.Checked = _filterManager.EtFilterForEdgeDetection.IsGaborFilter;
        }





        private void tBarCanSig_Scroll(object sender, EventArgs e)
        {
            _fcEventArgs.objGroup = nameof(_filterManager.EtFilterForEdgeDetection);
            _fcEventArgs.objName = nameof(_filterManager.EtFilterForEdgeDetection.CannySigma);
            _fcEventArgs.value = tBarCanSig.Value;
            lblCanSigmaValue.Text = tBarCanSig.Value.ToString();
            OnValueChanged(_fcEventArgs);
        }

        private void tBarCanGaus_Scroll(object sender, EventArgs e)
        {
            _fcEventArgs.objGroup = nameof(_filterManager.EtFilterForEdgeDetection);
            _fcEventArgs.objName = nameof(_filterManager.EtFilterForEdgeDetection.CannyGaussianSize);
            _fcEventArgs.value = tBarCanGaus.Value;
            lblCanGausValue.Text = tBarCanGaus.Value.ToString();
            OnValueChanged(_fcEventArgs);
        }

        private void tBarCanHThres_Scroll(object sender, EventArgs e)
        {
            _fcEventArgs.objGroup = nameof(_filterManager.EtFilterForEdgeDetection);
            _fcEventArgs.objName = nameof(_filterManager.EtFilterForEdgeDetection.CannyHighThreshold);
            _fcEventArgs.value = tBarCanHThres.Value;
            lblCanHThresValue.Text = tBarCanHThres.ToString();
            OnValueChanged(_fcEventArgs);
        }

        private void tBarCanLThres_Scroll(object sender, EventArgs e)
        {
            _fcEventArgs.objGroup = nameof(_filterManager.EtFilterForEdgeDetection);
            _fcEventArgs.objName = nameof(_filterManager.EtFilterForEdgeDetection.CannyLowThreshold);
            _fcEventArgs.value = tBarCanLThres.Value;
            lblCanLThresValue.Text = tBarCanLThres.Value.ToString();
            OnValueChanged(_fcEventArgs);

        }

        private void tBarEucRed_Scroll(object sender, EventArgs e)
        {
            _fcEventArgs.objGroup = nameof(_filterManager.EtFilterForImage);
            _fcEventArgs.objName = nameof(_filterManager.EtFilterForImage.EucRed);
            _fcEventArgs.value = (byte)tBarEucRed.Value;
            lblEucValue.Text = tBarEucRed.Value.ToString();
            lblColor.BackColor = Color.FromArgb(255, _filterManager.EtFilterForImage.EucRed, _filterManager.EtFilterForImage.EucGreen,
               _filterManager.EtFilterForImage.EucBlue);
            OnValueChanged(_fcEventArgs);
        }

        private void tBarEucGreen_Scroll(object sender, EventArgs e)
        {
            _fcEventArgs.objGroup = nameof(_filterManager.EtFilterForImage);
            _fcEventArgs.objName = nameof(_filterManager.EtFilterForImage.EucGreen);
            _fcEventArgs.value = (byte)tBarEucGreen.Value;
            _filterManager.EtFilterForImage.EucAlpha = 255;
            lblEucGreenValue.Text = tBarEucGreen.Value.ToString();
            lblColor.BackColor = Color.FromArgb(_filterManager.EtFilterForImage.EucAlpha, _filterManager.EtFilterForImage.EucRed, _filterManager.EtFilterForImage.EucGreen,
               _filterManager.EtFilterForImage.EucBlue);
            OnValueChanged(_fcEventArgs);
        }

        private void tBarEucBlue_Scroll(object sender, EventArgs e)
        {
            _fcEventArgs.objGroup = nameof(_filterManager.EtFilterForImage);
            _fcEventArgs.objName = nameof(_filterManager.EtFilterForImage.EucBlue);
            _fcEventArgs.value = (byte)tBarEucBlue.Value;
            _filterManager.EtFilterForImage.EucAlpha = 255;
            lblEucBlueValue.Text = tBarEucBlue.Value.ToString();
            lblColor.BackColor = Color.FromArgb(255, _filterManager.EtFilterForImage.EucRed, _filterManager.EtFilterForImage.EucGreen,
                _filterManager.EtFilterForImage.EucBlue);
            OnValueChanged(_fcEventArgs);
        }

        private void tBarEucRa_Scroll(object sender, EventArgs e)
        {
           
            _fcEventArgs.objGroup = nameof(_filterManager.EtFilterForImage);
            _fcEventArgs.objName = nameof(_filterManager.EtFilterForImage.EuclidianColorRadius);
            _fcEventArgs.value = (short)tBarEucRa.Value;
            lblEucRadValue.Text = tBarEucRa.Value.ToString();
            OnValueChanged(_fcEventArgs);
        }

        private void tBarBrightness_Scroll(object sender, EventArgs e)
        {
            _fcEventArgs.objGroup = nameof(_filterManager.EtFilterForImage);
            _fcEventArgs.objName = nameof(_filterManager.EtFilterForImage.BrightnessValue);
            _fcEventArgs.value = tBarBrightness.Value;
            lblBrithValue.Text = tBarBrightness.Value.ToString();
            OnValueChanged(_fcEventArgs);
        }

        private void tBarGamma_Scroll(object sender, EventArgs e)
        {
            _fcEventArgs.objGroup = nameof(_filterManager.EtFilterForImage);
            _fcEventArgs.objName = nameof(_filterManager.EtFilterForImage.GammaCorrectionValue);
            _fcEventArgs.value = tBarGamma.Value;
            lblGammaValue.Text = tBarGamma.Value.ToString();
            OnValueChanged(_fcEventArgs);

        }

        private void tBarGrayCr_Scroll(object sender, EventArgs e)
        {
            _fcEventArgs.objGroup = nameof(_filterManager.EtFilterForImage);
            _fcEventArgs.objName = nameof(_filterManager.EtFilterForImage.GrayScaleCr);
            _fcEventArgs.value = (float)tBarGrayCr.Value / 1000;
            lblGrayCrValue.Text = ((float)tBarGrayCr.Value / 1000).ToString();
            OnValueChanged(_fcEventArgs);
        }

        private void tBarGrayCg_Scroll(object sender, EventArgs e)
        {
            _fcEventArgs.objName = nameof(_filterManager.EtFilterForImage.GrayScaleCg);
            _fcEventArgs.value = (float)tBarGrayCg.Value / 1000;
            lblGrayCgValue.Text = ((float)tBarGrayCg.Value / 1000).ToString();
            OnValueChanged(_fcEventArgs);
        }

        private void tBarGrayCb_Scroll(object sender, EventArgs e)
        {
            _fcEventArgs.objGroup = nameof(_filterManager.EtFilterForImage);
            _fcEventArgs.objName = nameof(_filterManager.EtFilterForImage.GrayScaleCb);
            _fcEventArgs.value = (float)tBarGrayCb.Value / 1000;
            lblGrayCbValue.Text = ((float)tBarGrayCb.Value / 1000).ToString();
            OnValueChanged(_fcEventArgs);
        }

        private void tBarThres_Scroll(object sender, EventArgs e)
        {
            _fcEventArgs.objName = nameof(_filterManager.EtFilterForImage.ThresHoldValue);
            _fcEventArgs.value = _filterManager.EtFilterForImage.ThresHoldValue = tBarThres.Value;
            lblThresValue.Text = _filterManager.EtFilterForImage.ThresHoldValue.ToString();
            OnValueChanged(_fcEventArgs);

        }

        private void tBarCons_Scroll(object sender, EventArgs e)
        {
            _fcEventArgs.objGroup = nameof(_filterManager.EtFilterForImage);
            _fcEventArgs.objName = nameof(_filterManager.EtFilterForImage.ConservativeKernelSizeValue);
            _fcEventArgs.value = tBarCons.Value;
            lblConsValue.Text = tBarCons.Value.ToString();
            OnValueChanged(_fcEventArgs);

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            _fcEventArgs.objName = nameof(_filterManager.EtFilterForImage.IsGrayCommon);
            _fcEventArgs.value = checkBox1.Checked;
            OnValueChanged(_fcEventArgs);
        }

        private void rbChannelRed_CheckedChanged(object sender, EventArgs e)
        {
            _fcEventArgs.objGroup = nameof(_filterManager.EtFilterForImage);
            _fcEventArgs.objName = nameof(_filterManager.EtFilterForImage.ExtraChannelExetraction);
            _fcEventArgs.value = RGB.R;
            OnValueChanged(_fcEventArgs);

        }

        private void rbChannelGreen_CheckedChanged(object sender, EventArgs e)
        {
            _fcEventArgs.objGroup = nameof(_filterManager.EtFilterForImage);
            _fcEventArgs.objName = nameof(_filterManager.EtFilterForImage.ExtraChannelExetraction);
            _fcEventArgs.value = RGB.G;
            OnValueChanged(_fcEventArgs);
        }

        private void rbChannelBlue_CheckedChanged(object sender, EventArgs e)
        {
            _fcEventArgs.objGroup = nameof(_filterManager.EtFilterForImage);
            _fcEventArgs.objName = nameof(_filterManager.EtFilterForImage.ExtraChannelExetraction);
            _fcEventArgs.value = RGB.B;
            OnValueChanged(_fcEventArgs);
        }

        private void cbFilterGrayScale_CheckedChanged(object sender, EventArgs e)
        {
            _fcEventArgs.objGroup = nameof(_filterManager.EtFilterForImage);
            _fcEventArgs.objName = nameof(_filterManager.EtFilterForImage.IsFilterGrayScale);
            _fcEventArgs.value = gbGrayscale.Enabled = cbFilterGrayScale.Checked;
            OnValueChanged(_fcEventArgs);

        }

        private void cbEuc_CheckedChanged(object sender, EventArgs e)
        {
            _fcEventArgs.objGroup = nameof(_filterManager.EtFilterForImage);
            _fcEventArgs.objName = nameof(_filterManager.EtFilterForImage.IsEuclidianColorFilter);
            _fcEventArgs.value = gbEuc.Enabled = cbEuc.Checked;
            OnValueChanged(_fcEventArgs);

        }

        private void cbInvert_CheckedChanged(object sender, EventArgs e)
        {
            _fcEventArgs.objGroup = nameof(_filterManager.EtFilterForImage);
            _fcEventArgs.objName = nameof(_filterManager.EtFilterForImage.IsFilterInvert);
            _fcEventArgs.value = cbInvert.Checked;
            OnValueChanged(_fcEventArgs);

        }

        private void cbChannelExtr_CheckedChanged(object sender, EventArgs e)
        {
            _fcEventArgs.objGroup = nameof(_filterManager.EtFilterForImage);
            _fcEventArgs.objName = nameof(_filterManager.EtFilterForImage.IsExtraChannelExtraction);
            _fcEventArgs.value = gbChannel.Enabled = cbChannelExtr.Checked;
            OnValueChanged(_fcEventArgs);
        }

        private void cbGaus_CheckedChanged(object sender, EventArgs e)
        {
            _fcEventArgs.objGroup = nameof(_filterManager.EtFilterForImage);
            _fcEventArgs.objName = nameof(_filterManager.EtFilterForImage.IsFilterGaussianBlur);
            _fcEventArgs.value = gbGaussian.Enabled = cbGaus.Checked;
            OnValueChanged(_fcEventArgs);
        }

        private void cbContour_CheckedChanged(object sender, EventArgs e)
        {
            _fcEventArgs.objGroup = nameof(_filterManager.EtFilterForEdgeDetection);
            _fcEventArgs.objName = nameof(_filterManager.EtFilterForEdgeDetection.IsFilterContour);
            _fcEventArgs.value = gpContour.Enabled = cbContour.Checked;
            OnValueChanged(_fcEventArgs);

        }

        private void cbBrightness_CheckedChanged(object sender, EventArgs e)
        {
            _fcEventArgs.objGroup = nameof(_filterManager.EtFilterForImage);
            _fcEventArgs.objName = nameof(_filterManager.EtFilterForImage.IsBrightnessCorrection);
            _fcEventArgs.value = gbBrightness.Enabled = cbBrightness.Checked;
            OnValueChanged(_fcEventArgs);
        }

        private void cbGamma_CheckedChanged(object sender, EventArgs e)
        {
            _fcEventArgs.objGroup = nameof(_filterManager.EtFilterForImage);
            _fcEventArgs.objName = nameof(_filterManager.EtFilterForImage.IsGammaCorrection);
            _fcEventArgs.value = gbGamma.Enabled = cbGamma.Checked;
            OnValueChanged(_fcEventArgs);
        }

        private void cbCons_CheckedChanged(object sender, EventArgs e)
        {
            _fcEventArgs.objGroup = nameof(_filterManager.EtFilterForImage);
            _fcEventArgs.objName = nameof(_filterManager.EtFilterForImage.IsNoiseSmooth);
            _fcEventArgs.value = gbNoise.Enabled = cbCons.Checked;
            OnValueChanged(_fcEventArgs);
        }

        private void cbSharpen_CheckedChanged(object sender, EventArgs e)
        {
            _fcEventArgs.objGroup = nameof(_filterManager.EtFilterForImage);
            _fcEventArgs.objName = nameof(_filterManager.EtFilterForImage.IsSharpen);
            _fcEventArgs.value = cbSharpen.Checked;
            OnValueChanged(_fcEventArgs);
        }

        private void cbThres_CheckedChanged(object sender, EventArgs e)
        {
            _fcEventArgs.objGroup = nameof(_filterManager.EtFilterForImage);
            _fcEventArgs.objName = nameof(_filterManager.EtFilterForImage.IsThreshold);
            _fcEventArgs.value = gbThress.Enabled = cbThres.Checked;
            OnValueChanged(_fcEventArgs);

        }

        private void cbCanny_CheckedChanged(object sender, EventArgs e)
        {
            _fcEventArgs.objGroup = nameof(_filterManager.EtFilterForEdgeDetection);
            _fcEventArgs.objName = nameof(_filterManager.EtFilterForEdgeDetection.IsCanny);
            _fcEventArgs.value = gbCanny.Enabled = cbCanny.Checked; ;
            OnValueChanged(_fcEventArgs);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void cbFillOutSide_CheckedChanged(object sender, EventArgs e)
        {
            _fcEventArgs.objGroup = nameof(_filterManager.EtFilterForImage);
            _fcEventArgs.objName = nameof(_filterManager.EtFilterForImage.EuclidianIsFillOutsideColor);
            _fcEventArgs.value = cbFillOutSide.Checked;
            OnValueChanged(_fcEventArgs);
        }

        private void tBarHarrisK_Scroll(object sender, EventArgs e)
        {
            _fcEventArgs.objGroup = nameof(_filterManager.EtFilterForEdgeDetection);
            _fcEventArgs.objName = nameof(_filterManager.EtFilterForEdgeDetection.HarrisKValue);
            _fcEventArgs.value = (float)tBarHarrisK.Value / 1000;
            lblHarrisKValue.Text = ((float)tBarHarrisK.Value / 1000).ToString();
            OnValueChanged(_fcEventArgs);
        }

        private void tBarHarrisSigma_Scroll(object sender, EventArgs e)
        {
            _fcEventArgs.objGroup = nameof(_filterManager.EtFilterForEdgeDetection);
            _fcEventArgs.objName = nameof(_filterManager.EtFilterForEdgeDetection.HarrisSigma);
            _fcEventArgs.value = (float)tBarHarrisSigma.Value / 1000;
            lblHarrisSigmaValue.Text = ((float)tBarHarrisSigma.Value / 1000).ToString();
            OnValueChanged(_fcEventArgs);
        }

        private void tBarHarrisThres_Scroll(object sender, EventArgs e)
        {
            _fcEventArgs.objGroup = nameof(_filterManager.EtFilterForEdgeDetection);
            _fcEventArgs.objName = nameof(_filterManager.EtFilterForEdgeDetection.HarrisThreshold);
            _fcEventArgs.value = (float)tBarHarrisThres.Value / 100;
            lblHarrisThresValue.Text = ((float)tBarHarrisThres.Value).ToString();
            OnValueChanged(_fcEventArgs);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            _fcEventArgs.objGroup = nameof(_filterManager.EtFilterForEdgeDetection);
            _fcEventArgs.objName = nameof(_filterManager.EtFilterForEdgeDetection.HarrisSupression);
            _fcEventArgs.value = tBarHarristBar.Value;
            lblHarrisSupressValue.Text = (tBarHarristBar.Value).ToString();
            OnValueChanged(_fcEventArgs);
        }

        private void cbHarrisIsNoble_CheckedChanged(object sender, EventArgs e)
        {
            _fcEventArgs.objGroup = nameof(_filterManager.EtFilterForEdgeDetection);
            _fcEventArgs.objName = nameof(_filterManager.EtFilterForEdgeDetection.HarrisMesure);

            _fcEventArgs.value = (cbHarrisIsNoble.Checked) ? HarrisCornerMeasure.Noble : HarrisCornerMeasure.Harris;
            OnValueChanged(_fcEventArgs);
        }

        private void tBarContourThreshold_Scroll(object sender, EventArgs e)
        {
            _fcEventArgs.objGroup = nameof(_filterManager.EtFilterForEdgeDetection);
            _fcEventArgs.objName = nameof(_filterManager.EtFilterForEdgeDetection.ContourThreshold);
            _fcEventArgs.value = (byte)tBarContourThreshold.Value;
            lblContourThres.Text = (tBarContourThreshold.Value).ToString();
            OnValueChanged(_fcEventArgs);
        }

        private void tBarContourKernel_Scroll(object sender, EventArgs e)
        {
            _fcEventArgs.objGroup = nameof(_filterManager.EtFilterForEdgeDetection);
            _fcEventArgs.objName = nameof(_filterManager.EtFilterForEdgeDetection.ContourKernelForPeaks);
            _fcEventArgs.value = tBarContourKernel.Value;
            lblContourKernel.Text = (tBarContourKernel.Value).ToString();
            OnValueChanged(_fcEventArgs);
        }

        private void tBarContourSupression_Scroll(object sender, EventArgs e)
        {
            _fcEventArgs.objGroup = nameof(_filterManager.EtFilterForEdgeDetection);
            _fcEventArgs.objName = nameof(_filterManager.EtFilterForEdgeDetection.ContourSupressionForPeaks);
            _fcEventArgs.value = tBarContourSupression.Value;
            lblContourSuppresion.Text = (tBarContourSupression.Value).ToString();
            OnValueChanged(_fcEventArgs);
        }


        private void tBarFASTThres_Scroll(object sender, EventArgs e)
        {
            _fcEventArgs.objGroup = nameof(_filterManager.EtFilterForEdgeDetection);
            _fcEventArgs.objName = nameof(_filterManager.EtFilterForEdgeDetection.FASTThreshold);
            _fcEventArgs.value = tBarFASTThres.Value;
            lblFASTGetValueAvr.Text = (tBarFASTThres.Value).ToString();
            OnValueChanged(_fcEventArgs);
        }

        private void cbFASTSuppress_CheckedChanged(object sender, EventArgs e)
        {
            _fcEventArgs.objGroup = nameof(_filterManager.EtFilterForEdgeDetection);
            _fcEventArgs.objName = nameof(_filterManager.EtFilterForEdgeDetection.FASTSuppress);
            _fcEventArgs.value = cbFASTSuppress.Checked; ;
            OnValueChanged(_fcEventArgs);
        }

        private void cbSolbelScaleIntens_CheckedChanged(object sender, EventArgs e)
        {
            _fcEventArgs.objGroup = nameof(_filterManager.EtFilterForEdgeDetection);
            _fcEventArgs.objName = nameof(_filterManager.EtFilterForEdgeDetection.SobelScaleIntensity);
            _fcEventArgs.value = cbSolbelScaleIntens.Checked; ;
            OnValueChanged(_fcEventArgs);
        }

        private void tBarConvThres_Scroll(object sender, EventArgs e)
        {
            _fcEventArgs.objGroup = nameof(_filterManager.EtFilterForImage);
            _fcEventArgs.objName = nameof(_filterManager.EtFilterForImage.ConvThreshold);
            _fcEventArgs.value = tBarConvThres.Value;
            lblConvValue.Text = (tBarConvThres.Value).ToString();
            OnValueChanged(_fcEventArgs);
        }

        private void cbConvProcessAlpha_CheckedChanged(object sender, EventArgs e)
        {
            _fcEventArgs.objGroup = nameof(_filterManager.EtFilterForImage);
            _fcEventArgs.objName = nameof(_filterManager.EtFilterForImage.ConIsProcessAlpha);
            _fcEventArgs.value = cbConvProcessAlpha.Checked; ;
            OnValueChanged(_fcEventArgs);
        }

        private void cbConvDynamic_CheckedChanged(object sender, EventArgs e)
        {
            _fcEventArgs.objGroup = nameof(_filterManager.EtFilterForImage);
            _fcEventArgs.objName = nameof(_filterManager.EtFilterForImage.ConvIsDynamicDivisorForEdges);
            _fcEventArgs.value = cbConvDynamic.Checked; ;
            OnValueChanged(_fcEventArgs);
        }

        private void cbSobel_CheckedChanged(object sender, EventArgs e)
        {
            _fcEventArgs.objGroup = nameof(_filterManager.EtFilterForEdgeDetection);
            _fcEventArgs.objName = nameof(_filterManager.EtFilterForEdgeDetection.IsSobelEdgedetect);
            _fcEventArgs.value = gbSobel.Enabled = cbSobel.Checked; ;
            OnValueChanged(_fcEventArgs);
            cbFilterGrayScale.Checked = cbSobel.Checked;
        }

        private void cbSISThreshold_CheckedChanged(object sender, EventArgs e)
        {
            _fcEventArgs.objGroup = nameof(_filterManager.EtFilterForImage);
            _fcEventArgs.objName = nameof(_filterManager.EtFilterForImage.IsAdaptiveThreshold);
            _fcEventArgs.value = cbSISThreshold.Checked; ;
            OnValueChanged(_fcEventArgs);

        }

        private void cbFastCornerDetector_CheckedChanged(object sender, EventArgs e)
        {
            _fcEventArgs.objGroup = nameof(_filterManager.EtFilterForEdgeDetection);
            _fcEventArgs.objName = nameof(_filterManager.EtFilterForEdgeDetection.IsFastCornerDetection);
            _fcEventArgs.value = gpFAST.Enabled = cbFastCornerDetector.Checked; ;
            OnValueChanged(_fcEventArgs);
        }

        private void cbHarrisCornerDetector_CheckedChanged(object sender, EventArgs e)
        {
            _fcEventArgs.objGroup = nameof(_filterManager.EtFilterForEdgeDetection);
            _fcEventArgs.objName = nameof(_filterManager.EtFilterForEdgeDetection.IsCornerDetectionHarris);
            _fcEventArgs.value = gbHarrisDetector.Enabled = cbHarrisCornerDetector.Checked; ;
            OnValueChanged(_fcEventArgs);
        }

        private void cbConvolution_CheckedChanged(object sender, EventArgs e)
        {
            _fcEventArgs.objGroup = nameof(_filterManager.EtFilterForImage);
            _fcEventArgs.objName = nameof(_filterManager.EtFilterForImage.IsConclusion);
            _fcEventArgs.value = gbConv.Enabled = cbConvolution.Checked; ;
            OnValueChanged(_fcEventArgs);

        }

        private void tBarGausKernel_Scroll(object sender, EventArgs e)
        {
            _fcEventArgs.objGroup = nameof(_filterManager.EtFilterForImage);
            _fcEventArgs.objName = nameof(_filterManager.EtFilterForImage.GaussionKernel);
            _fcEventArgs.value = tBarGausKernel.Value;
            lblGausKernel.Text = (tBarGausKernel.Value).ToString();
            OnValueChanged(_fcEventArgs);
        }

        private void tBarGausValue_Scroll(object sender, EventArgs e)
        {
            _fcEventArgs.objGroup = nameof(_filterManager.EtFilterForImage);
            _fcEventArgs.objName = nameof(_filterManager.EtFilterForImage.GaussionWert);
            _fcEventArgs.value = (double)tBarGausValue.Value / 10;
            lblGausValue.Text = (tBarGausValue.Value).ToString();
            OnValueChanged(_fcEventArgs);
        }

        private void tbContourDRangeMin_Leave(object sender, EventArgs e)
        {
            _fcEventArgs.objGroup = nameof(_filterManager.EtFilterForEdgeDetection);
            DoubleRange dr = new DoubleRange(Double.Parse(tbContourDRangeMin.Text), Double.Parse(tbContourDRangeMax.Text));
            _fcEventArgs.objName = nameof(_filterManager.EtFilterForEdgeDetection.ContourThetaForPeaks);
            _fcEventArgs.value = dr;
            OnValueChanged(_fcEventArgs);
        }

        private void tbContourDRangeMax_Leave(object sender, EventArgs e)
        {
            _fcEventArgs.objGroup = nameof(_filterManager.EtFilterForEdgeDetection);
            DoubleRange dr = new DoubleRange(Double.Parse(tbContourDRangeMin.Text), Double.Parse(tbContourDRangeMax.Text));
            _fcEventArgs.objName = nameof(_filterManager.EtFilterForEdgeDetection.ContourThetaForPeaks);
            _fcEventArgs.value = dr;
            OnValueChanged(_fcEventArgs);
        }

        private void tBarSURFOctaves_Scroll(object sender, EventArgs e)
        {
            _fcEventArgs.objGroup = nameof(_filterManager.EtFilterForEdgeDetection);
            _fcEventArgs.objName = nameof(_filterManager.EtFilterForEdgeDetection.SURFOctaves);
            _fcEventArgs.value = tBarSURFOctaves.Value;
            lblSURFOctave.Text = (tBarSURFOctaves.Value).ToString();
            OnValueChanged(_fcEventArgs);
        }

        private void tBarSURFThres_Scroll(object sender, EventArgs e)
        {
            _fcEventArgs.objGroup = nameof(_filterManager.EtFilterForEdgeDetection);
            _fcEventArgs.objName = nameof(_filterManager.EtFilterForEdgeDetection.SURFThres);
            _fcEventArgs.value = (float)tBarSURFThres.Value / 100000;
            lblSURFThres.Text = ((float)tBarSURFThres.Value / 100000).ToString();
            OnValueChanged(_fcEventArgs);
        }

        private void tBarSURFStep_Scroll(object sender, EventArgs e)
        {
            _fcEventArgs.objGroup = nameof(_filterManager.EtFilterForEdgeDetection);
            _fcEventArgs.objName = nameof(_filterManager.EtFilterForEdgeDetection.SURFStep);
            _fcEventArgs.value = tBarSURFStep.Value;
            lblSURFStep.Text = (tBarSURFStep.Value).ToString();
            OnValueChanged(_fcEventArgs);
        }

        private void cbSURFCompute_CheckedChanged(object sender, EventArgs e)
        {
            _fcEventArgs.objGroup = nameof(_filterManager.EtFilterForEdgeDetection);
            _fcEventArgs.objName = nameof(_filterManager.EtFilterForEdgeDetection.SURFIsOrientation);
            _fcEventArgs.value = cbSURFCompute.Checked;
            OnValueChanged(_fcEventArgs);
        }

        private void rbSURFDTNone_CheckedChanged(object sender, EventArgs e)
        {
            _fcEventArgs.objGroup = nameof(_filterManager.EtFilterForEdgeDetection);
            _fcEventArgs.objName = nameof(_filterManager.EtFilterForEdgeDetection.SURFDesciptorType);
            _fcEventArgs.value = SpeededUpRobustFeatureDescriptorType.None;
            OnValueChanged(_fcEventArgs);

        }

        private void rbSURFDTExtended_CheckedChanged(object sender, EventArgs e)
        {
            _fcEventArgs.objGroup = nameof(_filterManager.EtFilterForEdgeDetection);
            _fcEventArgs.objName = nameof(_filterManager.EtFilterForEdgeDetection.SURFDesciptorType);
            _fcEventArgs.value = SpeededUpRobustFeatureDescriptorType.Extended;
            OnValueChanged(_fcEventArgs);
        }

        private void rdSURFDTStandard_CheckedChanged(object sender, EventArgs e)
        {
            _fcEventArgs.objGroup = nameof(_filterManager.EtFilterForEdgeDetection);
            _fcEventArgs.objName = nameof(_filterManager.EtFilterForEdgeDetection.SURFDesciptorType);
            _fcEventArgs.value = SpeededUpRobustFeatureDescriptorType.Standard;
            OnValueChanged(_fcEventArgs);
        }

        private void cbSURF_CheckedChanged(object sender, EventArgs e)
        {
            _fcEventArgs.objGroup = nameof(_filterManager.EtFilterForEdgeDetection);
            _fcEventArgs.objName = nameof(_filterManager.EtFilterForEdgeDetection.IsSURFEdge);
            _fcEventArgs.value = gBSurf.Enabled = cbSURF.Checked;
            OnValueChanged(_fcEventArgs);
        }

        private void tBarGaborSize_Scroll(object sender, EventArgs e)
        {
            _fcEventArgs.objGroup = nameof(_filterManager.EtFilterForEdgeDetection);
            _fcEventArgs.objName = nameof(_filterManager.EtFilterForEdgeDetection.GABORSize);
            _fcEventArgs.value = tBarGaborSize.Value;
            lblGaborSize.Text = tBarGaborSize.Value.ToString();
            OnValueChanged(_fcEventArgs);

        }

        private void tBarGaborGamma_Scroll(object sender, EventArgs e)
        {
            _fcEventArgs.objGroup = nameof(_filterManager.EtFilterForEdgeDetection);
            _fcEventArgs.objName = nameof(_filterManager.EtFilterForEdgeDetection.SURFThres);
            _fcEventArgs.value = (float)tBarGaborGamma.Value / 100;
            lblGaborGamma.Text = ((float)tBarGaborGamma.Value / 100).ToString();
            OnValueChanged(_fcEventArgs);
        }

        private void tBarGaborLambda_Scroll(object sender, EventArgs e)
        {
            _fcEventArgs.objGroup = nameof(_filterManager.EtFilterForEdgeDetection);
            _fcEventArgs.objName = nameof(_filterManager.EtFilterForEdgeDetection.GABORLambda);
            _fcEventArgs.value = (float)tBarGaborLambda.Value / 10;
            lblGaborLambda.Text = ((float)tBarGaborLambda.Value / 10).ToString();
            OnValueChanged(_fcEventArgs);
        }

        private void tBarGaborSigma_Scroll(object sender, EventArgs e)
        {
            _fcEventArgs.objGroup = nameof(_filterManager.EtFilterForEdgeDetection);
            _fcEventArgs.objName = nameof(_filterManager.EtFilterForEdgeDetection.GABORSigma);
            _fcEventArgs.value = (float)tBarGaborSigma.Value / 10;
            lblGaborSigma.Text = ((float)tBarGaborSigma.Value / 10).ToString();
            OnValueChanged(_fcEventArgs);
        }

        private void tBarGaborTheta_Scroll(object sender, EventArgs e)
        {
            _fcEventArgs.objGroup = nameof(_filterManager.EtFilterForEdgeDetection);
            _fcEventArgs.objName = nameof(_filterManager.EtFilterForEdgeDetection.GABORTheta);
            _fcEventArgs.value = (float)tBarGaborTheta.Value / 100;
            lblGaborTheta.Text = ((float)tBarGaborTheta.Value / 100).ToString();
            OnValueChanged(_fcEventArgs);
        }

        private void cbGabor_CheckedChanged(object sender, EventArgs e)
        {
            _fcEventArgs.objGroup = nameof(_filterManager.EtFilterForEdgeDetection);
            _fcEventArgs.objName = nameof(_filterManager.EtFilterForEdgeDetection.IsGaborFilter);
            _fcEventArgs.value = gbGabor.Enabled = cbGabor.Checked;
            OnValueChanged(_fcEventArgs);
        }

        private void FilterForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Visible = false;
        }
    }
}
