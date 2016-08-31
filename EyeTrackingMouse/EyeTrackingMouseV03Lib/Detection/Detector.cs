using System;
using System.Drawing;
using Accord.Vision.Detection;
using AForge.Imaging;
using AForge.Imaging.Filters;
using EyeTrackingMouseV03Lib.Filter;

namespace EyeTrackingMouseV03Lib.Detection
{
    public class ObjectDetectedEventArgs : System.EventArgs
    {
        public Rectangle ObjectBoundingBox { get; }
        public UnmanagedImage DetectionImage { get;}
        public ObjectDetectedEventArgs(UnmanagedImage image, Rectangle boundingBox)
        {
            ObjectBoundingBox = boundingBox;
            DetectionImage = image;
        }
    }

    public abstract class Detector : IDisposable
    {
        //Events
        public delegate void ObjectDetectedHandler(object sender, ObjectDetectedEventArgs args);

        public event ObjectDetectedHandler ObjectDetected;

        protected virtual void OnObjectDetected(ObjectDetectedEventArgs args)
        {
            ObjectDetected?.Invoke(this, args);
        }

        protected abstract IObjectDetector ObjectDetector { get; }
        private Detector PreProcessor { get; }
        public FailSafeFilter Filter { get; set; }

        public virtual void StartDetection(UnmanagedImage image)
        {
            StartDetection(image, Rectangle.Empty);
        }

        public virtual void StartDetection(UnmanagedImage image, Rectangle searchWindow)
        {
            UnmanagedImage temp = image;
            Point offset = new Point();
            if (!searchWindow.IsEmpty)
            {
                offset = searchWindow.Location;
                Crop crop = new Crop(searchWindow);
                temp = crop.Apply(temp);
            }
            if (Filter != null) temp = Filter.Apply(temp);
            Rectangle[] objects = ObjectDetector.ProcessFrame(temp);
            foreach (var obj in objects)
            {
                obj.Offset(offset);
                OnObjectDetected(new ObjectDetectedEventArgs(image, obj));
            }
        }
        
        protected Detector() { }

        protected Detector(Detector preProcessor)
        {
            PreProcessor = preProcessor;
            if (preProcessor != null)
                preProcessor.ObjectDetected += PreProcessor_ObjectDetected;
        }

        private void PreProcessor_ObjectDetected(object sender, ObjectDetectedEventArgs args)
        {
            StartDetection(args.DetectionImage, args.ObjectBoundingBox);
        }

        public virtual void Dispose()
        {
            if(PreProcessor!=null) PreProcessor.ObjectDetected-=PreProcessor_ObjectDetected;
        }
    }
}
