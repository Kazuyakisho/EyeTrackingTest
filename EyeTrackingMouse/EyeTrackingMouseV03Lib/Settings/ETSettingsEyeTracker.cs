using Accord.Vision.Detection;
using Emgu.CV;
using EyeTrackingMouseV03Lib.Helper;
using System.Drawing;

namespace EyeTrackingMouseV03Lib.Settings
{
    public sealed class ETSettingsEyeTracker : INotifyBase
    {

        #region Emgu
        //for EMGU CV
        private readonly CascadeLoader _load;

        private EnumROI _instanceOf;

        public int NeighboursRightEye
        {
            get { return GetValue<int>(_instanceOf); }
            set { SetValue(value, _instanceOf); }
        }

        public double ScaleFactorRightEye
        {
            get { return GetValue<double>(_instanceOf); }
            set { SetValue(value, _instanceOf); }
        }

        public Size MinSizeRightEye
        {
            get { return GetValue<Size>(_instanceOf); }
            set { SetValue(value, _instanceOf); }
        }

        public Size MaxSizeRightEye
        {
            get { return GetValue<Size>(_instanceOf); }
            set { SetValue(value, _instanceOf); }
        }

        public int NeighboursLeftEye
        {
            get { return GetValue<int>(_instanceOf); }
            set { SetValue(value, _instanceOf); }
        }

        public double ScaleFactorLeftEye
        {
            get { return GetValue<double>(_instanceOf); }
            set { SetValue(value, _instanceOf); }
        }

        public Size MinSizeLeftEye
        {
            get { return GetValue<Size>(_instanceOf); }
            set { SetValue(value, _instanceOf); }
        }

        public Size MaxSizeLeftEye
        {
            get { return GetValue<Size>(_instanceOf); }
            set { SetValue(value, _instanceOf); }
        }

        #endregion


        public ETSettingsEyeTracker(EnumROI instanceOf)
        {
            _instanceOf = instanceOf;
            _load = new CascadeLoader();
            _load.StartCascadeLoad();
        }
        public EnumCascadeFrom EnumCascadeFrom = EnumCascadeFrom.AforgeNet;
        public CascadeClassifier EyesDetectorLeftEyeEmguCv => _load.CascadeClassifierLeftEye;
        public CascadeClassifier EyesDetectorRightEyeEmguCv => _load.CascadeClassifierRightEye;
        public HaarObjectDetector EyesDetectorRightEyeAforge => _load.ObjectDetectorRightEye;
        public HaarObjectDetector EyesDetectorLeftEyeAforge => _load.ObjDetectorLeftEye;


    }
}

