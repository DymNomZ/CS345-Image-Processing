using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageProcessor
{
    public partial class Form1 : Form
    {

        Bitmap LoadedImage, ProcessedImage;
        public Form1()
        {
            InitializeComponent();
        }

        private void LoadImage(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    LoadedImage = (Bitmap)Image.FromFile(ofd.FileName);

                    if (LoadedImage != null)
                    {
                        pictureBox1.Image = LoadedImage;
                    }
                }
                catch (Exception ex)
                {

                }
            }

        }

        private void SaveImage(object sender, EventArgs e)
        {

            if (ProcessedImage != null)
            {
                SaveFileDialog sfd = new SaveFileDialog();

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        ProcessedImage.Save(sfd.FileName + ".png");
                    }
                    catch (Exception ex)
                    {

                    }
                }
            }

        }

        private void BasicCopy(object sender, EventArgs e)
        {
            if (LoadedImage != null)
            {
                ProcessedImage = new Bitmap(LoadedImage.Width, LoadedImage.Height);
                for (int x = 0; x < LoadedImage.Width; x++)
                {
                    for (int y = 0; y < LoadedImage.Height; y++)
                    {
                        Color pixelColor = LoadedImage.GetPixel(x, y);
                        ProcessedImage.SetPixel(x, y, pixelColor);
                    }
                }
                pictureBox2.Image = ProcessedImage;
            }
        }

        private void GrayScale(object sender, EventArgs e)
        {
            if (LoadedImage != null)
            {
                ProcessedImage = new Bitmap(LoadedImage.Width, LoadedImage.Height);
                for (int x = 0; x < LoadedImage.Width; x++)
                {
                    for (int y = 0; y < LoadedImage.Height; y++)
                    {
                        Color pixelColor = LoadedImage.GetPixel(x, y);
                        int gray = (int)((pixelColor.R + pixelColor.G + pixelColor.B) / 3);
                        ProcessedImage.SetPixel(x, y, Color.FromArgb(gray, gray, gray));
                    }
                }
                pictureBox2.Image = ProcessedImage;
            }
        }
        private void Invert(object sender, EventArgs e)
        {
            if (LoadedImage != null)
            {
                ProcessedImage = new Bitmap(LoadedImage.Width, LoadedImage.Height);
                for (int x = 0; x < LoadedImage.Width; x++)
                {
                    for (int y = 0; y < LoadedImage.Height; y++)
                    {
                        Color pixelColor = LoadedImage.GetPixel(x, y);

                        int red = 255 - pixelColor.R;
                        int green = 255 - pixelColor.G;
                        int blue = 255 - pixelColor.B;

                        ProcessedImage.SetPixel(x, y, Color.FromArgb(red, green, blue));
                    }
                }
                pictureBox2.Image = ProcessedImage;
            }
        }

        private void Histogram(object sender, EventArgs e)
        {
            if (LoadedImage != null)
            {
                int[] histogram = new int[256];
                for (int x = 0; x < LoadedImage.Width; x++)
                {
                    for (int y = 0; y < LoadedImage.Height; y++)
                    {
                        Color pixelColor = LoadedImage.GetPixel(x, y);
                        int gray = (int)((pixelColor.R + pixelColor.G + pixelColor.B) / 3);
                        histogram[gray]++;
                    }
                }
                Form histogramForm = new Form();
                histogramForm.Text = "Histogram";
                histogramForm.Size = new Size(512, 400);
                PictureBox histogramBox = new PictureBox();
                histogramBox.Dock = DockStyle.Fill;
                histogramForm.Controls.Add(histogramBox);
                Bitmap histogramImage = new Bitmap(512, 400);
                using (Graphics g = Graphics.FromImage(histogramImage))
                {
                    g.Clear(Color.White);
                    int max = histogram.Max();
                    for (int i = 0; i < histogram.Length; i++)
                    {
                        int height = (int)((histogram[i] / (float)max) * 300);
                        g.DrawLine(Pens.Black, i * 2, 400, i * 2, 400 - height);
                    }
                }
                histogramBox.Image = histogramImage;
                histogramForm.ShowDialog();
            }
        }

        private void Sepia(object sender, EventArgs e)
        {
            if (LoadedImage != null)
            {
                ProcessedImage = new Bitmap(LoadedImage.Width, LoadedImage.Height);
                for (int x = 0; x < LoadedImage.Width; x++)
                {
                    for (int y = 0; y < LoadedImage.Height; y++)
                    {
                        Color pixelColor = LoadedImage.GetPixel(x, y);

                        int r = pixelColor.R;
                        int g = pixelColor.G;
                        int b = pixelColor.B;

                        double newRed = (r * 0.393) + (g * 0.769) + (b * 0.189);
                        double newGreen = (r * 0.349) + (g * 0.686) + (b * 0.168);
                        double newBlue = (r * 0.272) + (g * 0.534) + (b * 0.131);

                        int finalRed = (int)Math.Min(255, newRed);
                        int finalGreen = (int)Math.Min(255, newGreen);
                        int finalBlue = (int)Math.Min(255, newBlue);

                        ProcessedImage.SetPixel(x, y, Color.FromArgb(finalRed, finalGreen, finalBlue));
                    }
                }
                pictureBox2.Image = ProcessedImage;
            }
        }
    }
}
