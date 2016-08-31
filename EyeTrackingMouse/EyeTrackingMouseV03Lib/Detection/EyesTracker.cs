using Accord.Vision.Detection;
using AForge.Imaging;
using Emgu.CV;
using Emgu.CV.Structure;
using EyeTrackingMouseV03Lib.Helper;
using EyeTrackingMouseV03Lib.Log;
using EyeTrackingMouseV03Lib.Settings;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace EyeTrackingMouseV03Lib.Detection
{
    public class EyesTracker
    {
        private readonly HaarObjectDetector _leftEyeDetector;

        private readonly HaarObjectDetector _rightEyeDetector;

        private readonly CascadeClassifier _leftEyeClassifier;

        private readonly CascadeClassifier _rightEyeClassifier;



        //0 - Left, 1 - Right
        public List<Rectangle> LeftEye { get; set; } = new List<Rectangle>();
        public List<Rectangle> RightEye { get; set; } = new List<Rectangle>();


        public EyesTracker()
        {

            _rightEyeDetector = ETSettings.Instance.EtSettingsEyes.EyesDetectorRightEyeAforge;
            _leftEyeDetector = ETSettings.Instance.EtSettingsEyes.EyesDetectorLeftEyeAforge;

            _leftEyeClassifier = ETSettings.Instance.EtSettingsEyes.EyesDetectorLeftEyeEmguCv;
            _rightEyeClassifier = ETSettings.Instance.EtSettingsEyes.EyesDetectorRightEyeEmguCv;



        }
        public void DetectEyes(UnmanagedImage input)
        {
            if (input == null)
                return;
            LeftEye.Clear();
            RightEye.Clear();

            try
            {
                if (ETSettings.Instance.EtSettingsEyes.EnumCascadeFrom == EnumCascadeFrom.EmguCV)
                {
                    using (var img = new Image<Bgr, byte>(input.ToManagedImage()))
                    {
                        using (var grayscale = img.Convert<Gray, byte>())
                        {
                            List<Rectangle> l = _leftEyeClassifier.DetectMultiScale(
                                grayscale,
                                ETSettings.Instance.EtSettingsEyes.ScaleFactorLeftEye, ETSettings.Instance.EtSettingsEyes.NeighboursLeftEye,
                                ETSettings.Instance.EtSettingsEyes.MinSizeLeftEye, ETSettings.Instance.EtSettingsEyes.MaxSizeLeftEye).ToList();


                            List<Rectangle> r = _rightEyeClassifier.DetectMultiScale(grayscale,
                                    ETSettings.Instance.EtSettingsEyes.ScaleFactorRightEye,
                                    ETSettings.Instance.EtSettingsEyes.NeighboursRightEye,
                                    ETSettings.Instance.EtSettingsEyes.MinSizeRightEye, ETSettings.Instance.EtSettingsEyes.MaxSizeRightEye).ToList();

                            l.AddRange(r);


                            foreach (var t in l)
                            {
                                if ((t.X - 0) < (img.Width - (t.X + t.Width)))
                                    RightEye.Add(t);
                                else
                                    LeftEye.Add(t);
                            }

                            l.Clear();
                            r.Clear();

                        }
                    }
                }
                else if (ETSettings.Instance.EtSettingsEyes.EnumCascadeFrom == EnumCascadeFrom.AforgeNet)
                {
                    try { _rightEyeDetector.ProcessFrame(input); }
                    catch (Exception ex)
                    { ErrorLogger.ProcessException(ex, false); }
                    try { _leftEyeDetector.ProcessFrame(input); }
                    catch (Exception ex)
                    { ErrorLogger.ProcessException(ex, false); }
                    var l = _leftEyeDetector.DetectedObjects.ToList();
                    var r = _rightEyeDetector.DetectedObjects.ToList();

                    l.AddRange(r);

                    foreach (var t in l)
                    {
                        if ((t.X - 0) < (input.Width - (t.X + t.Width)))
                            RightEye.Add(t);
                        else
                            LeftEye.Add(t);
                    }

                    l.Clear();
                    r.Clear();
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