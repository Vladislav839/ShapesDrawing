using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;

using ShapesDrawing.BL.Attributes;

namespace ShapesDrawing.BL
{
    public static class Utils
    {
        public static double GetDistance(PointF p1, PointF p2)
        {
            return Math.Round(Math.Sqrt(Math.Pow((p2.X - p1.X), 2) + Math.Pow((p2.Y - p1.Y), 2)), 1);
        }

        public static PointF TransformPoint(PointF point, Size canvasSize)
        {
            return new PointF(point.X, canvasSize.Height - point.Y);
        }

        public static float[] GetLine(PointF p1, PointF p2)
        {
            return new float[] { p1.Y - p2.Y, p2.X - p1.X, p1.X * p2.Y - p2.X * p1.Y };
        }

        public static float GetYFromX(float[] line, float x)
        {
            return -(line[0] * x + line[2]) / line[1];
        }

        public static List<string> GetActiveTypeNames()
        {
            var result = new List<string>();

            foreach (Type type in Assembly.GetExecutingAssembly().GetTypes())
            {
                if (type.GetCustomAttributes(typeof(ActiveFigureAttribute), true).Length > 0)
                {
                    if (type.GetCustomAttributes(typeof(UINameAttribute), true).Length > 0)
                    {
                        if (type.GetCustomAttributes(typeof(UINameAttribute), true).First() is UINameAttribute attribute)
                        {
                            result.Add(attribute.Name);
                        }
                    }
                    else
                    {
                        result.Add(type.Name);
                    }
                }
            }

            return result;
        }
    }
}
