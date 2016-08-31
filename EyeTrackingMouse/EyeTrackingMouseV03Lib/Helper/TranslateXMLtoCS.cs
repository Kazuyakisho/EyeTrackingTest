using Accord.Vision.Detection;
using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace EyeTrackingMouseV03Lib.Helper
{
    public class TranslateXMLtoCS
    {
        private HaarCascadeWriter cw;
        private TextWriter _tw;
        private string _outputPath;
        private string _XMLpath;
        private string _filename;
        private string _className;



        private void StartTranslate()
        {
            cw.Write(HaarCascade.FromXml(_XMLpath), _className);

        }

        public void generateCSfromXML(string fileName, string outPptPath, string className)
        {
            _XMLpath = outPptPath + "\\" + fileName;
            _outputPath = outPptPath;
            _className = className;
            try
            {
                _filename = fileName.Replace(".xml", ".cs");

                using (_tw = File.CreateText(_outputPath + "\\" + _filename))
                {
                    cw = new HaarCascadeWriter(_tw);
                    StartTranslate();
                }

                MessageBox.Show(
                    "Eine Datei wurde generiert. Bitte im Ordner Cascade ablegen und in VS hinzufügen");

                // Process.Start("notepad.exe", _path);
                Process.Start("explorer.exe", _outputPath);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }


        }


    }
}
