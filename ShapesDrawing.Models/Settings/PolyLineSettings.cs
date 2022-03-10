using System;
using System.Collections.Generic;
using System.Text;

namespace ShapesDrawing.BL.Settings
{
    class PolyLineSettings : FigureSettings
    {
        public PolyLineSettings() { }
        public override int? PointsCount { get; set; } = null;

        public override string DrawingInfo => "Provide points to draw poly line";

        public override bool NeedsSidesCount => true;

        public override bool UsesSidesCountAsNumberOfPointsToDraw => true;
    }
}
