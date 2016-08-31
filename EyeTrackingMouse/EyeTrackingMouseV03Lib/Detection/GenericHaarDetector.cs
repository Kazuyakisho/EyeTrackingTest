using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accord.Vision.Detection;
using AForge.Controls;

namespace EyeTrackingMouseV03Lib.Detection
{
    public class GenericHaarDetector<T> : Detector where T : HaarCascade
    {
        public GenericHaarDetector() { }

        public GenericHaarDetector(Detector preDetector) : base(preDetector)
        {
        }

        protected override IObjectDetector ObjectDetector
        {
            get { return HaarDetector; }
        }
        public HaarObjectDetector HaarDetector { get; private set; } = new HaarObjectDetector((T)typeof(T).GetConstructor(Type.EmptyTypes).Invoke(null));

    }
}
