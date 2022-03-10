using System;
using System.Collections.Generic;
using System.Text;

namespace ShapesDrawing.BL.Settings
{
    class DefaultSettings : FigureSettings
    {
        public DefaultSettings() { }
        public override int? PointsCount { get; set; } = null;

        public override string DrawingInfo => string.Empty;
    }
}
