using Accord.Math.Geometry;
using System.Drawing;

namespace EyeTrackingMouseV03Lib.Helper
{

    public struct ETRect
    {
        public double Width;
        public double Height;
        public double Area;

        public double X;
        public double Y;
        private readonly ETPoint pointStart;
        private readonly ETPoint pointEnd;
        public readonly Size Size;

        public ETPoint LocationEtPoint { get; set; }



        public ETRect(ETPoint pointStart, ETPoint pointEnd)
        {
            Width = pointEnd.X - pointStart.X;
            Height = pointEnd.Y - pointStart.X;
            Size = new Size((int)Width, (int)Height);
            this.pointStart = pointStart;
            this.pointEnd = pointEnd;
            X = (int)pointStart.X;
            Y = (int)pointStart.Y;
            LocationEtPoint = new ETPoint(X, Y);
            Area = Width * Height;


        }

        public ETRect(ETPoint p, double width, double height)
        {

            Width = width;
            Height = height;
            X = p.X;
            Y = p.Y;
            Size = new Size((int)Width, (int)Height);
            Area = Width * Height;
            LocationEtPoint = new ETPoint(X, Y);
            pointStart = new ETPoint(X, Y);
            pointEnd = new ETPoint(X + Width, Y + Height);

        }

        public ETRect(Rectangle r)
        {

            Width = r.Width;
            Height = r.Width;
            X = r.X;
            Y = r.Y;
            Size = r.Size;
            Area = Width * Height;
            LocationEtPoint = new ETPoint(X, Y);
            pointStart = new ETPoint(X, Y);
            pointEnd = new ETPoint(X + Width, Y + Height);

        }

        public ETRect(double x, double y, double width, double height)
        {

            Width = width;
            Height = height;
            X = x;
            Y = y;
            Size = new Size((int)Width, (int)Height);
            Area = Width * Height;
            LocationEtPoint = new ETPoint(X, Y);
            pointStart = new ETPoint(X, Y);
            pointEnd = new ETPoint(X + Width, Y + Height);

        }


        public ETPoint Center()
        {
            return new ETPoint(Width / 2, Height / 2);
        }
        public static explicit operator ETRect(Rectangle r)
        {
            return new ETRect(r);
        }




        public static explicit operator Rectangle(ETRect er)
        {
            return new Rectangle((Point)er.LocationEtPoint, er.Size);
        }


        public ETPoint GetCenterETPointOfRect()
        {
            return new ETPoint(Height / 2 + Y, Width / 2 + X);
        }


        public ETPoint GetCenterPointOfRect()
        {
            return new ETPoint(Height / 2 + Y, Width / 2 + X);
        }

        public Circle GetCenterCircleOfRect(int radius)
        {
            return new Circle(new AForge.Point((int)(Height / 2 + Y), (int)(Width / 2 + X)), radius);
        }

        public static ETRect operator +(ETRect r1, ETRect r2)
        {
            //bigger content
            return new ETRect(r1.pointStart, r2.pointEnd);
        }



        /// <summary>
        /// Area
        /// </summary>
        /// <param name="r1"></param>
        /// <param name="r2"></param>
        /// <returns></returns>
        public static ETRect operator >(ETRect r1, ETRect r2)
        {
            return r1;
        }

        /// <summary>
        /// Area
        /// </summary>
        /// <param name="r1"></param>
        /// <param name="r2"></param>
        /// <returns></returns>
        public static ETRect operator <(ETRect r1, ETRect r2)
        {
            return r2;
        }

        /// <summary>
        /// X Coord- returns rectangle with small X and no intersect with r2
        /// </summary>
        /// <param name="r1"></param>
        /// <param name="r2"></param>
        /// <returns></returns>
        public static ETRect operator <=(ETRect r1, ETRect r2)
        {
            return !RectIntersectWith(r1, r2) && r1.pointStart.X < r2.pointStart.X ? r1 : new ETRect(new ETPoint(0, 0), new ETPoint(0, 0));
        }

        /// <summary>
        /// X Coord- returns rectangle with small X and no intersect with r2
        /// </summary>
        /// <param name="r1"></param>
        /// <param name="r2"></param>
        /// <returns></returns>
        public static ETRect operator >=(ETRect r1, ETRect r2)
        {
            return !RectIntersectWith(r1, r2) && r1.pointStart.X < r2.pointStart.X ? new ETRect(new ETPoint(0, 0), new ETPoint(0, 0)) : r2;
        }


        private static bool RectIntersectWith(ETRect r1, ETRect r2)
        {
            if (r2.X < r1.X + r1.Width && r1.X < r2.X + r2.Width && r2.Y < r1.Y + r1.Height)
                return r1.Y < r2.Y + r2.Height;
            return false;
        }
    }

}

