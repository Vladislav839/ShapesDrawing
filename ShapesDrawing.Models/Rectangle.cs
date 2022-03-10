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
    [SettingsClass(typeof(RectangleSettings))]
    class Rectangle : Shape
    { 
        public List<PointF> Points { get; set; }

        public Rectangle(PointF center, List<PointF> Points, Color background, Color borderColor) 
            : base(background, borderColor, center)
        {
            this.Points = Points;
        }

        public override void Draw(Graphics graphics, Size canvasSize, int borderWidth)
        {
            SolidBrush brush = new SolidBrush(BackgroundColor);

            var rectangle = ConstructRectangle();

            graphics.FillRectangle(brush, rectangle);

            graphics.DrawRectangle(new Pen(BorderColor, borderWidth), rectangle.X, rectangle.Y, rectangle.Width, rectangle.Height);
        }

        protected RectangleF ConstructRectangle()
        {
            PointF p1 = new PointF(Points[0].X, Points[1].Y);
            PointF p2 = new PointF(Points[1].X, Points[0].Y);

            var width = Math.Abs(Points[0].X - Points[1].X);
            var height = Math.Abs(Points[0].Y - Points[1].Y);

            Points.AddRange(new PointF[] { p1, p2 });

            PointF topLeft = Points.OrderBy(p => p.X).ThenBy(i => i.Y).First();

            return new RectangleF(topLeft.X, topLeft.Y, width, height);
        }

        public override void Move()
        {
            throw new NotImplementedException();
        }
    }
}
