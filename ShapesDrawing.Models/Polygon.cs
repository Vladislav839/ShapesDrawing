using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

using ShapesDrawing.BL.Attributes;
using ShapesDrawing.BL.Settings;

namespace ShapesDrawing.BL
{
    [ActiveFigure]
    [SettingsClass(typeof(PolygonSettings))]
    class Polygon : Shape
    {
        public List<PointF> Points { get; set; }

        public int SidesCount { get; set; }

        public Polygon(PointF center, int sidesCount, List<PointF> points, Color backgroundColor, Color borderColor)
            : base(backgroundColor, borderColor, center)
        {
            Points = points;
            SidesCount = sidesCount;
        }

        public override void Draw(Graphics graphics, Size canvasSize, int borderWidth)
        {

            graphics.FillPolygon(new SolidBrush(BackgroundColor), Points.ToArray());

            graphics.DrawPolygon(new Pen(BorderColor, borderWidth), Points.ToArray());
        }

        public override void Move()
        {
            throw new NotImplementedException();
        }
    }
}
