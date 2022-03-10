using System;
using System.Collections.Generic;
using System.Text;

namespace ShapesDrawing.BL.Attributes
{
    class UINameAttribute : Attribute
    {
        public string Name { get; }

        public UINameAttribute(string name) => Name = name;
    }
}
