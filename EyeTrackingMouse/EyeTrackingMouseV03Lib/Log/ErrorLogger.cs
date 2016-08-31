using System;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace EyeTrackingMouseV03Lib.Log
{
    public class ErrorLogger
    {
        public delegate void TrackerErrorMessageHandler(string message);

        private static FileStream fs;
        private static StreamWriter logWriter;
        private static string _path;

        private ErrorLogger()
        {
            _path = Assembly.GetExecutingAssembly().Location;
        }

        public static event TrackerErrorMessageHandler TrackerError;

        ~ErrorLogger()
        {
            if (logWriter == null)
                return;
            logWriter.Close();
        }

        public static void WriteLine(string line)
        {
            try
            {
                if (logWriter == null)
                {
                    if (!File.Exists(GetAssemblyDirectory + @"\ErrorLog.txt"))
                    {
                        TextWriter tw = File.CreateText(GetAssemblyDirectory + @"\ErrorLog.txt");

                    }

                    fs = new FileStream(GetAssemblyDirectory + @"\ErrorLog.txt", FileMode.Append);
                    //Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)
                    logWriter = new StreamWriter(fs);
                }
                logWriter.WriteLine(line);
                logWriter.Flush();
                Console.WriteLine(line);
            }
            catch (Exception ex)
            {
                Console.Out.WriteLine("ErrorLogger.cs, exception in WriteLine(string). Message: " + ex.Message);
            }
        }

        public static void ProcessException(Exception ex, bool showMessageBox, [CallerMemberName] string memberName = "", [CallerFilePath] string filePath = "", [CallerLineNumber] int lineNumber = 0)
        {
            WriteLine(DateTime.Now+" Error in method: " + memberName + " on line "+lineNumber +" of "+filePath);
            WriteLine("Message: " + ex.Message);
            //if(ex.InnerException!=null)
            //    WriteLine("   Inner Exception Message: " + ex.InnerException.Message);
            if (!showMessageBox)
                return;
        }

        private static void OnTrackerError(string message)
        {
            if (TrackerError == null)
                return;
            TrackerError(message);
        }

        private static string GetAssemblyDirectory
        {
            get
            {
                string codeBase = Assembly.GetExecutingAssembly().CodeBase;
                UriBuilder uri = new UriBuilder(codeBase);
                string path = Uri.UnescapeDataString(uri.Path);
                return Path.GetDirectoryName(path);
            }
        }
    }
}