using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebCamLib;

namespace ImageProcessor
{
    public partial class UserControl3 : UserControl
    {
        Bitmap LoadedImage, ProcessedImage;
        Device[] devices;
        bool cameraOn = false;

        public UserControl3()
        {
            InitializeComponent();
        }


        public void LoadImage(object sender, EventArgs e)
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
                        pictureBox2.Image = null;
                    }
                }
                catch (Exception ex)
                {

                }
            }

        }


        public void SaveImage(object sender, EventArgs e)
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


        private void ToggleCamera(object sender, EventArgs e)
        {
            if (!cameraOn)
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


        private void SetFilteredImage()
        {
            if (ProcessedImage != null)
            {
                pictureBox2.Image = ProcessedImage;
            }
        }


        private void UseLatestFrame()
        {
            IDataObject data;
            Image bmap;

            Device d = devices[0];
            d.Sendmessage();

            data = Clipboard.GetDataObject();

            bmap = (Image)data.GetData("System.Drawing.Bitmap", true);

            LoadedImage = new Bitmap(bmap);
        }


        private void PerformFilter(ConvMatrix m)
        {
            if (cameraOn)
            {
                UseLatestFrame();
            }

            if (LoadedImage == null)
            {
                return;
            }

            ProcessedImage = (Bitmap)LoadedImage.Clone();
            ConvMatrix.Conv3x3(ProcessedImage, m);
            SetFilteredImage();
        }


        public void Smooth()
        {
            ConvMatrix m = new ConvMatrix();
            m.SetAll(1);
            m.Factor = 9;
            PerformFilter(m);
        }


        public void GaussianBlur()
        {
            ConvMatrix m = new ConvMatrix(1, 2, 1, 2, 4, 2, 1, 2, 1);
            m.Factor = 16;
            PerformFilter(m);
        }


        public void Sharpen()
        {
            ConvMatrix m = new ConvMatrix(0, -2, 0, -2, 11, -2, 0, -2, 0);
            m.Factor = 3;
            PerformFilter(m);
        }


        public void MeanRemoval()
        {
            ConvMatrix m = new ConvMatrix();
            m.SetAll(-1);
            m.Pixel = 9;
            PerformFilter(m);
        }


        public void EmbossLaplascian()
        {
            ConvMatrix m = new ConvMatrix(-1, 0, -1, 0, 4, 0, -1, 0, -1);
            m.Factor = 1;
            m.Offset = 127;
            PerformFilter(m);
        }


        public void EmbossHorizVert()
        {
            ConvMatrix m = new ConvMatrix(0, -1, 0, -1, 4, -1, 0, -1, 0);
            m.Factor = 1;
            m.Offset = 127;
            PerformFilter(m);
        }


        public void EmbossAllDirections()
        {
            ConvMatrix m = new ConvMatrix();
            m.SetAll(-1);
            m.Pixel = 8;
            m.Factor = 1;
            m.Offset = 127;
            PerformFilter(m);
        }


        public void EmbossLossy()
        {
            ConvMatrix m = new ConvMatrix(1, -2, 1, -2, 4, -2, -2, 1, -2);
            m.Factor = 1;
            m.Offset = 127;
            PerformFilter(m);
        }


        public void EmbossHorizontal()
        {
            ConvMatrix m = new ConvMatrix(0, 0, 0, -1, 2, -1, 0, 0, 0);
            m.Factor = 1;
            m.Offset = 127;
            PerformFilter(m);
        }


        public void EmbossVertical()
        {
            ConvMatrix m = new ConvMatrix(0, -1, 0, 0, 0, 0, 0, 1, 0);
            m.Factor = 1;
            m.Offset = 127;
            PerformFilter(m);
        }
    }
}
