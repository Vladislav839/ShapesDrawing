using System;
using System.Collections.Generic;
using System.Text;

namespace ShapesDrawing.BL.Settings
{
    class RaySettings : FigureSettings
    {
        public RaySettings() { }
        public override int? PointsCount { get; set; } = 2;

        public override string DrawingInfo => "Provide start point and point on a ray";
    }
}
