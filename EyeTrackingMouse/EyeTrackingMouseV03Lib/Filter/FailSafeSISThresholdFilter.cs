using AForge.Imaging.Filters;

namespace EyeTrackingMouseV03Lib.Filter
{
    public sealed class FailSafeSISThresholdFilter : FailSafeFilter
    {
        protected override IFilter CreateFilter()
        {
            return new SISThreshold();
        }
        
        public int ProcessAlpha => ((SISThreshold)Filter).ThresholdValue;
    }
}
