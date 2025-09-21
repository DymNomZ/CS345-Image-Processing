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
            HideHistogram();
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
                        HideHistogram();
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
                HideHistogram();
            }
        }

        
        private int ComputeGray(Color pixelColor)
        {
            return (int)((pixelColor.R + pixelColor.G + pixelColor.B) / 3);
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
                        int gray = ComputeGray(pixelColor);
                        ProcessedImage.SetPixel(x, y, Color.FromArgb(gray, gray, gray));
                    }
                }
                pictureBox2.Image = ProcessedImage;
                HideHistogram();
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
                HideHistogram();
            }
        }


        private void HideHistogram()
        {
            chart1.Visible = false;
            chart2.Visible = false;
            chart3.Visible = false;
            chart4.Visible = false;
        }

        private void ShowHistogram()
        {
            chart1.Visible = true;
            chart2.Visible = true;
            chart3.Visible = true;
            chart4.Visible = true;
        }

        private void Histogram(object sender, EventArgs e)
        {
            if (ProcessedImage != null)
            {
                int[] redHistogram = new int[256];
                int[] greenHistogram = new int[256];
                int[] blueHistogram = new int[256];
                int[] grayHistogram = new int[256];


                for (int y = 0; y < ProcessedImage.Height; y++)
                {
                    for (int x = 0; x < ProcessedImage.Width; x++)
                    {
                        Color pixelColor = ProcessedImage.GetPixel(x, y);

                        redHistogram[pixelColor.R]++;
                        greenHistogram[pixelColor.G]++;
                        blueHistogram[pixelColor.B]++;
                        grayHistogram[ComputeGray(pixelColor)]++;
                    }
                }

                chart1.Series["Gray"].Points.Clear();
                chart2.Series["Red"].Points.Clear();
                chart3.Series["Green"].Points.Clear();
                chart4.Series["Blue"].Points.Clear();

                for (int i = 0; i < 256; i++)
                {
                    chart1.Series["Gray"].Points.AddXY(i, grayHistogram[i]);
                    chart2.Series["Red"].Points.AddXY(i, redHistogram[i]);
                    chart3.Series["Green"].Points.AddXY(i, greenHistogram[i]);
                    chart4.Series["Blue"].Points.AddXY(i, blueHistogram[i]);
                }

                ShowHistogram();
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
                HideHistogram();
            }
        }
    }
}
