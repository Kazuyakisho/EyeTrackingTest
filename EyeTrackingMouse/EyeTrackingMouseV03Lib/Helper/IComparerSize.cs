using System.Collections.Generic;
using System.Drawing;

namespace EyeTrackingMouseV03Lib.Helper
{
    public class IComparerSize : IComparer<Size>
    {
        public int Compare(Size x, Size y)
        {
            int Area1 = x.Height * x.Width;
            int Area2 = y.Height * y.Width;


            if (Area1 < Area2)
                return -1;

            if (Area1 > Area2)
                return 1;

            else
                return 0;

        }
    }
}
