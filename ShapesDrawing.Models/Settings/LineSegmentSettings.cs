using System;
using System.Collections.Generic;
using System.Text;

namespace ShapesDrawing.BL.Settings
{
    class LineSegmentSettings : FigureSettings
    {
        public LineSegmentSettings() { }
        public override int? PointsCount { get; set; } = 2;

        public override string DrawingInfo => "Provide 2 points (start and end of segment)";
    }
}
