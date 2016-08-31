using AForge.Imaging;
using System.Drawing;
using System.Drawing.Imaging;

namespace EyeTrackingMouseV03Lib.Helper
{
    public static class ExtensionMethods
    {
        public static Rectangle[] ToRectangleArray(this ETRect[] r)
        {
            Rectangle[] re = new Rectangle[r.Length];
            for (int i = 0; i < r.Length; i++)
            {
                re[i] = (Rectangle)r[i];
            }

            return re;
        }

        public static ETRect[] ToETRectArray(this Rectangle[] r)
        {
            ETRect[] re = new ETRect[r.Length];
            for (int i = 0; i < r.Length; i++)
            {
                re[i] = (ETRect)r[i];
            }

            return re;
        }

        public static UnmanagedImage ConvertToFormat(this UnmanagedImage img, PixelFormat format)
        {
            Bitmap bit = img.ToManagedImage(true);
            Bitmap clone = bit.Clone(new Rectangle(0, 0, bit.Width, bit.Height), format);

            bit.Dispose();


            return UnmanagedImage.FromManagedImage(clone);
        }

        //public static ETPoint EtPointAverage(this IEnumerable<List<ETPoint>> source)
        //{
        //    if (source == null)
        //        return new ETPoint(0.0, 0.0);
        //    ETPoint values = new ETPoint(); //values
        //    long count = 0L; //count

        //    foreach (ETPoint num3 in source)
        //    {
        //        checked { values += num3; }
        //        checked { ++count; }
        //    }
        //    if (count > 0L)
        //        return new ETPoint(values.X / count, values.Y / count);

        //    return new ETPoint(0.0, 0.0);

        //}

        //public static ETPoint EtPointAverage(this IEnumerable<List<ETRect>> source)
        //{
        //    if (source == null)
        //        return new ETPoint(0.0, 0.0);
        //    ETPoint values = new ETPoint(); //values
        //    long count = 0L; //count

        //    foreach (ETRect num3 in source)
        //    {
        //        checked { values += num3.LocationEtPoint; }
        //        checked { ++count; }
        //    }
        //    if (count > 0L)
        //        return new ETPoint(values.X / count, values.Y / count);

        //    return new ETPoint(0.0, 0.0);

        //}

    }
}
