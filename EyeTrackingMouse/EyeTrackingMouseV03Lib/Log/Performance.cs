using System;
using System.Diagnostics;

namespace EyeTrackingMouseV03Lib.Log
{
    public class Performance
    {
        private readonly Stopwatch stopWatch = new Stopwatch();
        private bool isEnabled = true;

        private static readonly Lazy<Performance> _instance = new Lazy<Performance>(() => new Performance());

        public static Performance Now
        {
            get
            {
                return _instance.Value;
            }
        }

        public bool IsEnabled
        {
            get
            {
                return this.isEnabled;
            }
            set
            {
                this.isEnabled = value;
            }
        }

        private Performance()
        {
        }

        public void Start()
        {
            if (!this.isEnabled)
                return;
            this.stopWatch.Reset();
            this.stopWatch.Start();
            Console.WriteLine((string)(object)this.stopWatch.ElapsedMilliseconds + (object)"ms. Start..");
        }

        public void Stamp(string msg)
        {
            if (!this.isEnabled || !this.stopWatch.IsRunning)
                return;
            Console.WriteLine((string)(object)this.stopWatch.ElapsedMilliseconds + (object)"ms. " + msg);
        }

        public void Stop()
        {
            if (!this.isEnabled)
                return;
            this.stopWatch.Stop();
            Console.WriteLine((string)(object)this.stopWatch.ElapsedMilliseconds + (object)"ms. Stop");
        }
    }
}
