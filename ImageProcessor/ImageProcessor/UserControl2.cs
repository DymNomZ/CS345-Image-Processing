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
using WebCamLib;

namespace ImageProcessor
{
    public partial class UserControl2 : UserControl
    {
        Bitmap imageB, imageA, resultImage;
        Device[] devices;
        bool cameraOn = false;
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


        private void ToggleCamera(object sender, EventArgs e)
        {
            if(!cameraOn)
            {
                devices = DeviceManager.GetAllDevices();
                pictureBox1.Image = null;
                devices[0].ShowWindow(pictureBox1);
                cameraOn = true;
            }
            else
            {
                devices[0].Stop();
                cameraOn = false;
            }
        }


        private Bitmap ResizeImage(Bitmap original, Bitmap target)
        {
            Bitmap result = new Bitmap(target.Width, target.Height);

            for(int i = 0; i < target.Width; i++)
            {
                for(int j = 0; j < target.Height; j++)
                {
                    int x = i * original.Width / target.Width;
                    int y = j * original.Height / target.Height;
                    Color pixel = original.GetPixel(x, y);
                    result.SetPixel(i, j, pixel);
                }
            }

            return result;
        }


        private void LoadImageB(object sender, EventArgs e)
        {
            if(cameraOn)
            {
                return;
            }
            openFileDialog1.ShowDialog();
        }


        private Bitmap CheckIfResizeNeeded()
        {
            if (imageA != null)
            {
                if (imageB.Width != imageA.Width || imageB.Height != imageA.Height)
                {
                    return ResizeImage(imageB, imageA);
                }
                return imageB;
            }
            return imageB;
        }


        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

            imageB = (Bitmap)Image.FromFile(openFileDialog1.FileName);

            if (imageB != null)
            {
                imageB = CheckIfResizeNeeded();
                pictureBox1.Image = imageB;
            }
        }


        private void LoadImageA(object sender, EventArgs e)
        {
            openFileDialog2.ShowDialog();
        }


        private void openFileDialog2_FileOk(object sender, CancelEventArgs e)
        {
            imageA = (Bitmap)Image.FromFile(openFileDialog2.FileName);

            if (imageA != null)
            {
                pictureBox2.Image = imageA;
            }
        }


        private void Subtract(object sender, EventArgs e)
        {
            if((imageB == null || imageA == null) && !cameraOn)
            {
                return;
            }

            //Note:
            //I am only able to retrieve the latest frame from the camera and use that as imageB
            //for subtraction sir as my laptop has only 4GB of ram and is soldered so it is not upgradable. 

            //I am using ManyCam (a virtual camera software similar to OBS) like most of my classmates
            //as they have discovered that some cameras, especially the ones in newer laptops,
            //are not compatible with the WebCamLib library. Turning on the webcam will return
            //a black image in the picture box.

            //Since I am running ManyCam in the backgroun, I cannot perform the live video method via a timer
            //as it will cause my laptop to lag and crash Visual Studio and ManyCam.
            if (cameraOn)
            {
                IDataObject data;
                Image bmap;

                Device d = devices[0];
                d.Sendmessage();

                data = Clipboard.GetDataObject();

                bmap = (Image)data.GetData("System.Drawing.Bitmap", true);

                imageB = new Bitmap(bmap);
                imageB = CheckIfResizeNeeded();
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
