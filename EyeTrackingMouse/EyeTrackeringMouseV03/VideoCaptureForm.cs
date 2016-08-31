using System;
using System.Collections.Generic;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;

namespace EyeTrackeringMouseV03
{
    public partial class VideoCaptureForm : Form
    {

        private  FilterInfoCollection _videoDevices;
        public int[] Resolution { get; }

        private List<VideoCapabilities> caps;
        public VideoCaptureDevice Cap;
        

        public string VideoDevice { get; private set; }

        public VideoCaptureForm()
        {
            InitializeComponent();
            Resolution = new int[2];
            Resolution[0] = 480;
            Resolution[1] = 320;

            //show device list
            try
            {
                _videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

                if (_videoDevices.Count == 0)
                    throw new ApplicationException();

                if (_videoDevices.Count == 1)
                {
                    devicesCombo.Items.Add(_videoDevices[0].Name);
                    devicesCombo.SelectedIndex = 0;
                    devicesCombo.Enabled = false;


                }else { 

                //add all devices to combo
                foreach (FilterInfo videoDevice in _videoDevices)
                {
                    devicesCombo.Items.Add(videoDevice.Name);
                }
                    devicesCombo.SelectedIndex = 0;
                }


            }
            catch (ApplicationException)
            {
                devicesCombo.Items.Add(" Keine WebCam gefunden");
                devicesCombo.Enabled = false;
                okButton.Enabled = false;
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            //VideoDevice = _videoDevices[devicesCombo.SelectedIndex].MonikerString;
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void rbAufl320_CheckedChanged(object sender, EventArgs e)
        {
            Resolution[0] = 320;
            Resolution[1] = 240;

        }

        private void rbAufl480_CheckedChanged(object sender, EventArgs e)
        {
            Resolution[0] = 480;
            Resolution[1] = 320;
        }

        private void dBAufl640_CheckedChanged(object sender, EventArgs e)
        {
            Resolution[0] = 640;
            Resolution[1] = 480;
        }

        private void devicesCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
          
             Cap = new VideoCaptureDevice(_videoDevices[devicesCombo.SelectedIndex].MonikerString);
             caps = new List<VideoCapabilities>(); 
            if(Cap != null) { 
            foreach (var ca in Cap.VideoCapabilities)
            {
                caps.Add(ca);
                cbResolution.Items.Add($"ID: {cbResolution.SelectedItem} FrameRate: {ca.MaximumFrameRate} Auflösung: {ca.FrameSize}");
            }

            cbResolution.SelectedIndex = 0;
            }
        }

        private void cbResolution_SelectedIndexChanged(object sender, EventArgs e)
        {

            Cap.VideoResolution = caps[cbResolution.SelectedIndex];
        }
    }
}
