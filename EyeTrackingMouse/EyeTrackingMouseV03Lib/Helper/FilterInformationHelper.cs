using AForge.Imaging;
using AForge.Imaging.Filters;

namespace EyeTrackingMouseV03Lib.Helper
{
    public static class FilterInformationHelper
    {

        public static bool FilterSupportsImageFormat(UnmanagedImage im, IFilterInformation info)
        {
            if (info.FormatTranslations.ContainsKey(im.PixelFormat))
            {

                return true;
            }
            else
            {
                return false;
            }


        }
    }
}
