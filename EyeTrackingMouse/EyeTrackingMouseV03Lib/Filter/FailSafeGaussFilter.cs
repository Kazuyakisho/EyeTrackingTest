using System;
using System.Runtime.Serialization;
using AForge.Imaging.Filters;
using EyeTrackingMouseV03Lib.Log;

namespace EyeTrackingMouseV03Lib.Filter
{
    [DataContract]
    public sealed class FailSafeGaussFilter : FailSafeFilter
    {
        public FailSafeGaussFilter() { }

        public FailSafeGaussFilter(double gaussianWert, int gaussianKernel)
        {
            GaussianKernel = gaussianKernel;
            GaussianWert = gaussianWert;
        }

        [DataMember]
        public int GaussianKernel
        {
            get { return ((GaussianBlur)Filter).Size; }
            set
            {
                try
                {
                    ((GaussianBlur)Filter).Size = value;
                }
                catch (Exception ex)
                { ErrorLogger.ProcessException(ex, true); }
            }
        }
        [DataMember]
        public double GaussianWert
        {
            get { return ((GaussianBlur)Filter).Sigma; }
            set
            {
                try
                {
                    ((GaussianBlur)Filter).Sigma = value;
                }
                catch (Exception ex)
                { ErrorLogger.ProcessException(ex, true); }
            }
        }

        protected override IFilter CreateFilter()
        {
            return new GaussianBlur();
        }
    }
}