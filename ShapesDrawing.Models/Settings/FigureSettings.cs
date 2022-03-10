using System;
using System.Collections.Generic;
using System.Text;

namespace ShapesDrawing.BL.Settings
{
    public abstract class FigureSettings
    {
        public abstract int? PointsCount { get; set; }
        public abstract string DrawingInfo { get; }
        public virtual bool NeedsSidesCount { get { return false; } }

        public virtual bool UsesSidesCountAsNumberOfPointsToDraw { get { return false; } }
    }
}
