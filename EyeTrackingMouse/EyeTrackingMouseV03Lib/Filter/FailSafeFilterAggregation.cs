using System.Collections;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using AForge.Imaging;
using AForge.Imaging.Filters;

namespace EyeTrackingMouseV03Lib.Filter
{
    [DataContract]
    public sealed class FailSafeFilterAggregation : FailSafeFilter, IEnumerable<FailSafeFilter>
    {
        [DataMember]
        private List<FailSafeFilter> Filters { get; set; } = new List<FailSafeFilter>();

        protected override IFilter CreateFilter()
        {
            Filters = new List<FailSafeFilter>();
            return this;
        }

        public override UnmanagedImage Apply(UnmanagedImage image)
        {
            if (Filters == null || Filters.Count < 1) return (UnmanagedImage)image.Clone();
            Worked = false;
            UnmanagedImage filteredImage = image;
            foreach (var filter in Filters)
            {
                filteredImage = filter.Apply(filteredImage);
                Worked = filter.Worked || Worked;
            }
            return filteredImage;
        }

        public override PixelFormat SupportedFormat
        {
            get
            {
                if(Filters == null || Filters.Count<1) return PixelFormat.Undefined;
                return Filters.First().SupportedFormat;
            }
        }

        public void AddFilter(FailSafeFilter filter)
        {
            if(Filters == null) Filters = new List<FailSafeFilter>();
            Filters.Add(filter);
        }

        public bool RemoveFilter(FailSafeFilter filter)
        {
            return Filters!=null && Filters.Remove(filter);
        }

        public IEnumerator<FailSafeFilter> GetEnumerator()
        {
            return Filters.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
