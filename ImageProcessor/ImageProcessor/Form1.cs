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
        UserControl1 userControl1;
        UserControl2 userControl2;
        UserControl3 userControl3;

        public Form1()
        {
            InitializeComponent();
            userControl1 = new UserControl1();
            userControl2 = new UserControl2();
            userControl3 = new UserControl3();

            panel1.Controls.Add(userControl1);
        }

        private enum States
        {
            BasicManip,
            Subtraction,
            Convolution
        }

        private States state = States.BasicManip;

        private void LoadImage(object sender, EventArgs e)
        {

            if (state.Equals(States.Subtraction))
            {
                return;
            }

            if (state.Equals(States.BasicManip))
            {
                userControl1.LoadImage(sender, e);
            }
            else if (state.Equals(States.Convolution))
            {
                userControl3.LoadImage(sender, e);
            }

        }

        private void SaveImage(object sender, EventArgs e)
        {

            if (state.Equals(States.BasicManip))
            {
                if(userControl1 != null)
                {
                    userControl1.SaveImage(sender, e);
                }
            }
            else if (state.Equals(States.Subtraction))
            {
                if (userControl2 != null)
                {
                    userControl2.SaveImage(sender, e);
                }
            }
            else if (state.Equals(States.Convolution))
            {
                if (userControl3 != null)
                {
                    userControl3.SaveImage(sender, e);
                }
            }

        }


        private void BasicCopy(object sender, EventArgs e)
        {
            if (state.Equals(States.BasicManip))
            {
                userControl1.BasicCopy(sender, e);
            }
        }


        private void GrayScale(object sender, EventArgs e)
        {
            if (state.Equals(States.BasicManip))
            {
                userControl1.GrayScale(sender, e);
            }
        }
        private void Invert(object sender, EventArgs e)
        {
            if (state.Equals(States.BasicManip))
            {
                userControl1.Invert(sender, e);
            }
        }


        private void Histogram(object sender, EventArgs e)
        {
            if (state.Equals(States.BasicManip))
            {
                userControl1.Histogram(sender, e);
            }
        }


        private void Sepia(object sender, EventArgs e)
        {
            if (state.Equals(States.BasicManip))
            {
                userControl1.Sepia(sender, e);
            }
        }


        private void ChangeToBasicManip(object sender, EventArgs e)
        {
            if (!state.Equals(States.BasicManip))
            {
                panel1.Controls.Clear();
                panel1.Controls.Add(userControl1);
                state = States.BasicManip;
            }
        }


        private void ChangeToSubtraction(object sender, EventArgs e)
        {
            if (!state.Equals(States.Subtraction))
            {
                panel1.Controls.Clear();
                panel1.Controls.Add(userControl2);
                state = States.Subtraction;
            }
        }


        private void ChangeToConvolution(object sender, EventArgs e)
        {
            if (!state.Equals(States.Convolution))
            {
                panel1.Controls.Clear();
                panel1.Controls.Add(userControl3);
                state = States.Convolution;
            }
        }


        private void Smooth(object sender, EventArgs e)
        {
            if (state.Equals(States.Convolution))
            {
                userControl3.Smooth();
            }
        }


        private void GaussianBlur(object sender, EventArgs e)
        {
            if (state.Equals(States.Convolution))
            {
                userControl3.GaussianBlur();
            }
        }


        public void Sharpen(object sender, EventArgs e)
        {
            if (state.Equals(States.Convolution))
            {
                userControl3.Sharpen();
            }
        }


        public void MeanRemoval(object sender, EventArgs e)
        {
            if (state.Equals(States.Convolution))
            {
                userControl3.MeanRemoval();
            }
        }


        public void EmbossLaplascian(object sender, EventArgs e)
        {
            if (state.Equals(States.Convolution))
            {
                userControl3.EmbossLaplascian();
            }
        }


        public void EmbossHorizVert(object sender, EventArgs e)
        {
            if (state.Equals(States.Convolution))
            {
                userControl3.EmbossHorizVert();
            }
        }


        public void EmbossAllDirections(object sender, EventArgs e)
        {
            if (state.Equals(States.Convolution))
            {
                userControl3.EmbossAllDirections();
            }
        }


        public void EmbossLossy(object sender, EventArgs e)
        {
            if (state.Equals(States.Convolution))
            {
                userControl3.EmbossLossy();
            }
        }


        public void EmbossHorizontal(object sender, EventArgs e)
        {
            if (state.Equals(States.Convolution))
            {
                userControl3.EmbossHorizontal();
            }
        }


        public void EmbossVertical(object sender, EventArgs e)
        {
            if (state.Equals(States.Convolution))
            {
                userControl3.EmbossVertical();
            }
        }
    }
}
