using System;
using System.Collections.Generic;
using System.Text;

namespace ShapesDrawing.BL.Settings
{
    class LineSettings : FigureSettings
    {
        public LineSettings() { }
        public override int? PointsCount { get; set; } = 2;

        public override string DrawingInfo => "Provide 2 points on the line";
    }
}
