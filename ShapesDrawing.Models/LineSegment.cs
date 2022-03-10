using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

using ShapesDrawing.BL.Attributes;
using ShapesDrawing.BL.Settings;

namespace ShapesDrawing.BL
{
    [ActiveFigure]
    [SettingsClass(typeof(LineSegmentSettings))]
    class LineSegment : FigureBase
    {
        public PointF Point1 { get; set; }
        public PointF Point2 { get; set; }

        public LineSegment(PointF point1, PointF point2, Color borderColor) : base(point1, borderColor) 
        {
            Point1 = point1;
            Point2 = point2;
        }

        public override void Draw(Graphics graphics, Size canvasSize, int borderWidth)
        {
            graphics.DrawLine(new Pen(BorderColor, borderWidth), Point1, Point2);
        }

        public override void Move()
        {
            throw new NotImplementedException();
        }
    }
}
