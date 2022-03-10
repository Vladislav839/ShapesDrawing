using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ShapesDrawing.BL;
using ShapesDrawing.BL.Settings;

namespace ShapesDrawing.UI
{
    public partial class Form1 : Form
    {
        private readonly int pointRadius = 5;

        private readonly Color pointColor = Color.Orange;

        private Bitmap DrawArea;

        private FigureSettings currentFigureSettings;

        private Dictionary<string, List<PointF>> pointsObserver = new Dictionary<string, List<PointF>>();
        public Form1()
        {
            InitializeComponent();

            InitializeShapeType();

            canvas.BackColor = Color.White;

            borderWidth.Value = 5;

            foreach (var item in shapeType.Items)
            {
                pointsObserver.Add(shapeType.GetItemText(item), new List<PointF>());
            }

            DrawArea = new Bitmap(canvas.Size.Width, canvas.Size.Height);
            canvas.Image = DrawArea;

            shapeType.SelectedIndex = 1;
        }

        private void InitializeShapeType()
        {
            foreach(var typeName in Utils.GetActiveTypeNames())
            {
                shapeType.Items.Add(typeName);
            }
        }

        private void canvas_MouseClick(object sender, MouseEventArgs e)
        {
            Graphics graphics;
            graphics = Graphics.FromImage(DrawArea);

            var typeName = shapeType.GetItemText(shapeType.SelectedItem);

            if(currentFigureSettings.PointsCount == null)
            {
                if(pointsObserver[typeName].Count == 0)
                {
                    sidesCount.Enabled = false;
                    currentFigureSettings.PointsCount = (int)sidesCount.Value;
                }
            }

            pointsObserver[typeName].Add(new PointF(e.X, e.Y));

            graphics.FillEllipse(new SolidBrush(pointColor), e.X - pointRadius, e.Y + pointRadius, 2 * pointRadius, 2 * pointRadius);
            canvas.Image = DrawArea;

            if (currentFigureSettings.PointsCount != null && currentFigureSettings.PointsCount == pointsObserver[typeName].Count)
            {
                Color bgColor = bgColorPicker.BackColor;
                Color borderColor = borderColorPicker.BackColor;
                int borderWidth = (int)this.borderWidth.Value;

                foreach(var point in pointsObserver[typeName])
                {
                    graphics.FillEllipse(new SolidBrush(canvas.BackColor), point.X - pointRadius, point.Y + pointRadius, 2 * pointRadius, 2 * pointRadius);
                }

                FigureBase figureToDraw = FigureFactory.CreateFigure(typeName, pointsObserver[typeName], bgColor, borderColor, (int)(sidesCount.Visible ? sidesCount.Value : 0), canvas.Size);
                figureToDraw.Draw(graphics, canvas.Size, borderWidth);

                pointsObserver[typeName].Clear();

                sidesCount.Enabled = true;

                if(currentFigureSettings.UsesSidesCountAsNumberOfPointsToDraw)
                {
                    currentFigureSettings.PointsCount = null;
                }

                canvas.Image = DrawArea;
            }

            graphics.Dispose();
        }

        private void shapeType_SelectedIndexChanged(object sender, EventArgs e)
        {
            Graphics graphics;
            graphics = Graphics.FromImage(DrawArea);

            foreach (var key in pointsObserver.Keys)
            {
                pointsObserver[key].Clear();

                foreach (var point in pointsObserver[key])
                {
                    graphics.FillEllipse(new SolidBrush(canvas.BackColor), point.X - pointRadius, point.Y + pointRadius, 2 * pointRadius, 2 * pointRadius);
                }
            }

            canvas.Image = DrawArea;
            graphics.Dispose();


            currentFigureSettings = FigureFactory.GetFigureSettings(shapeType.GetItemText(shapeType.SelectedItem));

            if(currentFigureSettings.NeedsSidesCount)
            {
                sidesCountLabel.Visible = true;
                sidesCount.Visible = true;
            }

            sidesCount.Enabled = true;

            drawingInfo.Text = currentFigureSettings.DrawingInfo;
        }

        private void bgColorPicker_Click(object sender, EventArgs e)
        {
            if(colorDialog.ShowDialog() != DialogResult.Cancel)
            {
                bgColorPicker.BackColor = colorDialog.Color;
            }
        }

        private void borderColorPicker_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() != DialogResult.Cancel)
            {
                borderColorPicker.BackColor = colorDialog.Color;
            }
        }
    }
}
