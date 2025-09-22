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

        bool onBasicManip = true;
        public Form1()
        {
            InitializeComponent();
            userControl1 = new UserControl1();
            userControl2 = new UserControl2();

            panel1.Controls.Add(userControl1);
        }

        private void LoadImage(object sender, EventArgs e)
        {

            if (!onBasicManip)
            {
                return;
            }

            if(userControl1 != null)
            {
                userControl1.LoadImage(sender, e);
            }

        }

        private void SaveImage(object sender, EventArgs e)
        {

            if (onBasicManip)
            {
                if(userControl1 != null)
                {
                    userControl1.SaveImage(sender, e);
                }
            }
            else
            {
                if (userControl2 != null)
                {
                    userControl2.SaveImage(sender, e);
                }
            }

        }


        private void BasicCopy(object sender, EventArgs e)
        {
            if (onBasicManip)
            {
                userControl1.BasicCopy(sender, e);
            }
        }


        private void GrayScale(object sender, EventArgs e)
        {
            if (onBasicManip)
            {
                userControl1.GrayScale(sender, e);
            }
        }
        private void Invert(object sender, EventArgs e)
        {
            if (onBasicManip)
            {
                userControl1.Invert(sender, e);
            }
        }


        private void Histogram(object sender, EventArgs e)
        {
            if (onBasicManip)
            {
                userControl1.Histogram(sender, e);
            }
        }


        private void Sepia(object sender, EventArgs e)
        {
            if (onBasicManip)
            {
                userControl1.Sepia(sender, e);
            }
        }


        private void ChangeToBasicManip(object sender, EventArgs e)
        {
            if (!onBasicManip)
            {
                panel1.Controls.Clear();
                panel1.Controls.Add(userControl1);
                onBasicManip = true;
            }
        }


        private void ChangeToSubtraction(object sender, EventArgs e)
        {
            if (onBasicManip)
            {
                panel1.Controls.Clear();
                panel1.Controls.Add(userControl2);
                onBasicManip = false;
            }
        }
    }
}
