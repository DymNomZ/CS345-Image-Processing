namespace ImageProcessor
{
    partial class UserControl1
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart4 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart4
            // 
            this.chart4.BackColor = System.Drawing.Color.OliveDrab;
            chartArea5.AxisX.Interval = 51D;
            chartArea5.AxisX.MajorGrid.Enabled = false;
            chartArea5.AxisX.Title = "Intensity";
            chartArea5.AxisY.Title = "Pixel Count";
            chartArea5.Name = "Blue";
            this.chart4.ChartAreas.Add(chartArea5);
            this.chart4.Location = new System.Drawing.Point(859, 495);
            this.chart4.Name = "chart4";
            series5.ChartArea = "Blue";
            series5.Color = System.Drawing.Color.Blue;
            series5.CustomProperties = "PointWidth=1";
            series5.Name = "Blue";
            this.chart4.Series.Add(series5);
            this.chart4.Size = new System.Drawing.Size(516, 136);
            this.chart4.TabIndex = 13;
            this.chart4.Text = "chart4";
            // 
            // chart3
            // 
            this.chart3.BackColor = System.Drawing.Color.OliveDrab;
            chartArea6.AxisX.Interval = 51D;
            chartArea6.AxisX.MajorGrid.Enabled = false;
            chartArea6.AxisX.Title = "Intensity";
            chartArea6.AxisY.Title = "Pixel Count";
            chartArea6.Name = "Green";
            this.chart3.ChartAreas.Add(chartArea6);
            this.chart3.Location = new System.Drawing.Point(859, 353);
            this.chart3.Name = "chart3";
            series6.ChartArea = "Green";
            series6.Color = System.Drawing.Color.Lime;
            series6.CustomProperties = "PointWidth=1";
            series6.Name = "Green";
            this.chart3.Series.Add(series6);
            this.chart3.Size = new System.Drawing.Size(516, 136);
            this.chart3.TabIndex = 12;
            this.chart3.Text = "chart3";
            // 
            // chart2
            // 
            this.chart2.BackColor = System.Drawing.Color.OliveDrab;
            chartArea7.AxisX.Interval = 51D;
            chartArea7.AxisX.MajorGrid.Enabled = false;
            chartArea7.AxisX.Title = "Intensity";
            chartArea7.AxisY.Title = "Pixel Count";
            chartArea7.Name = "Red";
            this.chart2.ChartAreas.Add(chartArea7);
            this.chart2.Location = new System.Drawing.Point(859, 211);
            this.chart2.Name = "chart2";
            series7.ChartArea = "Red";
            series7.Color = System.Drawing.Color.Red;
            series7.CustomProperties = "PointWidth=1";
            series7.Name = "Red";
            this.chart2.Series.Add(series7);
            this.chart2.Size = new System.Drawing.Size(516, 136);
            this.chart2.TabIndex = 11;
            this.chart2.Text = "chart2";
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.OliveDrab;
            chartArea8.AxisX.Interval = 51D;
            chartArea8.AxisX.MajorGrid.Enabled = false;
            chartArea8.AxisX.Title = "Intensity";
            chartArea8.AxisY.Title = "Pixel Count";
            chartArea8.Name = "Gray";
            this.chart1.ChartAreas.Add(chartArea8);
            this.chart1.Location = new System.Drawing.Point(859, 69);
            this.chart1.Name = "chart1";
            series8.ChartArea = "Gray";
            series8.Color = System.Drawing.Color.Gray;
            series8.CustomProperties = "PointWidth=1";
            series8.Name = "Gray";
            this.chart1.Series.Add(series8);
            this.chart1.Size = new System.Drawing.Size(516, 136);
            this.chart1.TabIndex = 10;
            this.chart1.Text = "chart1";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(442, 69);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(400, 400);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(25, 69);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 400);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chart4);
            this.Controls.Add(this.chart3);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "UserControl1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(1400, 700);
            ((System.ComponentModel.ISupportInitialize)(this.chart4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart chart4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
