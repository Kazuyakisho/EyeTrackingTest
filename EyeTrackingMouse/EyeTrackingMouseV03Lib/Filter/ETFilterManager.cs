using AForge.Imaging;
using EyeTrackingMouseV03Lib.Blobs;
using EyeTrackingMouseV03Lib.Helper;
using System.Drawing;

namespace EyeTrackingMouseV03Lib.Filter
{
    public class ETFilterManager : INotifyBase
    {


        public ETFilterForEdgeDetection EtFilterForEdgeDetection;
        public ETFilterForImage EtFilterForImage;
        public ETBlobCounter TrackingBlobs;

        public bool IsFilterTrackingBlobs { get; set; }
        public ETFilterManager(EnumROI instanceOf)
        {

            EtFilterForEdgeDetection = new ETFilterForEdgeDetection(instanceOf);
            EtFilterForImage = new ETFilterForImage(instanceOf);
            TrackingBlobs = new ETBlobCounter(instanceOf);
        }

        //UnmanagedImage
        public Bitmap FilterImage { get; private set; }


        private UnmanagedImage _unmanagedImage;



        public void ApplyFilter(UnmanagedImage im)
        {
            if (im == null) return;
            _unmanagedImage = EtFilterForImage.Filtering(im);
            _unmanagedImage = EtFilterForEdgeDetection.Filtering(_unmanagedImage);

            if (IsFilterTrackingBlobs)
            {
                _unmanagedImage = TrackingBlobs.BlobsProcessing(_unmanagedImage);

            }

            if (_unmanagedImage == null) return;

            FilterImage = DrawingShapes.DrawEllipse(_unmanagedImage, TrackingBlobs.StabledBlobRect, Color.Aquamarine);
            _unmanagedImage.Dispose();


        }

    }
}
