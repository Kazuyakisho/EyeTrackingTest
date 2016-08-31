using System.Collections.Generic;
using System.Drawing;

namespace EyeTrackingMouseV03Lib.Helper
{
    public class IComparerRectArea : IComparer<Rectangle>
    {
        public int Compare(Rectangle c1, Rectangle c2)
        {
            int Area1 = c1.Height * c1.Width;
            int Area2 = c2.Height * c2.Width;


            if (Area1 < Area2)
                return -1;

            if (Area1 > Area2)
                return 1;

            else
                return 0;
        }
    }

    public class IComparerRectXY : IComparer<Rectangle>
    {
        public int Compare(Rectangle c1, Rectangle c2)
        {
            if (c1.X < c2.X || c1.Y < c2.Y)

                return -1;

            if (c1.X > c2.X || c1.Y > c2.Y)
                return 1;

            else
                return 0;
        }
    }
}
