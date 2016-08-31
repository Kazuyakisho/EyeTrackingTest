using System;
using System.Drawing;
using System.Windows.Forms;

namespace EyeTrackeringMouseV03
{
    public partial class ObjectRegionMotionForm : Form
    {

        //Video frame sample
        public Bitmap VideoFrame
        {
            set { dRCRectBox.BackgroundImage = value; }

        }

        //Motion REctangles
        public Rectangle[] ObjRectangle
        {
            get { return dRCRectBox.Rectangles; }
            set { dRCRectBox.Rectangles = value; }
        }


        //class constructor
        public ObjectRegionMotionForm()
        {
            InitializeComponent();
            dRCRectBox.OnNewRectangle += new NewRectangleHandler(defineRegionsControl_NewRectangleHandler);
        }

        //On first displaying of the form
        protected override void OnLoad(EventArgs e)
        {
            // get video frame dimension
            if (dRCRectBox.BackgroundImage != null)
            {
                int imageWidth = dRCRectBox.BackgroundImage.Width;
                int imageHeight = dRCRectBox.BackgroundImage.Height;

                // resize region definition control
                dRCRectBox.Size = new Size(imageWidth + 2, imageHeight + 2);
                // resize window
                this.Size = new Size(imageWidth + 50, imageHeight + 130);
            }

            base.OnLoad(e);
        }
        
       //new rectangle definition was finished
        private void defineRegionsControl_NewRectangleHandler(object sender, Rectangle rect)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

    }
}
