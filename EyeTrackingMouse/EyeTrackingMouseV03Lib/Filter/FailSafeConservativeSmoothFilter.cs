using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using AForge.Imaging.Filters;
using EyeTrackingMouseV03Lib.Log;

namespace EyeTrackingMouseV03Lib.Filter
{
    [DataContract]
    public sealed class FailSafeConservativeSmoothFilter : FailSafeFilter
    {
        protected override IFilter CreateFilter()
        { return new ConservativeSmoothing(); }

        public FailSafeConservativeSmoothFilter(int size)
        { KernelSize = size; }

        [DataMember]
        public int KernelSize
        {
            get { return ((ConservativeSmoothing)Filter).KernelSize; }
            set
            {
                try
                {
                    ((ConservativeSmoothing)Filter).KernelSize = value;
                }
                catch (Exception ex)
                { ErrorLogger.ProcessException(new Exception("Error setting KernelSize of ConservativeSmoothing filter.", ex), true); }
            }
        }
    }
}
