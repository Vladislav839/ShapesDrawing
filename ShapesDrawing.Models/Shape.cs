using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ShapesDrawing.BL
{
    public abstract class Shape : FigureBase
    {
        public Color BackgroundColor { get; set; }

        public Shape(Color background, Color borderColor, PointF center) : base(center, borderColor)
        {
            this.BackgroundColor = background;
        }
    }
}
