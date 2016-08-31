using Accord.Vision.Detection;
using AForge.Imaging;
using Emgu.CV;
using Emgu.CV.Structure;
using EyeTrackingMouseV03Lib.Log;
using EyeTrackingMouseV03Lib.Settings;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace EyeTrackingMouseV03Lib.Detection
{
    public class TiltTracker
    {
        private readonly HaarObjectDetector _noseDetector;
        private readonly CascadeClassifier _classifierNose;
        public TiltTracker()
        {
            _noseDetector = ETSettings.Instance.EtSettingsNose.HaarObjectDetectorNose;
            _classifierNose = ETSettings.Instance.EtSettingsNose.CascadeClassifierNoseDetector;
        }



        public List<Rectangle> RectangleNoseList { get; set; } = new List<Rectangle>();
        public void DetectNose(UnmanagedImage input)
        {
            if (input == null) return;
            RectangleNoseList.Clear();

            try
            {
                if (ETSettings.Instance.EtSettingsEyes.EnumCascadeFrom == EnumCascadeFrom.EmguCV)
                {
                    using (var img = new Image<Bgr, byte>(input.ToManagedImage()))
                    {
                        using (var grayscale = img.Convert<Gray, byte>())
                        {
                            var l = _classifierNose.DetectMultiScale(
                                grayscale,
                                ETSettings.Instance.EtSettingsNose.ScaleFactor, ETSettings.Instance.EtSettingsNose.Neighbours,
                                ETSettings.Instance.EtSettingsNose.MinSize, ETSettings.Instance.EtSettingsNose.MaxSize);

                            if (l != null)
                                foreach (var rect in l)
                                {
                                    RectangleNoseList.Add(rect);

                                }



                        }
                    }
                }
                else if (ETSettings.Instance.EtSettingsEyes.EnumCascadeFrom == EnumCascadeFrom.AforgeNet)
                {
                    _noseDetector.ProcessFrame(input);
                    var r = _noseDetector.DetectedObjects;

                    if (r != null && r.Length != 0)
                        foreach (var rect in r)
                        {

                            RectangleNoseList.Add(rect);

                        }


                }

                input.Dispose();
                return;
            }
            catch (Exception ex)
            {
                ErrorLogger.ProcessException(ex, false);
                return;
            }
        }
    }


}
