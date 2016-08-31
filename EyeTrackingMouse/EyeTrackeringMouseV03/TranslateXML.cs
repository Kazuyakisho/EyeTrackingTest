using EyeTrackingMouseV03Lib.Helper;
using System;
using System.IO;
using System.Windows.Forms;

namespace EyeTrackeringMouseV03
{
    public partial class TranslateXML : Form
    {
        public TranslateXML()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOpenFileDialog_Click(object sender, EventArgs e)
        {
            openFileDialog1.DefaultExt = "xml";


            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (!File.Exists(openFileDialog1.FileName))
                    MessageBox.Show("Datei nicht gefunden");
                else if (Path.GetExtension(openFileDialog1.FileName) != ".xml")
                {
                    MessageBox.Show("XML Datei gesucht");
                }
                else {

                    tbXMLFile.Text = Path.GetFileName(openFileDialog1.FileName);
                    textBox1.Text = Path.GetDirectoryName(openFileDialog1.FileName);
                    lblPlaceholder.Text = Path.GetFileNameWithoutExtension(openFileDialog1.FileName);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = folderBrowserDialog1.SelectedPath;

            }
        }

        private void btnTranslate_Click(object sender, EventArgs e)
        {
            TranslateXMLtoCS tXML = new TranslateXMLtoCS();

            tXML.generateCSfromXML(tbXMLFile.Text, textBox1.Text, lblPlaceholder.Text);

            this.Close();
        }
    }
}
