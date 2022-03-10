using System;
using System.Collections.Generic;
using System.Text;

namespace ShapesDrawing.BL.Settings
{
    class PolygonSettings : FigureSettings
    {
        public PolygonSettings() { }
        public override int? PointsCount { get; set; } = null;

        public override string DrawingInfo => "Provide all vertexes of polygon";

        public override bool NeedsSidesCount => true;

        public override bool UsesSidesCountAsNumberOfPointsToDraw => true;
    }
}
