namespace ImageProcessor
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manipulationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.basicCopyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grayScaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.invertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.histogramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sepiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subtractionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.convolutionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smoothToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gaussianBlurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.embossLaplacianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.meanRemovalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.embossToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.laplascianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horizontalVerticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allDirectionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lossyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.manipulationsToolStripMenuItem,
            this.subtractionToolStripMenuItem,
            this.convolutionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1682, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(171, 26);
            this.testToolStripMenuItem.Text = "Load Image";
            this.testToolStripMenuItem.Click += new System.EventHandler(this.LoadImage);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(171, 26);
            this.saveToolStripMenuItem.Text = "Save Image";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveImage);
            // 
            // manipulationsToolStripMenuItem
            // 
            this.manipulationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.basicCopyToolStripMenuItem,
            this.grayScaleToolStripMenuItem,
            this.invertToolStripMenuItem,
            this.histogramToolStripMenuItem,
            this.sepiaToolStripMenuItem});
            this.manipulationsToolStripMenuItem.Name = "manipulationsToolStripMenuItem";
            this.manipulationsToolStripMenuItem.Size = new System.Drawing.Size(149, 24);
            this.manipulationsToolStripMenuItem.Text = "Basic Manipulation";
            this.manipulationsToolStripMenuItem.Click += new System.EventHandler(this.ChangeToBasicManip);
            // 
            // basicCopyToolStripMenuItem
            // 
            this.basicCopyToolStripMenuItem.Name = "basicCopyToolStripMenuItem";
            this.basicCopyToolStripMenuItem.Size = new System.Drawing.Size(164, 26);
            this.basicCopyToolStripMenuItem.Text = "Basic Copy";
            this.basicCopyToolStripMenuItem.Click += new System.EventHandler(this.BasicCopy);
            // 
            // grayScaleToolStripMenuItem
            // 
            this.grayScaleToolStripMenuItem.Name = "grayScaleToolStripMenuItem";
            this.grayScaleToolStripMenuItem.Size = new System.Drawing.Size(164, 26);
            this.grayScaleToolStripMenuItem.Text = "GrayScale";
            this.grayScaleToolStripMenuItem.Click += new System.EventHandler(this.GrayScale);
            // 
            // invertToolStripMenuItem
            // 
            this.invertToolStripMenuItem.Name = "invertToolStripMenuItem";
            this.invertToolStripMenuItem.Size = new System.Drawing.Size(164, 26);
            this.invertToolStripMenuItem.Text = "Invert";
            this.invertToolStripMenuItem.Click += new System.EventHandler(this.Invert);
            // 
            // histogramToolStripMenuItem
            // 
            this.histogramToolStripMenuItem.Name = "histogramToolStripMenuItem";
            this.histogramToolStripMenuItem.Size = new System.Drawing.Size(164, 26);
            this.histogramToolStripMenuItem.Text = "Histogram";
            this.histogramToolStripMenuItem.Click += new System.EventHandler(this.Histogram);
            // 
            // sepiaToolStripMenuItem
            // 
            this.sepiaToolStripMenuItem.Name = "sepiaToolStripMenuItem";
            this.sepiaToolStripMenuItem.Size = new System.Drawing.Size(164, 26);
            this.sepiaToolStripMenuItem.Text = "Sepia";
            this.sepiaToolStripMenuItem.Click += new System.EventHandler(this.Sepia);
            // 
            // subtractionToolStripMenuItem
            // 
            this.subtractionToolStripMenuItem.Name = "subtractionToolStripMenuItem";
            this.subtractionToolStripMenuItem.Size = new System.Drawing.Size(99, 24);
            this.subtractionToolStripMenuItem.Text = "Subtraction";
            this.subtractionToolStripMenuItem.Click += new System.EventHandler(this.ChangeToSubtraction);
            // 
            // convolutionToolStripMenuItem
            // 
            this.convolutionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smoothToolStripMenuItem,
            this.gaussianBlurToolStripMenuItem,
            this.embossLaplacianToolStripMenuItem,
            this.meanRemovalToolStripMenuItem,
            this.embossToolStripMenuItem});
            this.convolutionToolStripMenuItem.Name = "convolutionToolStripMenuItem";
            this.convolutionToolStripMenuItem.Size = new System.Drawing.Size(103, 24);
            this.convolutionToolStripMenuItem.Text = "Convolution";
            this.convolutionToolStripMenuItem.Click += new System.EventHandler(this.ChangeToConvolution);
            // 
            // smoothToolStripMenuItem
            // 
            this.smoothToolStripMenuItem.Name = "smoothToolStripMenuItem";
            this.smoothToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.smoothToolStripMenuItem.Text = "Smooth";
            this.smoothToolStripMenuItem.Click += new System.EventHandler(this.Smooth);
            // 
            // gaussianBlurToolStripMenuItem
            // 
            this.gaussianBlurToolStripMenuItem.Name = "gaussianBlurToolStripMenuItem";
            this.gaussianBlurToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.gaussianBlurToolStripMenuItem.Text = "Gaussian Blur";
            this.gaussianBlurToolStripMenuItem.Click += new System.EventHandler(this.GaussianBlur);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1650, 700);
            this.panel1.TabIndex = 1;
            // 
            // embossLaplacianToolStripMenuItem
            // 
            this.embossLaplacianToolStripMenuItem.Name = "embossLaplacianToolStripMenuItem";
            this.embossLaplacianToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.embossLaplacianToolStripMenuItem.Text = "Sharpen";
            this.embossLaplacianToolStripMenuItem.Click += new System.EventHandler(this.Sharpen);
            // 
            // meanRemovalToolStripMenuItem
            // 
            this.meanRemovalToolStripMenuItem.Name = "meanRemovalToolStripMenuItem";
            this.meanRemovalToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.meanRemovalToolStripMenuItem.Text = "Mean Removal";
            this.meanRemovalToolStripMenuItem.Click += new System.EventHandler(this.MeanRemoval);
            // 
            // embossToolStripMenuItem
            // 
            this.embossToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.laplascianToolStripMenuItem,
            this.horizontalVerticalToolStripMenuItem,
            this.allDirectionsToolStripMenuItem,
            this.lossyToolStripMenuItem,
            this.horizontalToolStripMenuItem,
            this.verticalToolStripMenuItem});
            this.embossToolStripMenuItem.Name = "embossToolStripMenuItem";
            this.embossToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.embossToolStripMenuItem.Text = "Emboss";
            // 
            // laplascianToolStripMenuItem
            // 
            this.laplascianToolStripMenuItem.Name = "laplascianToolStripMenuItem";
            this.laplascianToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.laplascianToolStripMenuItem.Text = "Laplascian";
            this.laplascianToolStripMenuItem.Click += new System.EventHandler(this.EmbossLaplascian);
            // 
            // horizontalVerticalToolStripMenuItem
            // 
            this.horizontalVerticalToolStripMenuItem.Name = "horizontalVerticalToolStripMenuItem";
            this.horizontalVerticalToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.horizontalVerticalToolStripMenuItem.Text = "Horizontal/Vertical";
            this.horizontalVerticalToolStripMenuItem.Click += new System.EventHandler(this.EmbossHorizVert);
            // 
            // allDirectionsToolStripMenuItem
            // 
            this.allDirectionsToolStripMenuItem.Name = "allDirectionsToolStripMenuItem";
            this.allDirectionsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.allDirectionsToolStripMenuItem.Text = "All Directions";
            this.allDirectionsToolStripMenuItem.Click += new System.EventHandler(this.EmbossAllDirections);
            // 
            // lossyToolStripMenuItem
            // 
            this.lossyToolStripMenuItem.Name = "lossyToolStripMenuItem";
            this.lossyToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.lossyToolStripMenuItem.Text = "Lossy";
            this.lossyToolStripMenuItem.Click += new System.EventHandler(this.EmbossLossy);
            // 
            // horizontalToolStripMenuItem
            // 
            this.horizontalToolStripMenuItem.Name = "horizontalToolStripMenuItem";
            this.horizontalToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.horizontalToolStripMenuItem.Text = "Horizontal";
            this.horizontalToolStripMenuItem.Click += new System.EventHandler(this.EmbossHorizontal);
            // 
            // verticalToolStripMenuItem
            // 
            this.verticalToolStripMenuItem.Name = "verticalToolStripMenuItem";
            this.verticalToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.verticalToolStripMenuItem.Text = "Vertical";
            this.verticalToolStripMenuItem.Click += new System.EventHandler(this.EmbossVertical);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1682, 753);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Borgonia Image Processor";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manipulationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem basicCopyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grayScaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem invertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem histogramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sepiaToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ToolStripMenuItem subtractionToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem convolutionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem smoothToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gaussianBlurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem embossLaplacianToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem meanRemovalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem embossToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem laplascianToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem horizontalVerticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allDirectionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lossyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem horizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verticalToolStripMenuItem;
    }
}

