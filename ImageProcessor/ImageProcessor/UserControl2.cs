using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageProcessor
{
    public partial class UserControl2 : UserControl
    {
        Bitmap imageB, imageA, resultImage;

        OpenFileDialog ofdB = new OpenFileDialog();
        OpenFileDialog ofdA = new OpenFileDialog();

        public UserControl2()
        {
            InitializeComponent();
        }

        public void SaveImage(object sender, EventArgs e)
        {
            if (resultImage != null)
            {
                SaveFileDialog sfd = new SaveFileDialog();

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        resultImage.Save(sfd.FileName + ".png");
                    }
                    catch (Exception ex)
                    {

                    }
                }
            }
        }


        private void LoadImageB(object sender, EventArgs e)
        {
            if (ofdB.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    imageB = (Bitmap)Image.FromFile(ofdB.FileName);

                    if (imageB != null)
                    {
                        pictureBox1.Image = imageB;
                    }
                }
                catch (Exception ex)
                {

                }
            }
        }


        private void LoadImageA(object sender, EventArgs e)
        {
            if (ofdA.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    imageA = (Bitmap)Image.FromFile(ofdA.FileName);

                    if (imageA != null)
                    {
                        pictureBox2.Image = imageA;
                    }
                }
                catch (Exception ex)
                {

                }
            }
        }


        private void Subtract(object sender, EventArgs e)
        {
            if(imageB == null || imageA == null)
            {
                return;
            }

            if (imageB.Width != imageA.Width || imageB.Height != imageA.Height)
            {
                return;
            }

            Color mygreen = Color.FromArgb(0, 255, 0);
            int greygreen = (mygreen.R + mygreen.G + mygreen.B) / 3;
            int threshold = 5;

            resultImage = new Bitmap(imageA.Width, imageA.Height);

            for (int x = 0; x < imageB.Width; x++)
            {
                for(int y = 0; y < imageB.Height; y++)
                {
                    Color pixel = imageB.GetPixel(x, y);
                    Color backpixel = imageA.GetPixel(x, y);
                    int grey = (pixel.R + pixel.G + pixel.B) / 3;
                    int subtractvalues = Math.Abs(grey - greygreen);

                    if(subtractvalues > threshold)
                    {
                        resultImage.SetPixel(x, y, pixel);
                    }
                    else
                    {
                        resultImage.SetPixel(x, y, backpixel);
                    }
                }
            }
            pictureBox3.Image = resultImage;
        }
    }
}
