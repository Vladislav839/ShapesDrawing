using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

using ShapesDrawing.BL.Attributes;
using ShapesDrawing.BL.Settings;

namespace ShapesDrawing.BL
{
    [ActiveFigure]
    [SettingsClass(typeof(EllipseSettings))]
    class Ellipse : Rectangle
    { 
        public Ellipse(PointF center, List<PointF> Points, Color background, Color borderColor)
           : base(center, Points, background, borderColor)
        {

        }

        public override void Draw(Graphics graphics, Size canvasSize, int borderWidth)
        {
            SolidBrush brush = new SolidBrush(BackgroundColor);

            var rectangle = ConstructRectangle();

            graphics.FillEllipse(brush, rectangle);

            graphics.DrawEllipse(new Pen(BorderColor, borderWidth), rectangle.X, rectangle.Y, rectangle.Width, rectangle.Height);
        }
    }
}
