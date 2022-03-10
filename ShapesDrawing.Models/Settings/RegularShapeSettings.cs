using System;
using System.Collections.Generic;
using System.Text;

namespace ShapesDrawing.BL.Settings
{
    class RegularShapeSettings : FigureSettings
    {
        public RegularShapeSettings() { }
        public override int? PointsCount { get; set; } = 2;

        public override string DrawingInfo => "Provide center of circumscribed circle and one vertex";

        public override bool NeedsSidesCount => true;
    }
}
