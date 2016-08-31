using EyeTrackingMouseV03Lib.Helper;
using System;

namespace EyeTrackingMouseV03Lib.EventArgs
{


    public class FilterCriteriaEventArgs : System.EventArgs
    {
        public EnumROI eye;
        public string objGroup;
        public string objName;
        public Object value;
    }
}
