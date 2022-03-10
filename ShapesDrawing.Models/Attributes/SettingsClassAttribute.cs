using System;
using System.Collections.Generic;
using System.Text;

using ShapesDrawing.BL.Settings;

namespace ShapesDrawing.BL.Attributes
{
    class SettingsClassAttribute : Attribute
    {
        public Type Type { get; }
        public SettingsClassAttribute(Type type) => Type = type;

        public SettingsClassAttribute() => Type = typeof(DefaultSettings);
    }
}
