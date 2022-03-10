using System;
using System.Collections.Generic;
using System.Text;

namespace ShapesDrawing.BL.Settings
{
    class EllipseSettings : FigureSettings
    {
        public EllipseSettings() { }
        public override int? PointsCount { get; set; } = 2;

        public override string DrawingInfo => "Provide coordiantes of top left and bottom right corners of circumscribed rectangle";
    }
}
