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
    [SettingsClass(typeof(PolyLineSettings))]
    class PolyLine : FigureBase
    {
        public List<PointF> Points { get; set; }
        public PolyLine(List<PointF> points, Color borderColor) : base(points.First(), borderColor)
        {
            Points = points;
        }

        public override void Draw(Graphics graphics, Size canvasSize, int borderWidth)
        {
            for(var i = 0; i < Points.Count - 1; i++)
            {
                var segment = new LineSegment(Points[i], Points[i + 1], BorderColor);
                segment.Draw(graphics, canvasSize, borderWidth);
            }
        }

        public override void Move()
        {
            throw new NotImplementedException();
        }
    }
}
