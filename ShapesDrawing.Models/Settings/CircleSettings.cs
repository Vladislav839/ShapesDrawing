using System;
using System.Collections.Generic;
using System.Text;

namespace ShapesDrawing.BL.Settings
{
    class CircleSettings : FigureSettings
    {
        public CircleSettings() { }
        public override int? PointsCount { get; set; } = 2;

        public override string DrawingInfo => "Provide 2 points (center, and point on circle)";
    }
}
