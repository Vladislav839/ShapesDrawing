using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

using ShapesDrawing.BL.Attributes;
using ShapesDrawing.BL.Settings;

namespace ShapesDrawing.BL
{
    [ActiveFigure]
    [SettingsClass(typeof(RegularShapeSettings))]
    //[UIName("Regular shape")]
    class RegularShape : Polygon
    {
        public RegularShape(PointF center, int sidesCount, List<PointF> points, Color backgroundColor, Color borderColor)
            : base(center, sidesCount, points, backgroundColor, borderColor)
        {

        }

        public override void Draw(Graphics graphics, Size canvasSize, int borderWidth)
        {
            CalculatePointsToDraw();

            graphics.FillPolygon(new SolidBrush(BackgroundColor), Points.ToArray());

            graphics.DrawPolygon(new Pen(BorderColor, borderWidth), Points.ToArray());
        }

        private void CalculatePointsToDraw()
        {
            var R = Utils.GetDistance(Center, Points.First());

            var alpha = Math.Atan((Points[0].Y - Center.Y) / (Points[0].X - Center.X));

            for (var i = 1; i < SidesCount; i++)
            {
                var x = R * Math.Cos(2.0 * Math.PI * i / SidesCount + alpha) + Center.X;
                var y = R * Math.Sin(2.0 * Math.PI * i / SidesCount + alpha) + Center.Y;

                Points.Add(new PointF((float)x, (float)y));
            }
        }
        public override void Move()
        {
            throw new NotImplementedException();
        }
    }
}
