using AForge;
using AForge.Imaging;
using EyeTrackingMouseV03Lib.Helper;
using System.Collections.Generic;
using System.Drawing;

namespace EyeTrackingMouseV03Lib.Blobs
{
    public class ETBlobCounter
    {
        public readonly RectStabelizer StabRectPupil = new RectStabelizer();

        private EnumROI _instanceOf;

        public ETBlobCounter(EnumROI instanceOf)
        {
            _instanceOf = instanceOf;
        }
        public Color TrackingBoxColor { get; set; } = Color.Brown;
        public bool IsTrackingBoxFixSize { get; set; } = false;
        public int TrackingVelocityLocs { get; set; } = 10;
        public int TrackingVelocityRects { get; set; } = 10;
        public Size TrackingBoxFixSize { get; set; } = Size.Empty;
        public int TrackingBoxSizeScale { get; set; } = 0;

        public int BlobCount { get; private set; }
        public int BlobMinHeight { get; set; }
        public int BlobMinWidth { get; set; }

        public bool IsFilterBlobs { get; set; } = false;
        public int BlobMaxHeight { get; set; }
        public int BlobMaxWidth { get; set; }

        public bool IsCheckCircle { get; set; }
        private ObjectsOrder BlObjectsOrder { get; set; } = ObjectsOrder.Size;


        public Rectangle[] BlobRects { get; private set; }
        public List<IntPoint> BlobPoints { get; private set; }
        public Rectangle StabledBlobRect { get; private set; }
        private BlobCounter blobCounter;

        private UnmanagedImage _unmanagedImage;


        public UnmanagedImage BlobsProcessing(UnmanagedImage im)
        {
            _unmanagedImage = im;

            doBlob(im);


            return _unmanagedImage;
        }

        public Bitmap BlobsProcessing(Bitmap im)
        {
            doBlob(null, im);

            _unmanagedImage = UnmanagedImage.FromManagedImage(im);
            // Drawing.Rectangle(_unmanagedImage, _stabRectPupil.GetAveravgeRectangle(BlobRects), TrackingBoxColor);

            doBlob();
            return _unmanagedImage.ToManagedImage();
        }

        private void doBlob(UnmanagedImage im = null, Bitmap bit = null)
        {
            if (im == null && bit == null) return;

            if (IsFilterBlobs == false) return;


            blobCounter = new BlobCounter(im);

            //blobCounter.BackgroundThreshold = Color.FromArgb(20, 20, 20);

            blobCounter.FilterBlobs = IsFilterBlobs;
            blobCounter.MinHeight = BlobMinHeight;
            blobCounter.MinWidth = BlobMinWidth;
            blobCounter.ObjectsOrder = BlObjectsOrder;
            blobCounter.MaxWidth = BlobMaxWidth;
            blobCounter.MaxHeight = BlobMaxHeight;

            if (im != null)
            {

                blobCounter.ProcessImage(im);

            }
            else
            {
                blobCounter.ProcessImage(bit);
            }


            BlobRects = blobCounter.GetObjectsRectangles();
            BlobCount = blobCounter.ObjectsCount;


            if (IsCheckCircle) IsCircleAndDraw();

            StabRectPupil.VelocitiyForRects = TrackingVelocityRects;
            StabRectPupil.VelocitiyForLocs = TrackingVelocityLocs;
            StabRectPupil.BoxFixedSize = TrackingBoxFixSize;
            StabRectPupil.IsBoxFixedSized = IsTrackingBoxFixSize;
            StabRectPupil.RectSizeScale = TrackingBoxSizeScale;

            StabledBlobRect = StabRectPupil.GetAveravgeRectangle(BlobRects);
        }

        private void IsCircleAndDraw()
        {


            using (Graphics g = Graphics.FromImage(_unmanagedImage.ToManagedImage(false)))
            {
                using (Pen pen1 = new Pen(Color.Chartreuse))
                {

                }
            }

            //SimpleShapeChecker shapeChecker = new SimpleShapeChecker();
            //Graphics g = Graphics.FromImage(bit);
            //Pen redPen = new Pen(Color.Red, 2);
            //// check each object and draw circle around objects, which
            //// are recognized as circles
            //for (int i = 0, n = blobs.Length; i < n; i++)
            //{
            //    BlobPoints = blobCounter.GetBlobsEdgePoints(blobs[i]);


            //    AForge.Point center;
            //    float radius;

            //    if (shapeChecker.IsCircle(BlobPoints, out center, out radius))
            //    {
            //        g.DrawEllipse(redPen,
            //            (int)(center.X - radius),
            //            (int)(center.Y - radius),
            //            (int)(radius * 2),
            //            (int)(radius * 2));
            //    }
            //}

            //redPen.Dispose();

            //g.DrawImage(bit, new PointF(0, 0));
            //g.Dispose();



        }
    }
}
