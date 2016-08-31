using AForge;
using Emgu.CV;
using EyeTrackingMouseV03Lib.Helper;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using Point = System.Drawing.Point;

namespace EyeTrackingMouseV03Lib.Utils
{
    static class Operations
    {
        public static double GetAngleFromPoint(IntPoint startPoint, IntPoint endPoint)
        {
            double xDiff = startPoint.X - endPoint.X;
            double yDiff = startPoint.Y - endPoint.Y;

            return Math.Atan2(yDiff, xDiff) * 180.0 / Math.PI;
        }

        public static Rectangle GetBiggerRectangle(Rectangle rect, int scale = 10)
        {

            rect.Height += scale;
            rect.Width += scale;
            rect.X -= scale / 2;
            rect.Y -= scale / 2;

            return rect;
        }

        public static Rectangle GetCropRectangleByBottomPoint(Rectangle rect, int fromTopPoint, int fromBottomPoint, int scaleFirstX = 2, int scaleFirstY = 2)
        {

            var backUp = rect;
            if (rect.Width > scaleFirstX && rect.Height > scaleFirstY)
            {

                rect.Height += scaleFirstY;
                rect.Width += scaleFirstX;
                rect.X -= scaleFirstX / 2;
                rect.Y -= scaleFirstY / 2;


                rect.Y += fromTopPoint;
                rect.Height -= fromTopPoint;
                rect.Height -= fromBottomPoint;

                if (rect.Height < 1 || rect.Width < 1) return backUp;


            }
            return rect;
        }


        public static double GetLengthFromAxis(IntPoint startPoint, IntPoint endPoint)
        {
            return Math.Sqrt(Math.Pow(endPoint.X - startPoint.X, 2) + Math.Pow(endPoint.Y - startPoint.Y, 2));
        }

        public static Point GetMeanPoint(List<Point> points)
        {
            return new Point((int)Math.Round(points.Average(p => p.X)), (int)Math.Round(points.Average(p => p.Y)));
        }

        public static PointF GetMeanPointF(List<PointF> points)
        {
            return new PointF(points.Average(p => p.X), points.Average(p => p.Y));
        }

        static IComparerPointF comPoint = new IComparerPointF();

        public static List<PointF> GetPointsWithoutAberrationsNalimov(List<PointF> points, double crit)
        {
            int n = points.Count;
            double xAvr = points.Average(p => p.X);
            double yAvr = points.Average(p => p.Y);

            PointF devi = GetPointStandardDeviation(points);
            double deviX = devi.X;
            double deviY = devi.Y;

            List<PointF> pointN = new List<PointF>();
            foreach (var p in points)
            {
                double qX = Math.Abs((p.X - xAvr) / deviX) * Math.Sqrt(n / (n - 1));
                double qY = Math.Abs((p.Y - yAvr) / deviY) * Math.Sqrt(n / (n - 1));
                if (qX < crit && qY < crit) pointN.Add(p);
            }

            return pointN;


        }
        public static List<PointF> GetPointsWithoutAberrationsGrubbs(List<PointF> points)
        {
            if (points.Count < 10) return points;
            //Sort before
            bool isEven = false;
            int countQ2 = points.Count / 2 - 1;
            int countQ1 = countQ2 / 2 - 1;
            int countQ3 = points.Count / 2 + countQ2 - 1;

            if (points.Count % 2 == 0) isEven = true;

            //Y Median
            double Q2Y = (isEven) ? points[countQ2].Y : (points[countQ2].Y + points[countQ2 + 1].Y) / 2;
            double Q1Y = (isEven) ? points[countQ1].Y : (points[countQ1].Y + points[countQ1 + 1].Y) / 2;
            double Q3Y = (isEven) ? points[countQ3].Y : (points[countQ3].Y + points[countQ3 + 1].Y) / 2;

            //X Median
            comPoint.IsSortX = true;
            points.Sort(comPoint);
            double Q2X = (isEven) ? points[countQ2].X : (points[countQ2].X + points[countQ2 + 1].X) / 2;
            double Q1X = (isEven) ? points[countQ1].X : (points[countQ1].X + points[countQ1 + 1].X) / 2;
            double Q3X = (isEven) ? points[countQ3].X : (points[countQ3].X + points[countQ3 + 1].X) / 2;


            //range 
            double rangeX = (Q3X - Q1X) * (Q3X - Q1X);
            double rangeY = (Q3Y - Q1Y) * (Q3Y - Q1Y);

            //range abs
            double rangeXMin = Q2X - rangeX;
            double rangeXMax = Q2X + rangeX;

            double rangeYMin = Q2Y - rangeY;
            double rangeYMax = Q2Y + rangeY;

            //new List
            List<PointF> pointsAbs = new List<PointF>();
            foreach (var p in points)
            {
                if (p.X >= rangeXMin && p.X <= rangeXMax && p.Y >= rangeYMin && p.Y <= rangeYMax)
                    pointsAbs.Add(p);

            }

            return pointsAbs;

        }

        public static List<Size> GetSizeWithoutAberrationsGrubbs(List<Size> sizes)
        {
            //Median
            double Q2X = sizes.Sum(p => p.Width) / 2;
            double Q2Y = sizes.Sum(p => p.Height) / 2;

            //Quartil
            double Q1X = sizes.Sum(p => (p.Width < Q2X) ? p.Width : 0) / 2;
            double Q1Y = sizes.Sum(p => (p.Height < Q2Y) ? p.Height : 0) / 2;

            double Q3X = sizes.Sum(p => (p.Width > Q2X) ? p.Width : 0) / 2;
            double Q3Y = sizes.Sum(p => (p.Height > Q2Y) ? p.Height : 0) / 2;

            //range 
            double rangeX = (Q3X - Q1X) * (Q3X - Q1X);
            double rangeY = (Q3Y - Q1Y) * (Q3Y - Q1Y);

            //range abs
            double rangeXMin = Q2X - rangeX;
            double rangeXMax = Q2X + rangeX;

            double rangeYMin = Q2Y - rangeY;
            double rangeYMax = Q2Y + rangeY;

            //new List
            List<Size> sizeAbs = new List<Size>();
            foreach (var p in sizes)
            {
                if (p.Width >= rangeXMin && p.Width <= rangeXMax && p.Height >= rangeYMin && p.Height <= rangeYMax)
                    sizeAbs.Add(p);

            }

            return sizeAbs;
        }
        public static Size GetRSizeVariance(List<Size> rects)
        {
            int Count = rects.Count;
            double widthAvr = rects.Average(p => p.Width);
            double heightAvr = rects.Average(p => p.Height);

            double widthS2 = 0;
            double heightS2 = 0;

            foreach (var rectangle in rects)
            {
                widthS2 += Math.Pow((rectangle.Width - widthAvr), 2);
                heightS2 += Math.Pow((rectangle.Height - heightAvr), 2);

            }

            return new Size((int)Math.Round(widthS2 / Count), (int)Math.Round(heightS2 / Count));
        }

        public static Size GetSizeStandardDeviation(List<Size> num)
        {
            Size p = GetRSizeVariance(num);

            return new Size((int)Math.Sqrt(p.Width), (int)Math.Sqrt(p.Height));
        }




        public static Point GetPointVariance(List<Point> points)
        {
            if (points.Count < 2) return new Point(0, 0);

            int Count = points.Count;
            double xAvr = points.Average(p => p.X);
            double yAvr = points.Average(p => p.Y);
            double xS2 = 0;
            double yS2 = 0;

            foreach (var point in points)
            {
                xS2 += Math.Pow((point.X - xAvr), 2);
                yS2 += Math.Pow((point.Y - yAvr), 2);
            }

            return new Point((int)Math.Round(xS2 / Count), (int)Math.Round(yS2 / Count));
        }



        public static PointF GetPointVariance(List<PointF> points)
        {
            if (points.Count < 2) return new Point(0, 0);

            float Count = points.Count;
            float xAvr = points.Average(p => p.X);
            float yAvr = points.Average(p => p.Y);
            float xS2 = 0;
            float yS2 = 0;

            foreach (var point in points)
            {
                xS2 += (float)Math.Pow((point.X - xAvr), 2);
                yS2 += (float)Math.Pow((point.Y - yAvr), 2);
            }

            return new PointF(xS2 / Count, yS2 / Count);
        }


        public static Point GetPointStandardDeviation(List<Point> num)
        {
            Point p = GetPointVariance(num);

            return new Point((int)Math.Sqrt(p.X), (int)Math.Sqrt(p.Y));
        }

        public static PointF GetPointStandardDeviation(List<PointF> num)
        {
            PointF p = GetPointVariance(num);

            return new Point((int)Math.Sqrt(p.X), (int)Math.Sqrt(p.Y));
        }


        public static List<PointF> GetLinearRegression(List<Point> points)
        {
            float Count = points.Count;
            float xAvr = (float)points.Average(p => p.X);
            float yAvr = (float)points.Average(p => p.Y);
            float xS2 = 0;
            float yS2 = 0;
            float XDeviation = 0;
            float yDeviation = 0;

            float regreSum = 0;

            foreach (var point in points)
            {
                xS2 += (float)Math.Pow((point.X - xAvr), 2);
                yS2 += (float)Math.Pow((point.Y - yAvr), 2);

                regreSum += (point.X - xAvr) * (point.Y - yAvr);


            }

            float slopeSX = regreSum / xS2;
            float slopeSY = regreSum / yS2;




            //Regress Y
            float bY = yAvr - slopeSY * xAvr;

            List<PointF> regresPointsY = new List<PointF>();
            for (int i = 0; i < points.Count; i++)
            {
                float y = slopeSX * points[i].X + bY;

                regresPointsY.Add(new PointF(points[i].X, y));
            }

            //Regress X
            float bX = yAvr - slopeSX * xAvr;
            List<PointF> regresPointsX = new List<PointF>();
            for (int i = 0; i < points.Count; i++)
            {
                float y = slopeSY * points[i].X + bX;

                regresPointsX.Add(new PointF(points[i].X, y));
            }

            return regresPointsX;

        }

        public static Rectangle GetAvrRectange(List<Rectangle> rectList)
        {
            return new Rectangle(rectList.Last().X, rectList.Last().Y, (int)Math.Round(rectList.Average(p => p.Width), 1), (int)Math.Round(rectList.Average(p => p.Height), 1));
        }







        public static int Sum(int[] numbers)
        {
            int num = 0;
            for (int index = 0; index < numbers.Length; ++index)
                num += numbers[index];
            return num;
        }

        public static double Sum(double[] numbers)
        {
            double num = 0.0;
            for (int index = 0; index < numbers.Length; ++index)
                num += numbers[index];
            return num;
        }

        public static ETPoint[] ConvertToArray(Matrix<double> pointsMatrix)
        {
            ETPoint[] ETPointArray = new ETPoint[pointsMatrix.Rows];
            for (int index = 0; index < pointsMatrix.Rows; ++index)
                ETPointArray[index] = new ETPoint(pointsMatrix[index, 0], pointsMatrix[index, 1]);
            return ETPointArray;
        }

        public static List<int> Permutate(List<int> orgArray)
        {
            List<int> list = new List<int>();
            Random random = new Random();
            do
            {
                int index = random.Next(orgArray.Count);
                list.Add(orgArray[index]);
                orgArray.RemoveAt(index);
            }
            while (orgArray.Count != 0);
            return list;
        }

        public static List<double> Permutate(List<double> orgArray)
        {
            List<double> list = new List<double>();
            Random random = new Random();
            do
            {
                int index = random.Next(orgArray.Count);
                list.Add(orgArray[index]);
                orgArray.RemoveAt(index);
            }
            while (orgArray.Count != 0);
            return list;
        }

        public static ETPoint[] GetRandomPermutation(ETPoint[] points, int numPoints)
        {
            ETPoint[] ETPointArray = new ETPoint[numPoints];
            Random random = new Random();
            int[] numbers = new int[points.Length];
            for (int index = 0; index < numbers.Length; ++index)
                numbers[index] = 0;
            while (Operations.Sum(numbers) < numPoints)
            {
                int index = random.Next(points.Length);
                if (numbers[index] == 0)
                    numbers[index] = 1;
            }
            int index1 = 0;
            for (int index2 = 0; index2 < numbers.Length; ++index2)
            {
                if (numbers[index2] == 1)
                {
                    ETPointArray[index1] = new ETPoint(points[index2]);
                    ++index1;
                }
            }
            return ETPointArray;
        }

        public static double Distance(ETPoint p1, ETPoint p2)
        {
            return Math.Sqrt(Math.Pow(p1.X - p2.X, 2.0) + Math.Pow(p1.Y - p2.Y, 2.0));
        }

        public static double Distance(Point p1, Point p2)
        {
            return Math.Sqrt(Math.Pow((double)(p1.X - p2.X), 2.0) + Math.Pow((double)(p1.Y - p2.Y), 2.0));
        }

        public static double Distance(ETPoint p1, Point p2)
        {
            return Math.Sqrt(Math.Pow(p1.X - (double)p2.X, 2.0) + Math.Pow(p1.Y - (double)p2.Y, 2.0));
        }

        public static double CalculateAngle(ETPoint newPoint, ETPoint oldPoint)
        {
            return newPoint.X - oldPoint.X != 0.0 ? Math.Atan((newPoint.Y - oldPoint.Y) / (newPoint.X - oldPoint.X)) * 180.0 / Math.PI : (newPoint.Y - oldPoint.Y <= 0.0 ? -90.0 : 90.0);
        }

        public static double CalculateAngleDegrees(Point p1, Point p2)
        {
            double num1 = (double)(p1.X - p2.X);
            double num2 = (double)(p1.Y - p2.Y);
            return (num1 != 0.0 ? (num2 != 0.0 ? (num1 >= 0.0 ? (num2 >= 0.0 ? Math.Atan(num2 / num1) : Math.Atan(num2 / num1) + 2.0 * Math.PI) : Math.Atan(num2 / num1) + Math.PI) : (num1 <= 0.0 ? Math.PI : 0.0)) : (num1 != 0.0 ? (num2 <= 0.0 ? 3.0 * Math.PI / 2.0 : Math.PI / 2.0) : 0.0)) * 180.0 / Math.PI;
        }

        public static bool IsWithinBounds(Rectangle small, Rectangle large)
        {
            return small.Y >= large.Y && small.Y + small.Height <= large.Y + large.Height && small.X >= large.X && small.X + small.Width <= large.X + large.Width;
        }





    }
}
