using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;

using ShapesDrawing.BL.Attributes;
using ShapesDrawing.BL.Settings;

namespace ShapesDrawing.BL
{
    public static class FigureFactory
    {
        public static FigureBase CreateFigure(string typeName, List<PointF> points, Color? backgroundColor, Color borderColor, int sidesCount, Size canvasSize)
        {
            switch(typeName)
            {
                case "Rectangle":
                    return new Rectangle(new PointF((points[0].X + points[1].X) / 2, (points[0].Y + points[1].Y) / 2), 
                        points, (Color)backgroundColor, borderColor);

                case "Ellipse":
                    return new Ellipse(new PointF((points[0].X + points[1].X) / 2, (points[0].Y + points[1].Y) / 2),
                        points, (Color)backgroundColor, borderColor);

                case "RegularShape":
                    return new RegularShape(points.First(), sidesCount, points.Skip(1).ToList(), (Color)backgroundColor, borderColor);

                case "Circle":
                    return new Circle(points.First(), points.Last(), (Color)backgroundColor, borderColor);

                case "Polygon":
                    return new Polygon(points.First(), sidesCount, points, (Color)backgroundColor, borderColor);

                case "LineSegment":
                    return new LineSegment(points.First(), points.Last(), borderColor);

                case "Line":
                    return new Line(points.First(), points.Last(), borderColor, canvasSize);

                case "Ray":
                    return new Ray(points.First(), points.Last(), borderColor, canvasSize);

                case "PolyLine":
                    return new PolyLine(points, borderColor);

                default:
                    return null;
            }
        }

        public static FigureSettings GetFigureSettings(string typeName)
        {
            foreach(Type type in Assembly.GetExecutingAssembly().GetTypes())
            {
                if(type.GetCustomAttributes(typeof(SettingsClassAttribute), true).Length > 0
                    && type.GetCustomAttributes(typeof(ActiveFigureAttribute), true).Length > 0
                    && type.Name == typeName)
                {
                    if (type.GetCustomAttributes(typeof(SettingsClassAttribute), true).First() is SettingsClassAttribute attribute)
                    {
                        return (FigureSettings)Activator.CreateInstance(attribute.Type);
                    } 
                }
            }

            return new DefaultSettings();
        }
    }
}
