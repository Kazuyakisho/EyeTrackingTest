using System.Collections.Generic;
using System.Drawing;

namespace EyeTrackingMouseV03Lib.Helper
{
    public class IComparerPoint : IComparer<Point>
    {
        public bool IsSortX { get; set; }

        public int Compare(Point p1, Point p2)
        {
            if (IsSortX)
            {
                if (p1.X < p2.X)

                    return -1;

                if (p1.X > p2.X)
                    return 1;


                return 0;
            }


            if (p1.Y < p2.Y)
                return -1;

            if (p1.Y > p2.Y)
                return 1;

            return 0;


        }
    }

    public class IComparerPointF : IComparer<PointF>
    {
        public bool IsSortX { get; set; }

        public int Compare(PointF p1, PointF p2)
        {
            if (IsSortX)
            {
                if (p1.X < p2.X)

                    return -1;

                if (p1.X > p2.X)
                    return 1;


                return 0;
            }


            if (p1.Y < p2.Y)
                return -1;

            if (p1.Y > p2.Y)
                return 1;

            return 0;


        }


    }
}
