using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

using ShapesDrawing.BL.Attributes;
using ShapesDrawing.BL.Settings;

namespace ShapesDrawing.BL
{
    [ActiveFigure]
    [SettingsClass(typeof(RaySettings))]
    class Ray : LineSegment
    {
        public Ray(PointF point1, PointF point2, Color borderColor, Size canvasSize) : base(point1, point2, borderColor)
        {
            float[] line = Utils.GetLine(point1, point2);

            if(point1.X < point2.X)
            {
                Point1 = point1;
                Point2 = new PointF(canvasSize.Width, Utils.GetYFromX(line, canvasSize.Width));
            }
            else
            {
                Point1 = new PointF(0.001F, Utils.GetYFromX(line, 0.001F)); ;
                Point2 = point2;
            }
            
        }
    }
}
