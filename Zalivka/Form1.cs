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
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = bmp;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left && paintingType == Painting.Feather)
            {

                if (e.X > 0 && e.X < pictureBox1.Width && e.Y > 0 && e.Y < pictureBox1.Height)
                {
                    bmp.SetPixel(e.X, e.Y, Color.Black);
                    pictureBox1.Image = bmp;
                }
            }
        }

        private Bitmap pouring(Bitmap bmp, int x, int y, Color newcolor)
        {
            Stack<Pixel> pixelStack = new Stack<Pixel>();
            Pixel currentPixel;
            pixelStack.Push(new Pixel(x, y));
            Color color1 = bmp.GetPixel(x,y);
            if (color1.ToArgb() == newcolor.ToArgb())
                return bmp;
            while (pixelStack.Count != 0)
            { 
                currentPixel = pixelStack.Pop();
                bmp.SetPixel(currentPixel.x, currentPixel.y, newcolor);
                x = currentPixel.x;
                y = currentPixel.y;
                if (x > 1 && x < pictureBox1.Width - 1 && y > 1 && y < pictureBox1.Height - 1)
                {
                    if (bmp.GetPixel(x + 1, y) == color1)
                    {
                        pixelStack.Push(new Pixel(x + 1, y));
                        bmp.SetPixel(x + 1, y, newcolor);
                    }
                    if (bmp.GetPixel(x - 1, y) == color1)
                    {
                        pixelStack.Push(new Pixel(x - 1, y));
                        bmp.SetPixel(x - 1, y, newcolor);
                    }
                    if (bmp.GetPixel(x, y + 1) == color1)
                    {
                        pixelStack.Push(new Pixel(x, y + 1));
                        bmp.SetPixel(x, y + 1, newcolor);

                        if (bmp.GetPixel(x + 1, y + 1) == color1)
                        {
                            pixelStack.Push(new Pixel(x + 1, y + 1));
                            bmp.SetPixel(x + 1, y + 1, newcolor);
                        }

                        if (bmp.GetPixel(x - 1, y + 1) == color1)
                        {
                            pixelStack.Push(new Pixel(x - 1, y + 1));
                            bmp.SetPixel(x - 1, y + 1, newcolor);
                        }
                    }

                    if (bmp.GetPixel(x, y - 1) == color1)
                    {
                        pixelStack.Push(new Pixel(x, y - 1));
                        bmp.SetPixel(x, y - 1, newcolor);

                        if (bmp.GetPixel(x + 1, y - 1) == color1)
                        {
                            pixelStack.Push(new Pixel(x + 1, y - 1));
                            bmp.SetPixel(x + 1, y - 1, newcolor);
                        }

                        if (bmp.GetPixel(x - 1, y - 1) == color1)
                        {
                            pixelStack.Push(new Pixel(x - 1, y - 1));
                            bmp.SetPixel(x - 1, y - 1, newcolor);
                        }
                    }
                }
            }
            return bmp;
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left && paintingType == Painting.Pouring)
            {
                pictureBox1.Image = pouring(bmp, e.X, e.Y, Color.Black);
            }
        }
    }
}
