using Accord.Imaging;
using AForge;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using EyeTrackingMouseV03Lib.Utils;
using Point = System.Drawing.Point;

namespace EyeTrackingMouseV03Lib.Helper
{
    public class RectStabelizer
    {
        private int _height;
        private int _width;
        private int _rLocX;
        private int _rLocY;
        private Point _point;
        private PointF _pointF;
        private bool _isNewRect;
        private int _numberOfFrames = 3;

        public string GetListSizesCount => $"Anzahl RectSize: {_stabtSizes.Count}";
        public string GetListPointsCount => $"Anzahl LocPoints: {_stabCenterPoints.Count}";


        public readonly List<Point> _stabtPoints = new List<Point>();
        public readonly List<Size> _stabtSizes = new List<Size>();
        private readonly List<PointF> _stabCenterPoints = new List<PointF>();

        //Main Size / Stabelizing
        private Rectangle _stabRect;
        public Size StabBoxTolerance;
        public Point StabLocationTolerance;
        public bool IsTolerance = false;
        private bool _isTolerance;


        //Range
        IntRange _rangeHeight;
        IntRange _rangeWidth;
        IntRange _rangeLocationX;
        IntRange _rangeLocationY;


        private Point? _refLoc;

        public bool IsBoxFixedSized { get; set; }
        public Size BoxFixedSize { get; set; }

        public int RectSizeScale { get; set; }
        public bool IsAvrFromeCenterPoint { get; set; }

        public int VelocitiyForRects { get; set; }

        public int VelocitiyForLocs { get; set; }

        public int GetLocDats { get { return _stabCenterPoints.Count; } }
        public int GetLocDatsMax { get { return _numberOfFrames; } }
        public Rectangle CurrentRectangle { get; set; }

        public AForge.Point GetCenterPoint => new AForge.Point(CurrentRectangle.Center().X, CurrentRectangle.Center().Y);

        public Rectangle GetAveravgeRectangle(List<Rectangle> listOfRectangles, Point? parentLocation = null)
        {
            _refLoc = parentLocation;

            if (listOfRectangles.Count != 0)
            {
                if (listOfRectangles.Min(p => p.X) < 2 || listOfRectangles.Min(p => p.Y) < 2 || listOfRectangles.Min(p => p.Width) < 2 || listOfRectangles.Min(p => p.Height) < 2) return new Rectangle(_point.X, _point.Y, _width, _height);

                _isNewRect = true;

                float avrLocX = (int)listOfRectangles.Average(p => p.Center().X);
                float avrLocY = (int)listOfRectangles.Average(p => p.Center().Y);
                _stabCenterPoints.Add(new PointF(avrLocX, avrLocY));

                var avrHeight = (int)listOfRectangles.Average(p => p.Height);
                var avrWidth = (int)listOfRectangles.Average(p => p.Width);
                _stabtSizes.Add(new Size(avrWidth, avrHeight));


            }
            DoStabelize();
            _isNewRect = false;
            CurrentRectangle = new Rectangle(_point, new Size(_width, _height));
            if (IsTolerance && _stabtSizes.Count > 4)
            {
                //// Size size = Operations.GetRSizeVariance(_stabtSizes);


                // CurrentRectangle = RectStabByTolerance(CurrentRectangle, size, new Point(0, 0));
            }
            return CurrentRectangle;

        }

        public Rectangle GetAveravgeRectangle(Rectangle[] rectOfRectagles, Point? location = null)
        {

            _refLoc = location;

            if (rectOfRectagles.Length != 0)
            {
                if (rectOfRectagles.Min(p => p.X) < 2 || rectOfRectagles.Min(p => p.Y) < 2 || rectOfRectagles.Min(p => p.Width) < 2 || rectOfRectagles.Min(p => p.Height) < 2) return new Rectangle(_point.X, _point.Y, _width, _height);

                _isNewRect = true;

                float avrLocX = (int)rectOfRectagles.Average(p => p.Center().X);
                float avrLocY = (int)rectOfRectagles.Average(p => p.Center().Y);
                _stabCenterPoints.Add(new PointF(avrLocX, avrLocY));

                var avrHeight = (int)rectOfRectagles.Average(p => p.Height);
                var avrWidth = (int)rectOfRectagles.Average(p => p.Width);
                _stabtSizes.Add(new Size(avrWidth, avrHeight));


            }
            DoStabelize();
            _isNewRect = false;
            CurrentRectangle = new Rectangle(_point, new Size(_width, _height));
            if (IsTolerance && _stabtSizes.Count > 4)
            {
                Size size = Operations.GetRSizeVariance(_stabtSizes);


                CurrentRectangle = RectStabByTolerance(CurrentRectangle, size, new Point(0, 0));
            }
            return CurrentRectangle;

        }


        private void DoStabelize()
        {
            if (_isNewRect)
            {
                if (_stabtSizes.Count > VelocitiyForRects)
                {
                    var counter = _stabtSizes.Count - VelocitiyForRects;
                    _stabtSizes.RemoveRange(0, counter);
                }

                if (IsBoxFixedSized && BoxFixedSize.Height != 0 && BoxFixedSize.Width != 0)
                {
                    _width = BoxFixedSize.Width;
                    _height = BoxFixedSize.Height;
                }
                else
                {

                    _width = (int)_stabtSizes.Average(p => p.Width);
                    _height = (int)_stabtSizes.Average(p => p.Height);
                }

                if (RectSizeScale != 0)
                {
                    _width += RectSizeScale;
                    _height += RectSizeScale;
                }


                if (_stabCenterPoints.Count > VelocitiyForLocs)
                {
                    var counter = _stabCenterPoints.Count - VelocitiyForLocs;
                    _stabCenterPoints.RemoveRange(0, counter);
                }

                if (_stabCenterPoints.Count > 3)
                {
                    //_stabCenterPoints.Sort(_pComF);
                    //List<PointF> pointsGrubb = new List<PointF>();
                    //List<PointF> pointsNalimov = Operations.GetPointsWithoutAberrationsNalimov(_stabCenterPoints, 1.9);
                    //if (pointsNalimov.Count == 0)
                    //{
                    //    pointsGrubb = Operations.GetPointsWithoutAberrationsGrubbs(_stabCenterPoints);
                    //    _point = new Point((int)Math.Round(pointsGrubb.Average(p => p.X)) - (int)_stabtSizes.Average(p => p.Width)/2,
                    //        (int)Math.Round(pointsGrubb.Average(p => p.Y)) - (int)_stabtSizes.Average(p => p.Height)/2);
                    //    _stabCenterPoints.Clear();
                    //    _stabCenterPoints.AddRange(pointsGrubb);
                    //}
                    //else
                    //{
                    //    _point = new Point((int)Math.Round(pointsNalimov.Average(p => p.X) - (int)_stabtSizes.Average(p => p.Width)/2),
                    //        (int)Math.Round(pointsNalimov.Average(p => p.Y)) - (int)_stabtSizes.Average(p => p.Height)/2);
                    //    _stabCenterPoints.Clear();
                    //    _stabCenterPoints.AddRange(pointsNalimov);
                    //}

                    //if (_stabtPoints.Count % 3 == 0)
                    //{

                    //    _point = new Point((int)Math.Round(_stabCenterPoints.Average(p => p.X)) - _width / 2,
                    //        (int)Math.Round(_stabCenterPoints.Average(p => p.Y)) - _height / 2);

                    //}
                    _point = new Point((int)Math.Round(_stabCenterPoints.Average(p => p.X)) - _width / 2,
                            (int)Math.Round(_stabCenterPoints.Average(p => p.Y)) - _height / 2);



                }
                else
                    _point = new Point((int)_stabCenterPoints[0].X - _width / 2, (int)_stabCenterPoints[0].Y - _height / 2);


                if (_refLoc != null)
                {
                    _point.X += _refLoc.Value.X;
                    _point.Y += _refLoc.Value.Y;

                }
            }
            else
            {
                if (_stabCenterPoints.Count != 0) _stabCenterPoints.RemoveAt(0);
                if (_stabtSizes.Count != 0) _stabtSizes.RemoveAt(0);

                if (_stabCenterPoints.Count == 0)
                {
                    _point.X = 0;
                    _point.Y = 0;
                }
                if (_stabtSizes.Count == 0 || _stabCenterPoints.Count == 0)
                {
                    _width = 0;
                    _height = 0;
                }
            }
        }


        private Rectangle RectStabByTolerance(Rectangle rect, Size boxTolerance, Point locationTolerance)
        {

            StabBoxTolerance = boxTolerance;
            StabLocationTolerance = locationTolerance;


            if (!_isTolerance)
            {
                _stabRect = rect;
                _rangeHeight.Max = rect.Height + StabBoxTolerance.Height;
                _rangeHeight.Min = rect.Height - StabBoxTolerance.Height;

                _rangeWidth.Max = rect.Width + StabBoxTolerance.Width;
                _rangeWidth.Min = rect.Width - StabBoxTolerance.Width;

                _rangeLocationX.Max = rect.X + StabLocationTolerance.X;
                _rangeLocationX.Min = rect.X - StabLocationTolerance.X;

                _rangeLocationY.Max = rect.Y + StabLocationTolerance.Y;
                _rangeLocationY.Min = rect.Y - StabLocationTolerance.Y;


            }


            if ((rect.Height <= _rangeHeight.Max && rect.Height >= _rangeHeight.Min)
                    && (rect.Width <= _rangeWidth.Max && rect.Width >= _rangeWidth.Min)
                    && (rect.Y <= _rangeLocationY.Max && rect.Y >= _rangeLocationY.Min)
                    && (rect.X <= _rangeLocationX.Max && rect.X >= _rangeLocationX.Min))
            {
                _isTolerance = true;
                return _stabRect;

            }
            else
            {
                //stabRect = rect;
                _isTolerance = false;
            }

            return _stabRect;

        }
    }
}