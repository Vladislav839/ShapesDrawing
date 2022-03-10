using System.Drawing;

namespace ShapesDrawing.BL
{
    public abstract class FigureBase
    {

        public PointF Center { get; set; }

        public PointF Location 
        { 
            get
            {
                return this.Center;
            }
        }

        public Color BorderColor { get; set; }

        public FigureBase(PointF center, Color borderColor)
        {
            this.Center = center;
            this.BorderColor = borderColor;
        }

        protected FigureBase()
        {
        }

        public abstract void Draw(Graphics graphics, Size canvasSize, int borderWidth);
        public abstract void Move();
    }
}
