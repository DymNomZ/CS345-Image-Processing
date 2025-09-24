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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            chartArea1.AxisX.Interval = 51D;
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisX.Title = "Intensity";
            chartArea1.AxisY.Title = "Pixel Count";
            chartArea1.Name = "Blue";
            this.chart4.ChartAreas.Add(chartArea1);
            this.chart4.Location = new System.Drawing.Point(1055, 495);
            this.chart4.Name = "chart4";
            series1.ChartArea = "Blue";
            series1.Color = System.Drawing.Color.Blue;
            series1.CustomProperties = "PointWidth=1";
            series1.Name = "Blue";
            this.chart4.Series.Add(series1);
            this.chart4.Size = new System.Drawing.Size(516, 136);
            this.chart4.TabIndex = 13;
            this.chart4.Text = "chart4";
            // 
            // chart3
            // 
            this.chart3.BackColor = System.Drawing.Color.OliveDrab;
            chartArea2.AxisX.Interval = 51D;
            chartArea2.AxisX.MajorGrid.Enabled = false;
            chartArea2.AxisX.Title = "Intensity";
            chartArea2.AxisY.Title = "Pixel Count";
            chartArea2.Name = "Green";
            this.chart3.ChartAreas.Add(chartArea2);
            this.chart3.Location = new System.Drawing.Point(1055, 353);
            this.chart3.Name = "chart3";
            series2.ChartArea = "Green";
            series2.Color = System.Drawing.Color.Lime;
            series2.CustomProperties = "PointWidth=1";
            series2.Name = "Green";
            this.chart3.Series.Add(series2);
            this.chart3.Size = new System.Drawing.Size(516, 136);
            this.chart3.TabIndex = 12;
            this.chart3.Text = "chart3";
            // 
            // chart2
            // 
            this.chart2.BackColor = System.Drawing.Color.OliveDrab;
            chartArea3.AxisX.Interval = 51D;
            chartArea3.AxisX.MajorGrid.Enabled = false;
            chartArea3.AxisX.Title = "Intensity";
            chartArea3.AxisY.Title = "Pixel Count";
            chartArea3.Name = "Red";
            this.chart2.ChartAreas.Add(chartArea3);
            this.chart2.Location = new System.Drawing.Point(1055, 211);
            this.chart2.Name = "chart2";
            series3.ChartArea = "Red";
            series3.Color = System.Drawing.Color.Red;
            series3.CustomProperties = "PointWidth=1";
            series3.Name = "Red";
            this.chart2.Series.Add(series3);
            this.chart2.Size = new System.Drawing.Size(516, 136);
            this.chart2.TabIndex = 11;
            this.chart2.Text = "chart2";
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.OliveDrab;
            chartArea4.AxisX.Interval = 51D;
            chartArea4.AxisX.MajorGrid.Enabled = false;
            chartArea4.AxisX.Title = "Intensity";
            chartArea4.AxisY.Title = "Pixel Count";
            chartArea4.Name = "Gray";
            this.chart1.ChartAreas.Add(chartArea4);
            this.chart1.Location = new System.Drawing.Point(1055, 69);
            this.chart1.Name = "chart1";
            series4.ChartArea = "Gray";
            series4.Color = System.Drawing.Color.Gray;
            series4.CustomProperties = "PointWidth=1";
            series4.Name = "Gray";
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(516, 136);
            this.chart1.TabIndex = 10;
            this.chart1.Text = "chart1";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(549, 69);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(500, 400);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(25, 69);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 400);
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
            this.Size = new System.Drawing.Size(1600, 700);
            this.Click += new System.EventHandler(this.DummyFunction);
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
