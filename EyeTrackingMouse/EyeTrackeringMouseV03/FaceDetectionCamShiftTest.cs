using Accord.Vision.Tracking;
using AForge.Video;
using AForge.Video.VFW;
using EyeTrackeringMouseV03.Properties;
using EyeTrackingMouseV03Lib;
using EyeTrackingMouseV03Lib.EventArgs;
using EyeTrackingMouseV03Lib.Helper;
using EyeTrackingMouseV03Lib.Log;
using EyeTrackingMouseV03Lib.Settings;
using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace EyeTrackeringMouseV03
{
    public partial class FaceDetectionCamShiftTest : Form
    {

        private readonly ETSettingsVideo _videoSettings;
        private readonly FaceDetector _faceDetector;
        private FilterForm _fRightEye;
        private FilterForm _fLeftEye;
        private FilterForm _fFace;
        private TranslateXML transXML;

        private readonly Type _typeLeftEyeCritriaFilterForImage;
        private readonly Type _typeRightEyeCriteriaFilterForImage;
        private readonly Type _typeFaceCriteriaFilterForImage;

        private readonly Type _typeLeftEyeCritriaFilterForEdgeDetection;
        private readonly Type _typeRightEyeCriteriaFilterTypeForEdgeDetection;
        private readonly Type _typeFaceCriteriaFilterForEdgeDetection;


        //set Properties
        private void OnValueChanged(object source, FilterCriteriaEventArgs e)
        {
            try
            {
                if (e.eye == EnumROI.LeftEye)
                {
                    if (e.objGroup == nameof(_faceDetector.FcCriteriaLeftEye.EtFilterForImage))
                        _typeLeftEyeCritriaFilterForImage.GetProperty(e.objName)
                            .SetValue(_faceDetector.FcCriteriaLeftEye.EtFilterForImage, e.value);
                    else
                        _typeLeftEyeCritriaFilterForEdgeDetection.GetProperty(e.objName)
                            .SetValue(_faceDetector.FcCriteriaLeftEye.EtFilterForEdgeDetection, e.value);
                }
                else if (e.eye == EnumROI.RightEye)
                {
                    if (e.objGroup == nameof(_faceDetector.FcCriteriaRightEye.EtFilterForImage))
                        _typeRightEyeCriteriaFilterForImage.GetProperty(e.objName)
                            .SetValue(_faceDetector.FcCriteriaRightEye.EtFilterForImage, e.value);
                    else
                        _typeRightEyeCriteriaFilterTypeForEdgeDetection.GetProperty(e.objName)
                            .SetValue(_faceDetector.FcCriteriaRightEye.EtFilterForEdgeDetection, e.value);
                }
                else if (e.eye == EnumROI.Face)
                {
                    if (e.objGroup == nameof(_faceDetector.FcFace.EtFilterForImage))
                        _typeFaceCriteriaFilterForImage.GetProperty(e.objName)
                            .SetValue(_faceDetector.FcFace.EtFilterForImage, e.value);
                    else
                        _typeFaceCriteriaFilterForEdgeDetection.GetProperty(e.objName)
                            .SetValue(_faceDetector.FcFace.EtFilterForEdgeDetection, e.value);
                }
            }
            catch (Exception ex)
            {
                ErrorLogger.ProcessException(ex, false);
            }


        }


        public FaceDetectionCamShiftTest()
        {
            InitializeComponent();

            _faceDetector = FaceDetector.Instance;
            _videoSettings = ETSettings.Instance.EtSettingsVideo;
            _faceDetector.SizeDesktop = new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);

            //connecting propertys

            _typeLeftEyeCritriaFilterForImage = _faceDetector.FcCriteriaLeftEye.EtFilterForImage.GetType();
            _typeRightEyeCriteriaFilterForImage = _faceDetector.FcCriteriaRightEye.EtFilterForImage.GetType();
            _typeFaceCriteriaFilterForImage = _faceDetector.FcFace.EtFilterForImage.GetType();

            _typeLeftEyeCritriaFilterForEdgeDetection = _faceDetector.FcCriteriaLeftEye.EtFilterForEdgeDetection.GetType();
            _typeRightEyeCriteriaFilterTypeForEdgeDetection = _faceDetector.FcCriteriaRightEye.EtFilterForEdgeDetection.GetType();
            _typeFaceCriteriaFilterForEdgeDetection = _faceDetector.FcFace.EtFilterForEdgeDetection.GetType();


            _faceDetector.SizePbFaceBackProjection = pbFaceBackProj.Size;
            _faceDetector.SizePbFaceBox = pbFace.Size;
            _faceDetector.SizePbLeftPupil = pbPupilleft.Size;
            _faceDetector.SizePbRightPupil = pbPubilRight.Size;

            Application.Idle += ProcessFrame;


        }

        private void ProcessFrame(object sender, EventArgs args)
        {

            if (_faceDetector.RectStabLeftEye != null)
            {
                lblNumberOfListPointsLeftEye.Text = _faceDetector.RectStabLeftEye.GetListPointsCount;
                lblNumberOfListSizeLeftEye.Text = _faceDetector.RectStabLeftEye.GetListSizesCount;
                lblNumberOfListRectsLeftPupil.Text = _faceDetector.FcCriteriaLeftEye.TrackingBlobs.StabRectPupil.GetListSizesCount;
                lblNumberOfListPointsLeftpupil.Text = _faceDetector.FcCriteriaLeftEye.TrackingBlobs.StabRectPupil.GetListPointsCount;


            }
            if (_faceDetector.RectStabRightEye != null)
            {
                lblNumberOfListPointsRightEye.Text = _faceDetector.RectStabRightEye.GetListPointsCount;
                lblNumberOfListSizeRightEye.Text = _faceDetector.RectStabRightEye.GetListSizesCount;
                lblNumberOfListRectsRightEye.Text = _faceDetector.FcCriteriaRightEye.TrackingBlobs.StabRectPupil.GetListSizesCount;
                lblNumberOfListPointsRightPupil.Text = _faceDetector.FcCriteriaRightEye.TrackingBlobs.StabRectPupil.GetListPointsCount;
            }
            if (_faceDetector.GetMessageAngleBetweenEyes != "")
            {
                lblAngleBetweenEyes.Text = _faceDetector.GetMessageAngleBetweenEyes;
                lblLengthBetweenEyes.Text = _faceDetector.GetMessangeLengthBeetwennEyes;

            }




            lblBlinkLeft.Text = _faceDetector.GetBlinkMessageLeftEye;
            lblBlinkLeft.BackColor = _faceDetector.GetBlinkColorLeftEye;

            lblBlinkRight.Text = _faceDetector.GetBlinkMessageRightEye;
            lblBlinkRight.BackColor = _faceDetector.GetBlinkColorRightEye;



        }

        private void itemLocalVideo_Click(object sender, EventArgs e)
        {
            VideoCaptureForm form = new VideoCaptureForm();

            if (form.ShowDialog(this) == DialogResult.OK)
            {

                //load VideoSource
                _videoSettings.SetVideoSource(form.Cap);

                _faceDetector.SizeVideoSource = _videoSettings.Resolution;

                //open webcam stream
                OpenVideoSource(_videoSettings.GetVideoSource());

                FaceDetector.Instance.IsCameraDetected = true;

            }
        }

        private void OpenVideoSource(IVideoSource source)
        {
            // set busy cursor
            Cursor = Cursors.WaitCursor;

            //close privious video source
            CloseVideoSource();

            //start new video stream
            videoSourcePlayer1.VideoSource = source;
            vSPProjektion.VideoSource = source;

            videoSourcePlayer1.Start();
            vSPProjektion.Start();


            //reset statistics
            _videoSettings.ResetStatistics();

            //start timers
            timer.Start();


            //source to videosource
            //_videoSettings.VideoSource = source;

            //reset Cursor
            Cursor = Cursors.Default;

            //Doubleclick to finde Faces
            statusLblObjCount.Text = Resources.FaceTracking;


        }

        private void CloseVideoSource()
        {
            //set busy Cursor
            Cursor = Cursors.WaitCursor;

            //stop current video
            videoSourcePlayer1.SignalToStop();
            vSPProjektion.SignalToStop();

            _faceDetector.IsTracking = false;
            _faceDetector.IsDetecting = false;

            //wait 2 seconds until camera stops
            for (int i = 0; (i < 50) && (videoSourcePlayer1.IsRunning); i++)
            {
                Thread.Sleep(100);
            }
            if (videoSourcePlayer1.IsRunning) videoSourcePlayer1.Stop();
            if (vSPProjektion.IsRunning) vSPProjektion.Stop();

            //stop timer
            timer.Stop();

            //reset motion detector
            _faceDetector.CamShiftTracker = new Camshift
            {
                Mode = hSLToolStripMenuItem.Checked
                    ? CamshiftMode.HSL
                    : mixedToolStripMenuItem.Checked
                        ? CamshiftMode.Mixed
                        : CamshiftMode.RGB,
                Conservative = true,
                AspectRatio = 1.5f
            };

            videoSourcePlayer1.BorderColor = Color.Black;


            Cursor = Cursors.Default;

        }

        private void itemExit_Click(object sender, EventArgs e)
        {
            CloseVideoSource();
            Close();
        }

        private void videoSourcePlayer1_NewFrame(object sender, ref Bitmap image)
        {

            _faceDetector.Detecting(ref image);

            if (_faceDetector.BmpFaceBackProjection != null)
            {
                pbFaceBackProj.Image = _faceDetector.BmpFaceBackProjection;
            }
            if (_faceDetector.BmpFilterFace != null)
            {
                pbFace.Image = _faceDetector.BmpFilterFace;
            }
            if (_faceDetector.BmpRightPupil != null)
            {
                pbPubilRight.Image = _faceDetector.BmpRightPupil;
            }

            if (_faceDetector.BmpLeftPupil != null)
            {
                pbPupilleft.Image = _faceDetector.BmpLeftPupil;
            }

            if (_faceDetector.BmpLeftEye != null)
            {
                pbLeftEye.Image = _faceDetector.BmpLeftEye;
            }

            if (_faceDetector.BmpRightEye != null)
            {
                pbRightEye.Image = _faceDetector.BmpRightEye;
            }



        }

        private void defineObject_Click(object sender, EventArgs e)
        {
            if (videoSourcePlayer1.VideoSource != null)
            {
                Bitmap currentVideoFrame = videoSourcePlayer1.GetCurrentVideoFrame();

                if (currentVideoFrame != null)
                {
                    ObjectRegionMotionForm form = new ObjectRegionMotionForm { VideoFrame = currentVideoFrame };

                    // show the dialog
                    if (form.ShowDialog(this) == DialogResult.OK)
                    {
                        Rectangle[] rects = form.ObjRectangle;

                        if (rects.Length == 0)
                            rects = null;

                        _faceDetector.CamShiftTracker.Reset();
                        if (rects != null) _faceDetector.CamShiftTracker.SearchWindow = rects[0];
                        _faceDetector.IsDetecting = false;
                        _faceDetector.IsTracking = true;
                    }
                }
            }
        }

        private void findFaces_Click(object sender, EventArgs e)
        {

            _faceDetector.IsDetecting = true;
            showTrackingWindowToolStripMenuItem.Checked = _faceDetector.IsDrawTrackingWindow = true;
            showObjBoxToolStripMenuItem.Checked = _faceDetector.IsDrawObjectBox = true;
            statusLblObjCount.Text = String.Empty;

        }

        private void rGBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_faceDetector.CamShiftTracker != null)
            {
                _faceDetector.IsTracking = false;
                _faceDetector.CamShiftTracker.Mode = CamshiftMode.RGB;
                _faceDetector.CamShiftTracker.Reset();
                _faceDetector.FaceMarker = null;
            }
            rGBToolStripMenuItem.Checked = true;
            hSLToolStripMenuItem.Checked = false;
            mixedToolStripMenuItem.Checked = false;
        }

        private void hSLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_faceDetector.CamShiftTracker != null)
            {
                _faceDetector.IsTracking = false;
                _faceDetector.CamShiftTracker.Mode = CamshiftMode.HSL;
                _faceDetector.CamShiftTracker.Reset();
                _faceDetector.FaceMarker = null;
            }
            rGBToolStripMenuItem.Checked = false;
            hSLToolStripMenuItem.Checked = true;
            mixedToolStripMenuItem.Checked = false;
        }

        private void mixedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_faceDetector.CamShiftTracker != null)
            {
                _faceDetector.IsTracking = false;
                _faceDetector.CamShiftTracker.Mode = CamshiftMode.Mixed;
                _faceDetector.CamShiftTracker.Reset();
                _faceDetector.FaceMarker = null;
            }
            rGBToolStripMenuItem.Checked = false;
            hSLToolStripMenuItem.Checked = false;
            mixedToolStripMenuItem.Checked = true;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            _videoSettings.SetVideoSource(videoSourcePlayer1.VideoSource);


            statusLblFps.Text = _videoSettings.GetCalculateFps();

        }

        private void FaceDetectionCamShiftTest_FormClosed(object sender, FormClosedEventArgs e)
        {
            CloseVideoSource();
        }

        private void vSPProjektion_NewFrame(object sender, ref Bitmap image)
        {
            _faceDetector.BackProjektion(ref image);
        }

        //ShortCuts
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {

            //Videochannel

            //draw nose
            if (keyData == (Keys.Control | Keys.N))
            {
                toolStripMenuItemNose.PerformClick();
                return true;
            }


            //draw objBox
            if (keyData == (Keys.Control | Keys.R))
            {
                showObjBoxToolStripMenuItem.PerformClick();
                return true;
            }

            //show Axis
            if (keyData == (Keys.Control | Keys.A))
            {
                showAxisToolStripMenuItem.PerformClick();
                return true;
            }

            //show Tracking Window
            if (keyData == (Keys.Control | Keys.W))
            {
                showTrackingWindowToolStripMenuItem.PerformClick();
                return true;
            }


            //Autotune
            //auto face tracking
            if (keyData == (Keys.Control | Keys.T))
            {
                findFaces.PerformClick();
                return true;
            }

            //Form Window
            //define Object
            if (keyData == (Keys.Control | Keys.O))
            {
                defineObject.PerformClick();
                return true;
            }

            //load Kamera
            if (keyData == (Keys.Control | Keys.L))
            {
                itemLocalVideo.PerformClick();
                return true;
            }

            //Mouse Move
            if (keyData == (Keys.Control | Keys.M))
            {
                toolStripMenuItemMouseMove.PerformClick();
                return true;
            }
            //Track Eyes
            if (keyData == (Keys.Control | Keys.E))
            {
                toolStripMenuItem1.PerformClick();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);


        }

        private void videoSpiegelnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_faceDetector.IsCameraDetected)
            {
                videoSpiegelnToolStripMenuItem.Checked = _faceDetector.IsFlipVideo = !videoSpiegelnToolStripMenuItem.Checked;
                statusLblObjCount.ForeColor = Color.Black;
                statusLblObjCount.Text = String.Empty;
            }
            else
            {
                statusLblObjCount.ForeColor = Color.Red;
                statusLblObjCount.Text = Resources.isDetectCamera;
            }
        }

        private void showAxisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_faceDetector.IsCameraDetected)
            {
                showAxisToolStripMenuItem.Checked = _faceDetector.IsShowObjectAxis = !showAxisToolStripMenuItem.Checked;
                statusLblObjCount.ForeColor = Color.Black;
                statusLblObjCount.Text = String.Empty;
            }
            else
            {
                statusLblObjCount.ForeColor = Color.Red;
                statusLblObjCount.Text = Resources.isDetectCamera;
            }
        }

        private void showTrackingWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_faceDetector.IsCameraDetected)
            {
                showTrackingWindowToolStripMenuItem.Checked = _faceDetector.IsDrawTrackingWindow = !showTrackingWindowToolStripMenuItem.Checked;
                statusLblObjCount.ForeColor = Color.Black;
                statusLblObjCount.Text = String.Empty;
            }
            else
            {
                statusLblObjCount.ForeColor = Color.Red;
                statusLblObjCount.Text = Resources.isDetectCamera;
            }
        }

        private void drawObjBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_faceDetector.IsCameraDetected)
            {
                showObjBoxToolStripMenuItem.Checked = _faceDetector.IsDrawObjectBox = !showObjBoxToolStripMenuItem.Checked;
                statusLblObjCount.ForeColor = Color.Black;
                statusLblObjCount.Text = String.Empty;
            }
            else
            {
                statusLblObjCount.ForeColor = Color.Red;
                statusLblObjCount.Text = Resources.isDetectCamera;
            }
        }

        private void AviLadenToolStrip_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {

                // create video source
                AVIFileVideoSource fileSource = new AVIFileVideoSource(openFileDialog.FileName);

                OpenVideoSource(fileSource);
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            toolStripMenuItem1.Checked = _faceDetector.IsDrawEyes = pbLeftEye.Visible = pbRightEye.Visible = !toolStripMenuItem1.Checked;
        }

        private void toolstripItemEmgu_Click(object sender, EventArgs e)
        {
            toolstripItemEmgu.Checked = !toolstripItemEmgu.Checked;

            ETSettings.Instance.EtSettingsEyes.EnumCascadeFrom = !toolstripItemEmgu.Checked ? EnumCascadeFrom.EmguCV : EnumCascadeFrom.AforgeNet;
        }


        private void toolStripMenuItemMouseMove_Click(object sender, EventArgs e)
        {
            toolStripMenuItemMouseMove.Checked = _faceDetector.IsMauseMove = !toolStripMenuItemMouseMove.Checked;
        }

        private void toolStripMenuItemOneDesktop_Click(object sender, EventArgs e)
        {
            toolStripMenuItemOneDesktop.Checked = _faceDetector.IsOneDesktop = !toolStripMenuItemOneDesktop.Checked;
            if (toolStripMenuItemOneDesktop.Checked)
            {
                toolStripMenuItemTwoDesktop.Checked = false;
                toolStripMenuItemThreeDesktop.Checked = false;
            }
        }

        private void toolStripMenuItemTwoDesktop_Click(object sender, EventArgs e)
        {
            toolStripMenuItemTwoDesktop.Checked = _faceDetector.IsTwoDesktop = !toolStripMenuItemTwoDesktop.Checked;
            if (toolStripMenuItemTwoDesktop.Checked)
            {
                toolStripMenuItemOneDesktop.Checked = false;
                toolStripMenuItemThreeDesktop.Checked = false;
            }
        }

        private void toolStripMenuItemThreeDesktop_Click(object sender, EventArgs e)
        {
            toolStripMenuItemThreeDesktop.Checked = _faceDetector.IsThreeDesktop = !toolStripMenuItemThreeDesktop.Checked;
            if (toolStripMenuItemThreeDesktop.Checked)
            {
                toolStripMenuItemOneDesktop.Checked = false;
                toolStripMenuItemTwoDesktop.Checked = false;
            }
        }

        private void rightEyeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_fRightEye != null && !_fRightEye.IsDisposed)
            {

                _fRightEye.Visible = true;
                return;
            }
            _fRightEye = new FilterForm(EnumROI.RightEye);
            _fRightEye.ValueChanged += OnValueChanged;
            _fRightEye.Text = $"Right Eye";
            _fRightEye.Show();
        }

        private void toolStripMenuItemBP_Click(object sender, EventArgs e)
        {
            toolStripMenuItemBP.Checked = vSPProjektion.Visible = pbFaceBackProj.Visible = _faceDetector.IsBackProjektion = !toolStripMenuItemBP.Checked;
        }

        private void leftEyeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_fLeftEye != null && !_fLeftEye.IsDisposed)
            {

                _fLeftEye.Visible = true;
                return;
            }
            _fLeftEye = new FilterForm(EnumROI.LeftEye);
            _fLeftEye.ValueChanged += OnValueChanged;
            _fLeftEye.Text = $"Left Eye";
            _fLeftEye.Show();
        }

        private void faceToolStripMenuItem_Click(object sender, EventArgs e)
        {


            if (_fFace != null && !_fFace.IsDisposed)
            {

                _fFace.Visible = true;
                return;
            }
            _fFace = new FilterForm(EnumROI.Face);
            _fFace.ValueChanged += OnValueChanged;
            _fFace.Text = $"Face";
            _fFace.Show();



        }

        private void faceStripMenuItem2_Click(object sender, EventArgs e)
        {
            faceStripMenuItem2.Checked = _faceDetector.IsShowFaces = pbFace.Visible = !faceStripMenuItem2.Checked;
        }

        private void XMLtoolStripMenuItem_Click(object sender, EventArgs e)
        {


            if (transXML != null && !transXML.IsDisposed) return;
            transXML = new TranslateXML();
            transXML.Show();
        }

        private void toolStripMenuItemNose_Click(object sender, EventArgs e)
        {
            toolStripMenuItemNose.Checked = _faceDetector.IsNose = !toolStripMenuItemNose.Checked;
        }
    }

}
