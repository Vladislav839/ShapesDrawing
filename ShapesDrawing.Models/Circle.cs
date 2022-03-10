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
    [SettingsClass(typeof(CircleSettings))]
    public class Circle : Shape
    {
        public PointF PointOnCircle { get; set; }
        public Circle(PointF center, PointF pointOnCircle, Color backgroundColor, Color borderColor)
            : base(backgroundColor, borderColor, center)
        {
            PointOnCircle = pointOnCircle;
        }

        public override void Draw(Graphics graphics, Size canvasSize, int borderWidth)
        {
            var R = Utils.GetDistance(Center, PointOnCircle);

            var rect = new RectangleF(Center.X - (float)R, Center.Y - (float)R, (float)R * 2, (float)R * 2);

            graphics.FillEllipse(new SolidBrush(BackgroundColor), rect);

            graphics.DrawEllipse(new Pen(BorderColor, borderWidth), rect);

        }

        public override void Move()
        {
            throw new NotImplementedException();
        }
    }
}
