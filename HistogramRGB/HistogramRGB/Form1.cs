using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HistogramRGB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Bitmap img = new Bitmap(@"E:\Projects\C#\WF\HistogramRGB\w.jpg");
            pictureBox1.Image = img;
            GetHistogram(img);
        }
        public void GetHistogram(Bitmap image)
        {
            Bitmap diagram = new Bitmap(256, 512);
            int[] histogram = new int[255];

            for (int i = 0; i < image.Width; i++)
            {
                for (int j = 0; j < image.Height; j++)
                {
                    int br = Convert.ToInt16(image.GetPixel(i, j).GetBrightness() * 100);
                    histogram[br]++;
                }
            }

            for (int i = 0; i < 255; i++)
            {
                for (int j = 0; j < histogram[i]; j++)
                {
                    diagram.SetPixel(i, j / 100, Color.Black);
                }
            }


            diagram.RotateFlip(RotateFlipType.Rotate180FlipNone);
            pictureBox2.Image = diagram;
        }
    }
}
