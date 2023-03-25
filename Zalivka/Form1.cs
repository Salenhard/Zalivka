using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;

namespace Zalivka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
        }

        Bitmap bmp;
        Painting paintingType = Painting.Feather;
        struct Pixel
        {
            public int x;
            public int y;

            public Pixel(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }
        enum Painting{
            Feather, Pouring
        }

        private void buttonPouring_Click(object sender, EventArgs e)
        {
            if (paintingType != Painting.Pouring)
            {
                paintingType = Painting.Pouring;
            }
        }

        private void buttonFether_Click(object sender, EventArgs e)
        {
            if (paintingType != Painting.Feather)
            {
                paintingType = Painting.Feather;
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            bmp = new Bitmap(pictureBox1.Height, pictureBox1.Width);
            pictureBox1.Image = bmp;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                bmp.SetPixel(e.X, e.Y, Color.Black);
                pictureBox1.Image = bmp;
            }
        }

        private Bitmap pouring(Bitmap bmp, int x, int y, Color color)
        {

            Stack<Pixel> pixelStack = new Stack<Pixel>();
            pixelStack.Push(new Pixel(x, y));
            Color color1 = bmp.GetPixel(x, y);
            while (pixelStack.Count != 0)
            {
                if (bmp.GetPixel(x + 1, y + 1) != color1)
                    pixelStack.Push(new Pixel(x + 1, y + 1));
            }
            return bmp;
        }

    }
}
