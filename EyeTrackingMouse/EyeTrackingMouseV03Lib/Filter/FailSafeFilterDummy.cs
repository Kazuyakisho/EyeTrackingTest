using System.Drawing;
using System.Runtime.Serialization;
using AForge.Imaging;
using AForge.Imaging.Filters;

namespace EyeTrackingMouseV03Lib.Filter
{
    /// <summary>
    /// Represents a filter that does nothing.
    /// If a loading procedure fails it will return a dummy
    /// </summary>
    [DataContract]
    public sealed class FailSafeFilterDummy : FailSafeFilter
    {
        public override UnmanagedImage Apply(UnmanagedImage image)
        { return image; }

        public override Bitmap Apply(Bitmap image)
        { return image; }

        public override void Apply(UnmanagedImage sourceImage, UnmanagedImage destinationImage)
        {}

        protected override IFilter CreateFilter()
        {
            return this;
        }
    }
}
