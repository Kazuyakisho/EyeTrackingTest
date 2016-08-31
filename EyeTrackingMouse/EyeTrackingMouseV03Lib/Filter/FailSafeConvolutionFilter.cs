using System;
using System.Runtime.Serialization;
using AForge.Imaging.Filters;
using EyeTrackingMouseV03Lib.Log;
using EyeTrackingMouseV03Lib.Utils;

namespace EyeTrackingMouseV03Lib.Filter
{
    [DataContract]
    public class FailSafeConvolutionFilter : FailSafeFilter
    {
        protected override IFilter CreateFilter()
        {
            return new Convolution(new int[,]
            {
                {0,0,0},
                {0,1,0},
                {0,0,0}
            });
        }

        public FailSafeConvolutionFilter(int[,] kernel)
        { ConvolutionKernel = kernel; }

        [DataMember]
        private int[][] Kernel
        {
            get { return ((Convolution)Filter).Kernel.AsJagged(); }
            set
            {
                try
                {
                    ((Convolution)Filter).Kernel = value.AsTwoDimensional();
                }
                catch (Exception ex)
                { ErrorLogger.ProcessException(GenerateSetterException(ex), true); }
            }
        }

        public int[,] ConvolutionKernel
        {
            get { return ((Convolution)Filter).Kernel; }
            set
            {
                try
                {
                    ((Convolution)Filter).Kernel = value;
                }
                catch (Exception ex)
                { ErrorLogger.ProcessException(GenerateSetterException(ex), true); }
            }
        }
        [DataMember]
        public int Threshold
        {
            get { return ((Convolution)Filter).Threshold; }
            set
            {
                try
                {
                    ((Convolution)Filter).Threshold = value;
                }
                catch (Exception ex)
                { ErrorLogger.ProcessException(GenerateSetterException(ex), true); }
            }
        }
        [DataMember]
        public bool ProcessAlpha
        {
            get { return ((Convolution)Filter).ProcessAlpha; }
            set
            {
                try
                {
                    ((Convolution)Filter).ProcessAlpha = value;
                }
                catch (Exception ex)
                { ErrorLogger.ProcessException(GenerateSetterException(ex), true); }
            }
        }
        [DataMember]
        public bool DynamicDivisorForEdges
        {
            get { return ((Convolution)Filter).DynamicDivisorForEdges; }
            set
            {
                try
                {
                    ((Convolution)Filter).DynamicDivisorForEdges = value;
                }
                catch (Exception ex)
                { ErrorLogger.ProcessException(GenerateSetterException(ex), true); }
            }
        }
    }
}
