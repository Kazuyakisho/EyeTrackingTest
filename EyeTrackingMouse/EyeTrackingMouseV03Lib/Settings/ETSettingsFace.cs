using Accord.Vision.Detection;
using Accord.Vision.Detection.Cascades;
using EyeTrackingMouseV03Lib.Helper;

namespace EyeTrackingMouseV03Lib.Settings
{
    public class ETSettingsFace
    {

        private EnumROI _instanceOf;
        //HaarCascade
        //object detector
        private readonly HaarObjectDetector _detector;

        public ETSettingsFace(EnumROI instanceOf)
        {
            _instanceOf = instanceOf;
            var haarCascade = new FaceHaarCascade();
            _detector = new HaarObjectDetector(haarCascade);

        }

        public HaarObjectDetector Detector => _detector;
    }
}
