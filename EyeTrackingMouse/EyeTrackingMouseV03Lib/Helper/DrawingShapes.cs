using Accord.Imaging;
using AForge.Imaging;
using EyeTrackingMouseV03Lib.Log;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace EyeTrackingMouseV03Lib.Helper
{
    public static class DrawingShapes
    {
        public static Bitmap DrawRectanglesFromArray(UnmanagedImage im, Rectangle[] rects, Color color)
        {
            try
            {
                Bitmap bit = new Bitmap(im.ToManagedImage());
                im.Dispose();

                using (Graphics g = Graphics.FromImage(bit))
                {
                    using (Pen p1 = new Pen(color))
                    {
                        foreach (var rectangle in rects)
                        {
                            g.DrawRectangle(p1, rectangle);
                        }


                    }
                }

                return bit;
            }
            catch (Exception ex)
            {

                ErrorLogger.ProcessException(ex, false);

            }
            return null;

        }

        public static Bitmap DrawRectanglesFromList(UnmanagedImage im, List<Rectangle> rects, Color color)
        {
            try
            {
                Bitmap bit = new Bitmap(im.ToManagedImage());
                im.Dispose();

                using (Graphics g = Graphics.FromImage(bit))
                {
                    using (Pen p1 = new Pen(color))
                    {
                        foreach (var rectangle in rects)
                        {
                            g.DrawRectangle(p1, rectangle);
                        }


                    }
                }

                return bit;
            }
            catch (Exception ex)
            {

                ErrorLogger.ProcessException(ex, false);

            }
            return null;

        }

        public static Bitmap DrawEllipse(UnmanagedImage im, Rectangle rect, Color color)
        {

            try
            {
                Bitmap bit = new Bitmap(im.ToManagedImage());
                im.Dispose();

                using (Graphics g = Graphics.FromImage(bit))
                {
                    using (Pen p1 = new Pen(color))
                    {

                        g.DrawEllipse(p1, rect);



                    }
                }

                return bit;
            }
            catch (Exception ex)
            {

                ErrorLogger.ProcessException(ex, false);

            }
            return null;


        }

        public static Bitmap DrawEllipse(UnmanagedImage im, int x, int y, int radius, Color color)
        {

            try
            {
                Bitmap bit = new Bitmap(im.ToManagedImage());
                im.Dispose();

                using (Graphics g = Graphics.FromImage(bit))
                {
                    using (Pen p1 = new Pen(color))
                    {

                        g.DrawEllipse(p1, x, y, radius, radius);



                    }
                }

                return bit;
            }
            catch (Exception ex)
            {

                ErrorLogger.ProcessException(ex, false);

            }
            return null;


        }

        public static Bitmap DrawEllipse(UnmanagedImage im, double x, double y, double radius, Color color)
        {

            try
            {
                Bitmap bit = new Bitmap(im.ToManagedImage());
                im.Dispose();

                using (Graphics g = Graphics.FromImage(bit))
                {
                    using (Pen p1 = new Pen(color))
                    {

                        g.DrawEllipse(p1, (float)x, (float)y, (float)radius, (float)radius);



                    }
                }

                return bit;
            }
            catch (Exception ex)
            {

                ErrorLogger.ProcessException(ex, false);

            }
            return null;


        }

        public static UnmanagedImage DrawEllipseUnmanagedImage(UnmanagedImage im, double x, double y, double radius, Color color)
        {

            try
            {
                Bitmap bit = new Bitmap(im.ToManagedImage());
                im.Dispose();

                using (Graphics g = Graphics.FromImage(bit))
                {
                    using (Pen p1 = new Pen(color))
                    {

                        g.DrawEllipse(p1, (float)x, (float)y, (float)radius, (float)radius);



                    }
                }

                return UnmanagedImage.FromManagedImage(bit);
            }
            catch (Exception ex)
            {

                ErrorLogger.ProcessException(ex, false);

            }
            return null;


        }

        public static UnmanagedImage DrawEllipseUnmanagedImage(UnmanagedImage im, SpeededUpRobustFeaturePoint point, Color color)
        {

            try
            {
                Bitmap bit = new Bitmap(im.ToManagedImage());
                im.Dispose();

                using (Graphics g = Graphics.FromImage(bit))
                {
                    using (Pen p1 = new Pen(color))
                    {

                        g.DrawEllipse(p1, (float)point.X, (float)point.Y, (float)point.Scale * 5, (float)point.Scale * 5);



                    }
                }

                return UnmanagedImage.FromManagedImage(bit);
            }
            catch (Exception ex)
            {

                ErrorLogger.ProcessException(ex, false);

            }
            return null;


        }

        public static UnmanagedImage DrawHoughCirclesUnmanagedImage(UnmanagedImage im, HoughCircle[] circles, Color color)
        {

            try
            {
                Bitmap bit = new Bitmap(im.ToManagedImage());
                im.Dispose();

                using (Graphics g = Graphics.FromImage(bit))
                {
                    using (Pen p1 = new Pen(color))
                    {
                        foreach (var circle in circles)
                        {
                            g.DrawEllipse(p1, (float)circle.X, (float)circle.Y, (float)circle.Radius, (float)circle.Radius);
                        }





                    }
                }

                return UnmanagedImage.FromManagedImage(bit);
            }
            catch (Exception ex)
            {

                ErrorLogger.ProcessException(ex, false);

            }
            return null;


        }
    }
}
