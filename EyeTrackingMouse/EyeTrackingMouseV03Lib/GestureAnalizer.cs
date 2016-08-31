using EyeTrackingMouseV03Lib.Utils;
using System.Collections.Generic;
using System.Drawing;

namespace EyeTrackingMouseV03Lib
{
    public enum EnumGestureText
    {
        Normal,
        Blink,
        DoubleClick,
        LeftClick,
        RightClick,
        Lost,
        ScrolllUp,
        ScrollDown

    }


    public class GestureAnalizer
    {

        public bool FoundLeftEye { private get; set; }
        public bool FoundRightEye { private get; set; }
        public bool IsMouseAction { get; set; }
        public Color StateColorLeftEye { get; set; } = Color.BurlyWood;
        public string StateTextLeftEye { get; set; }

        public Color StateColorRightEye { get; set; } = Color.BurlyWood;
        public string StateTextRightEye { get; set; }


        public int CounterBlinkLeft { get; set; } = 40;
        public int CounterBlinkRight { get; set; } = 40;

        private int _counterBlinkLeft = 0;
        private int _counterBlinkRight = 0;
        private int _doubleClickCounterRight = 0;
        private bool _isDoubleClickRight = false;
        private int _doubleClickCounterLeft = 0;
        private bool _isDoubleClickLeft = false;
        private bool _isLeftClick;
        private bool _isRightClick;

        private List<Rectangle> _rightEye = new List<Rectangle>();
        private List<Rectangle> _leftEye = new List<Rectangle>();


        private int _blobcounter = 40;
        public void SetCounter()
        {
            _counterBlinkLeft = CounterBlinkLeft;
            _counterBlinkRight = CounterBlinkRight;
            _doubleClickCounterRight = CounterBlinkRight / 2;
        }
        public void DoGestureAnalyser(Rectangle rightEye, Rectangle leftEye, int blobCountRightEye, int blobCountLeftEye, int locDataRightEye, int locDataLeftEye, int locDataMaxLeftEye, int locDataMaxRightEye)
        {

            //gesture



            if (!FoundLeftEye && !FoundRightEye)
            {
                StateColorLeftEye = Color.Coral;
                StateTextLeftEye = EnumGestureText.Lost.ToString();
                StateColorRightEye = Color.Coral;
                StateTextRightEye = EnumGestureText.Lost.ToString();
                return;
            }



            if (FoundRightEye)
            {
                if (rightEye != null) _rightEye.Add(rightEye);
                if (_rightEye == null) return;

                if (_rightEye.Count > 15)
                {
                    var counter = _rightEye.Count - 15;
                    _rightEye.RemoveRange(0, counter);
                }

                Rectangle avrRightEye = Operations.GetAvrRectange(_rightEye);

                if (rightEye.Height > avrRightEye.Height && rightEye.Width < avrRightEye.Width)
                {
                    _rightEye.Add(rightEye);
                    _isRightClick = false;
                    StateColorRightEye = Color.DarkGoldenrod;
                    StateTextRightEye = EnumGestureText.Normal.ToString();
                    return;
                }
                else if (rightEye.Height < avrRightEye.Height && rightEye.Width > avrRightEye.Width * 1.5)
                {
                    _isRightClick = true;
                    _doubleClickCounterRight++;
                    StateColorRightEye = Color.Chartreuse;
                    StateTextRightEye = EnumGestureText.RightClick.ToString();
                }
                else
                {
                    StateColorRightEye = Color.Coral;
                    StateTextRightEye = EnumGestureText.Normal.ToString();
                    _isDoubleClickRight = false;
                    _counterBlinkRight = CounterBlinkRight;
                }
                _doubleClickCounterRight = 0;
            }
            else
            {
                StateColorRightEye = Color.Coral;
                StateTextRightEye = EnumGestureText.Lost.ToString();
            }

            if (FoundLeftEye)
            {
                if (leftEye != null) _leftEye.Add(leftEye);
                if (_leftEye == null) return;

                if (_leftEye.Count > 15)
                {
                    var counter = _leftEye.Count - 15;
                    _leftEye.RemoveRange(0, counter);
                }

                Rectangle avrLeftEye = Operations.GetAvrRectange(_leftEye);

                if (leftEye.Height > avrLeftEye.Height && leftEye.Width < avrLeftEye.Width)
                {
                    _leftEye.Add(leftEye);
                    _isRightClick = false;
                    StateColorLeftEye = Color.DarkGoldenrod;
                    StateTextLeftEye = EnumGestureText.Normal.ToString();
                    return;
                }
                else if (leftEye.Height < avrLeftEye.Height && leftEye.Width > avrLeftEye.Width * 1.5)
                {
                    _isLeftClick = true;
                    _doubleClickCounterLeft++;
                    StateColorLeftEye = Color.Chartreuse;
                    StateTextLeftEye = EnumGestureText.RightClick.ToString();
                }
                else
                {
                    StateColorLeftEye = Color.Coral;
                    StateTextLeftEye = EnumGestureText.Normal.ToString();
                    _isLeftClick = false;
                    _counterBlinkLeft = CounterBlinkRight;
                }
                _doubleClickCounterRight = 0;
            }
            else
            {
                StateColorLeftEye = Color.Coral;
                StateTextLeftEye = EnumGestureText.Lost.ToString();
            }
        }





    }
}
