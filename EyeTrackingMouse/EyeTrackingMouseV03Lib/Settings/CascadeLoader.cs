using Accord.Vision.Detection;
using Accord.Vision.Detection.Cascades;
using Emgu.CV;
using EyeTrackingMouseV03Lib.Cascades;
using EyeTrackingMouseV03Lib.Log;
using System;
using System.IO;

namespace EyeTrackingMouseV03Lib.Settings
{
    public class CascadeLoader
    {

        //Emgu
        public CascadeClassifier CascadeClassifierLeftEye { get; private set; }
        public CascadeClassifier CascadeClassifierRightEye { get; private set; }
        public CascadeClassifier CascadeClassifierNose { get; set; }

        public HaarObjectDetector ObjDetectorLeftEye { get; private set; }
        public HaarObjectDetector ObjectDetectorRightEye { get; private set; }
        public HaarObjectDetector ObjectDetectorNose { get; private set; }
        public void StartCascadeLoad()
        {


            try
            {


                ObjDetectorLeftEye = new HaarObjectDetector(new haarcascade_mcs_lefteye());
                ObjectDetectorRightEye = new HaarObjectDetector(new haarcascade_mcs_righteye());
                ObjectDetectorNose = new HaarObjectDetector(new NoseHaarCascade());

                //Emgu

                if (!File.Exists(EnumCascadeList.haarcascade_mcs_righteye + ".xml"))
                    File.WriteAllText(EnumCascadeList.haarcascade_mcs_righteye + ".xml", Properties.Resources.ResourceManager.GetString(EnumCascadeList.haarcascade_mcs_righteye.ToString()));

                if (!File.Exists(EnumCascadeList.haarcascade_mcs_lefteye + ".xml"))
                    File.WriteAllText(EnumCascadeList.haarcascade_mcs_lefteye + ".xml", Properties.Resources.ResourceManager.GetString(EnumCascadeList.haarcascade_mcs_lefteye.ToString()));

                if (!File.Exists(EnumCascadeList.haarcascade_mcs_lefteye + ".xml"))
                    File.WriteAllText(EnumCascadeList.haarcascade_mcs_lefteye + ".xml", Properties.Resources.ResourceManager.GetString(EnumCascadeList.haarcascade_mcs_lefteye.ToString()));

                if (!File.Exists(EnumCascadeList.haarcascade_iris + ".xml"))
                    File.WriteAllText(EnumCascadeList.haarcascade_iris + ".xml", Properties.Resources.ResourceManager.GetString(EnumCascadeList.haarcascade_iris.ToString()));

                CascadeClassifierRightEye = new CascadeClassifier(EnumCascadeList.haarcascade_mcs_righteye + ".xml");
                CascadeClassifierLeftEye = new CascadeClassifier(EnumCascadeList.haarcascade_mcs_lefteye + ".xml");
                CascadeClassifierNose = new CascadeClassifier(EnumCascadeList.haarcascade_iris + ".xml");






            }
            catch (Exception ex)
            {
                ErrorLogger.ProcessException(ex, true);
            }


        }





    }
}
