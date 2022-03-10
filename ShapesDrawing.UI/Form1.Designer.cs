
namespace ShapesDrawing.UI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.shapeType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.drawingInfo = new System.Windows.Forms.TextBox();
            this.bgColorPicker = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.borderColorPicker = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.borderWidth = new System.Windows.Forms.NumericUpDown();
            this.sidesCountLabel = new System.Windows.Forms.Label();
            this.sidesCount = new System.Windows.Forms.NumericUpDown();
            this.panel3 = new System.Windows.Forms.Panel();
            this.canvas = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.borderWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sidesCount)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 210F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1004, 566);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 199F));
            this.tableLayoutPanel2.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.drawingInfo, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.bgColorPicker, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.borderColorPicker, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.borderWidth, 0, 7);
            this.tableLayoutPanel2.Controls.Add(this.sidesCountLabel, 0, 8);
            this.tableLayoutPanel2.Controls.Add(this.sidesCount, 0, 9);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(807, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 11;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 159F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 84F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(194, 560);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.shapeType);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(193, 63);
            this.panel2.TabIndex = 0;
            // 
            // shapeType
            // 
            this.shapeType.FormattingEnabled = true;
            this.shapeType.Location = new System.Drawing.Point(3, 26);
            this.shapeType.Name = "shapeType";
            this.shapeType.Size = new System.Drawing.Size(179, 28);
            this.shapeType.TabIndex = 1;
            this.shapeType.SelectedIndexChanged += new System.EventHandler(this.shapeType_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Shape";
            // 
            // drawingInfo
            // 
            this.drawingInfo.Location = new System.Drawing.Point(3, 72);
            this.drawingInfo.Multiline = true;
            this.drawingInfo.Name = "drawingInfo";
            this.drawingInfo.Size = new System.Drawing.Size(182, 152);
            this.drawingInfo.TabIndex = 1;
            // 
            // bgColorPicker
            // 
            this.bgColorPicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bgColorPicker.Location = new System.Drawing.Point(3, 259);
            this.bgColorPicker.Name = "bgColorPicker";
            this.bgColorPicker.Size = new System.Drawing.Size(53, 29);
            this.bgColorPicker.TabIndex = 3;
            this.bgColorPicker.UseVisualStyleBackColor = true;
            this.bgColorPicker.Click += new System.EventHandler(this.bgColorPicker_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Background color";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 301);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Border color";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // borderColorPicker
            // 
            this.borderColorPicker.Location = new System.Drawing.Point(3, 324);
            this.borderColorPicker.Name = "borderColorPicker";
            this.borderColorPicker.Size = new System.Drawing.Size(53, 29);
            this.borderColorPicker.TabIndex = 5;
            this.borderColorPicker.UseVisualStyleBackColor = true;
            this.borderColorPicker.Click += new System.EventHandler(this.borderColorPicker_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 366);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Border width";
            // 
            // borderWidth
            // 
            this.borderWidth.Location = new System.Drawing.Point(3, 389);
            this.borderWidth.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.borderWidth.Name = "borderWidth";
            this.borderWidth.Size = new System.Drawing.Size(150, 27);
            this.borderWidth.TabIndex = 7;
            // 
            // sidesCountLabel
            // 
            this.sidesCountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.sidesCountLabel.AutoSize = true;
            this.sidesCountLabel.Location = new System.Drawing.Point(3, 426);
            this.sidesCountLabel.Name = "sidesCountLabel";
            this.sidesCountLabel.Size = new System.Drawing.Size(132, 20);
            this.sidesCountLabel.TabIndex = 8;
            this.sidesCountLabel.Text = "Sides/points count";
            this.sidesCountLabel.Visible = false;
            // 
            // sidesCount
            // 
            this.sidesCount.Location = new System.Drawing.Point(3, 449);
            this.sidesCount.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.sidesCount.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.sidesCount.Name = "sidesCount";
            this.sidesCount.Size = new System.Drawing.Size(150, 27);
            this.sidesCount.TabIndex = 9;
            this.sidesCount.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.sidesCount.Visible = false;
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.Controls.Add(this.canvas);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(771, 557);
            this.panel3.TabIndex = 2;
            // 
            // canvas
            // 
            this.canvas.BackColor = System.Drawing.SystemColors.Window;
            this.canvas.Location = new System.Drawing.Point(4, 6);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(767, 548);
            this.canvas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.canvas.TabIndex = 0;
            this.canvas.TabStop = false;
            this.canvas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(196, 79);
            this.panel1.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(25, 26);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(154, 28);
            this.comboBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Figure";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 566);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Drawind shapes";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.borderWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sidesCount)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox shapeType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox drawingInfo;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox canvas;
        private System.Windows.Forms.Button bgColorPicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button borderColorPicker;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown borderWidth;
        private System.Windows.Forms.Label sidesCountLabel;
        private System.Windows.Forms.NumericUpDown sidesCount;
    }
}

