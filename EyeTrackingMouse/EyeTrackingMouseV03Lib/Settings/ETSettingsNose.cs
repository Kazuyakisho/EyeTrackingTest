using Accord.Vision.Detection;
using Emgu.CV;
using EyeTrackingMouseV03Lib.Helper;
using System.Drawing;

namespace EyeTrackingMouseV03Lib.Settings
{
    public class ETSettingsNose : INotifyBase
    {
        #region Emgu
        //for EMGU CV
        private readonly CascadeLoader _load;

        private EnumROI _instanceOf;

        public int Neighbours
        {
            get { return GetValue<int>(_instanceOf); }
            set { SetValue(value, _instanceOf); }
        }

        public double ScaleFactor
        {
            get { return GetValue<double>(_instanceOf); }
            set { SetValue(value, _instanceOf); }
        }

        public Size MinSize
        {
            get { return GetValue<Size>(_instanceOf); }
            set { SetValue(value, _instanceOf); }
        }

        public Size MaxSize
        {
            get { return GetValue<Size>(_instanceOf); }
            set { SetValue(value, _instanceOf); }
        }

        #endregion

        public ETSettingsNose(EnumROI instanceOf)
        {
            _instanceOf = instanceOf;
            _load = new CascadeLoader();
            _load.StartCascadeLoad();

        }

        public EnumCascadeFrom EnumCascadeFrom = EnumCascadeFrom.EmguCV;
        public CascadeClassifier CascadeClassifierNoseDetector => _load.CascadeClassifierNose;
        public HaarObjectDetector HaarObjectDetectorNose => _load.ObjectDetectorNose;
    }
}
