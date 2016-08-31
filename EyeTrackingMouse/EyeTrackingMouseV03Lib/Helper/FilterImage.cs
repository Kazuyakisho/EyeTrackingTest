//using System.Collections.Generic;
//using System.Drawing;
//using AForge.Imaging;
//using AForge.Imaging.Filters;

//namespace EyeTrackingMouseV03Lib.Helper
//{
//    public class FilterImage
//    {


//        //Filter

//        public  EnumFilterImage.FilterImage[] FilCrop { get; }
//        public  EnumFilterImage.FilterImage[] FilResize { get; }
//        public  EnumFilterImage.FilterImage[] FilCropAndResize { get; }

//        public  EnumFilterImage.FilterImage[] FilGray { get; }
//        public  EnumFilterImage.FilterImage[] FilRotate { get; }
//        public  EnumFilterImage.FilterImage[] FilFlipVertikal { get; }

//        public FilterImage()
//        {


//            FilFlipVertikal = new[]
//            {
//                EnumFilterImage.FilterImage.ImgFilterFlipVertikal
//            };

//            FilResize = new[]
//            {
//                EnumFilterImage.FilterImage.ImgFilterResizeBilinear
//            };

//            FilCrop = new[]
//            {
//                EnumFilterImage.FilterImage.ImgFilterCrop
//            };
//            FilCropAndResize = new[]
//            {
//                EnumFilterImage.FilterImage.ImgFilterCrop,
//                EnumFilterImage.FilterImage.ImgFilterResizeBilinear
//            };


//            FilGray = new[]
//            {
//                EnumFilterImage.FilterImage.ImgFilterCrop,
//                EnumFilterImage.FilterImage.ImgFilterGrayScale,
//                EnumFilterImage.FilterImage.ImgFilterResizeBilinear
//            };



//            FilRotate = new[]
//            {
//                EnumFilterImage.FilterImage.ImgFilterCrop,
//                EnumFilterImage.FilterImage.ImgFilterRotate,
//                EnumFilterImage.FilterImage.ImgFilterResizeBilinear
//            };

//        }

//        /// <summary>
//        /// Get Filter
//        /// </summary>
//        /// <param name="filter">Filter Array</param>
//        /// <param name="bmp">Image</param>
//        /// <param name="width">Resize Width</param>
//        /// <param name="height">Resize Height</param>
//        /// <param name="angle">Angle</param>
//        /// <param name="rect">Rect of obj</param>
//        /// <returns>Bitmap</returns>
//        public UnmanagedImage GetFilter(IEnumerable<EnumFilterImage.FilterImage> filter, UnmanagedImage bmp, int width = 0, int height = 0, double angle = 0, Rectangle rect = new Rectangle())
//        {




//            foreach (var fil in filter)
//            {
//                if (fil == EnumFilterImage.FilterImage.ImgFilterCrop)
//                {
//                    if (!rect.IsEmpty)
//                    {
//                        Crop filterCrop = new Crop(rect); 
//                        bmp = filterCrop.Apply(bmp);

//                    }

//                }
//                else if (fil == EnumFilterImage.FilterImage.ImgFilterResizeBilinear && width != 0 && height != 0)
//                {
//                    ResizeBilinear filterResize = new ResizeBilinear(width, height);
//                    bmp = filterResize.Apply(bmp);

//                }
//                else if (fil == EnumFilterImage.FilterImage.ImgFilterGrayScale)
//                {
//                    Grayscale filterGray = new Grayscale(0.2125, 0.7154, 0.0721);
//                    bmp = filterGray.Apply(bmp);
//                }
//                else if (fil == EnumFilterImage.FilterImage.ImgFilterGrayScaleCommon)
//                {

//                }
//                else if (fil == EnumFilterImage.FilterImage.ImgFilterRotate && angle != 0)
//                {
//                    RotateBilinear filterRotate = new RotateBilinear(angle);
//                    bmp = filterRotate.Apply(bmp);

//                }
//                else if (fil == EnumFilterImage.FilterImage.ImgFilterFlipVertikal)
//                {
//                    Mirror filterFlipImage = new Mirror(false, true);

//                    bmp = filterFlipImage.Apply(bmp);
//                }
//            }

//            return bmp;


//        }

//        public Bitmap GetFilter(IEnumerable<EnumFilterImage.FilterImage> filter, Bitmap bmp, int width = 0, int height = 0, double angle = 0, Rectangle rect = new Rectangle())
//        {


//            //  Bitmap bmpFilter = new Bitmap(bmp);

//            foreach (var fil in filter)
//            {
//                if (fil == EnumFilterImage.FilterImage.ImgFilterCrop)
//                {
//                    if (!rect.IsEmpty)
//                    {
//                        Crop filterCrop = new Crop(rect);
//                        bmp = filterCrop.Apply(bmp);

//                    }

//                }
//                else if (fil == EnumFilterImage.FilterImage.ImgFilterResizeBilinear && width != 0 && height != 0)
//                {
//                    ResizeBilinear filterResize = new ResizeBilinear(width, height);
//                    bmp = filterResize.Apply(bmp);

//                }
//                else if (fil == EnumFilterImage.FilterImage.ImgFilterGrayScale)
//                {
//                    Grayscale filterGray = new Grayscale(0.2125, 0.7154, 0.0721);
//                    bmp = filterGray.Apply(bmp);
//                }
//                else if (fil == EnumFilterImage.FilterImage.ImgFilterGrayScaleCommon)
//                {

//                }
//                else if (fil == EnumFilterImage.FilterImage.ImgFilterRotate && angle != 0)
//                {
//                    RotateBilinear filterRotate = new RotateBilinear(angle);
//                    bmp = filterRotate.Apply(bmp);

//                }
//                else if (fil == EnumFilterImage.FilterImage.ImgFilterFlipVertikal)
//                {
//                    Mirror filterFlipImage = new Mirror(false, true);

//                    bmp = filterFlipImage.Apply(bmp);
//                }
//            }

//            return bmp;


//        }
//    }
//}
