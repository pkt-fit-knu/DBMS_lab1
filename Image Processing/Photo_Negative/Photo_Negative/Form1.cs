using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Photo_Negative
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDoIt_Click(object sender, EventArgs e)
        {
            Bitmap image = new Bitmap(@"E:\Projects\C#\WF\Photo_Negative\Photo_Negative\1.jpg");
            for (int i = 0; i < image.Width; i++)
            {
                for (int j = 0; j < image.Height; j++)
                {
                    image.SetPixel(i, j, Color.FromArgb(255 - image.GetPixel(i, j).A, 255 - image.GetPixel(i, j).R, 255 - image.GetPixel(i, j).G, 255 - image.GetPixel(i, j).B));
                }
            }
            picBox.Image = image;
        }
    }
}
