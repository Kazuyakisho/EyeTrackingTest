using System;
using System.Drawing;

namespace EyeTrackingMouseV03Lib.Helper
{
    public struct ETPoint
    {
        public readonly double X;
        public readonly double Y;



        public ETPoint(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }

        public ETPoint(ETPoint point)
        {
            this.X = point.X;
            this.Y = point.Y;
        }

        public ETPoint(Point point)
        {
            this.X = (double)point.X;
            this.Y = (double)point.Y;
        }

        public static explicit operator ETPoint(Point p)
        {
            return new ETPoint(p.X, p.Y);
        }

        public static explicit operator Point(ETPoint p)
        {
            return new Point((int)p.X, (int)p.Y);
        }

        public static ETPoint operator +(ETPoint p1, ETPoint p2)
        {

            return new ETPoint(p1.X + p2.X, p1.Y + p2.Y);
        }

        public static ETPoint operator -(ETPoint p1, ETPoint p2)
        {
            return new ETPoint(p1.X - p2.X, p1.Y - p2.Y);
        }

        public static ETPoint operator /(ETPoint p1, int k)
        {
            return new ETPoint(p1.X / (double)k, p1.Y / (double)k);
        }

        public static ETPoint operator *(ETPoint p1, int k)
        {
            return new ETPoint(p1.X * (double)k, p1.Y * (double)k);
        }

        public Point ToPoint()
        {
            return new Point((int)Math.Round(this.X), (int)Math.Round(this.Y));
        }

    }
}
