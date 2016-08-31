using AForge.Video;
using AForge.Video.DirectShow;
using System.Drawing;

namespace EyeTrackingMouseV03Lib.Settings
{
    public class ETSettingsVideo
    {
        //create video source
        private IVideoSource VideoSource { get; set; }

        //private static readonly System.Lazy<ETSettingsVideo> _instance = new System.Lazy<ETSettingsVideo>(() => new ETSettingsVideo());

        //public static ETSettingsVideo Instance
        //{
        //    get
        //    {
        //        return _instance.Value;
        //    }


        //}
        //statistic length
        private const int StatLength = 15;
        //current statistic index
        private int _statIndex;
        //ready statistics values
        private int _statReady;
        //statistic array
        private readonly int[] _statCount = new int[StatLength];
        //capture device

        private VideoCaptureDevice _videoCaptureDevice;

        //set Resolution
        private int[] _resolution;

        public Size Resolution
        {
            get
            {
                return new Size(_resolution[0], _resolution[1]);
            }
        }

        public ETSettingsVideo()
        {

        }

        public string GetCalculateFps()
        {


            if (VideoSource != null)
            {
                // get number of frames for the last second
                _statCount[_statIndex] = VideoSource.FramesReceived;

                // increment indexes
                if (++_statIndex >= StatLength)
                    _statIndex = 0;
                if (_statReady < StatLength)
                    _statReady++;

                float fps = 0;

                // calculate average value
                for (int i = 0; i < _statReady; i++)
                {
                    fps += _statCount[i];
                }
                fps /= _statReady;

                _statCount[_statIndex] = 0;

                fps *= 10;

                return fps.ToString("F2") + " fps";
            }
            return "";
        }

        public IVideoSource GetVideoSource()
        {
            return VideoSource;
        }

        public VideoCaptureDevice GetVideoCaptureDevice()
        {
            return _videoCaptureDevice;
        }

        public void SetVideoSource(IVideoSource source)
        {
            VideoSource = source;


            _resolution = new[]
            {
                640,
                320
            };


            _videoCaptureDevice = VideoSource as VideoCaptureDevice;

        }


        public void ResetStatistics()
        {

            _statIndex = 0;
            _statReady = 0;
        }



    }
}
