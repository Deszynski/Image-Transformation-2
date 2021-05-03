using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grafika_Lab7
{
    public partial class Form1 : Form
    {
        Bitmap bitmap;
        int width;
        int height;

        int[] partR = new int[256];
        int[] partG = new int[256];
        int[] partB = new int[256];

        int[] final_hist = new int[256];

        bool read = false;

        double[,] matrix;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog Opfile = new OpenFileDialog();
            if (DialogResult.OK == Opfile.ShowDialog())
            {
                pic.Image = new Bitmap(Opfile.FileName);
                bitmap = (Bitmap)pic.Image;

                width = pic.Image.Width;
                height = pic.Image.Height;

                Array.Clear(partR, 0, partR.Length);
                Array.Clear(partG, 0, partG.Length);
                Array.Clear(partB, 0, partB.Length);


                histogram();

                read = true;
                his1.Invalidate();
                his2.Invalidate();

                filter1.Image = bitmap;
                filter2.Image = bitmap;
                his1.Paint += new PaintEventHandler(panel1_Paint);
                his2.Paint += new PaintEventHandler(panel2_Paint);
                suwakA.Value = 0;
                suwakB.Value = 0;
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            Bitmap bitmapEdited = (Bitmap)bitmap.Clone();
            Bitmap bitmapCopy = (Bitmap)bitmap.Clone();

            int width = pic.Image.Width;
            int height = pic.Image.Height;

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color cA = bitmapCopy.GetPixel(x, y);

                    double r = (double)cA.R;
                    double g = (double)cA.G;
                    double b = (double)cA.B;

                    int c = 102;
                    int d = 230;


                    r = (r - suwakA.Value) * (d - c) / (suwakB.Value - suwakA.Value) + c;
                    g = (g - suwakA.Value) * (d - c) / (suwakB.Value - suwakA.Value) + c;
                    b = (b - suwakA.Value) * (d - c) / (suwakB.Value - suwakA.Value) + c;


                    if (r < 0)
                    {
                        r = 0;
                    }
                    if (g < 0)
                    {
                        g = 0;
                    }
                    if (b < 0)
                    {
                        b = 0;
                    }
                    if (r > 255)
                    {
                        r = 255;
                    }
                    if (g > 255)
                    {
                        g = 255;
                    }
                    if (b > 255)
                    {
                        b = 255;
                    }


                    bitmapEdited.SetPixel(x, y, Color.FromArgb((int)r, (int)g, (int)b));
                }
            }

            pic.Image = bitmapEdited;

            Array.Clear(partR, 0, partR.Length);
            Array.Clear(partG, 0, partG.Length);
            Array.Clear(partB, 0, partB.Length);


            histogram2(bitmapEdited);

            read = true;
            his2.Invalidate();
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            Bitmap bitmapEdited = (Bitmap)bitmap.Clone();
            Bitmap bitmapCopy = (Bitmap)bitmap.Clone();


            int width = pic.Image.Width;
            int height = pic.Image.Height;

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color cA = bitmapCopy.GetPixel(x, y);

                    double r = (double)cA.R;
                    double g = (double)cA.G;
                    double b = (double)cA.B;

                    int c = 102;
                    int d = 230;


                    r = (r - suwakA.Value) * (d - c) / (suwakB.Value - suwakA.Value) + c;
                    g = (g - suwakA.Value) * (d - c) / (suwakB.Value - suwakA.Value) + c;
                    b = (b - suwakA.Value) * (d - c) / (suwakB.Value - suwakA.Value) + c;

                    if (r < 0)
                    {
                        r = 0;
                    }
                    if (g < 0)
                    {
                        g = 0;
                    }
                    if (b < 0)
                    {
                        b = 0;
                    }
                    if (r > 255)
                    {
                        r = 255;
                    }
                    if (g > 255)
                    {
                        g = 255;
                    }
                    if (b > 255)
                    {
                        b = 255;
                    }

                    bitmapEdited.SetPixel(x, y, Color.FromArgb((int)r, (int)g, (int)b));
                }
            }

            pic.Image = bitmapEdited;


            Array.Clear(partR, 0, partR.Length);
            Array.Clear(partG, 0, partG.Length);
            Array.Clear(partB, 0, partB.Length);


            histogram2(bitmapEdited);

            read = true;
            his2.Invalidate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bitmap bitmapEdited = (Bitmap)bitmap.Clone();
            Bitmap bitmapCopy = (Bitmap)bitmap.Clone();

            double hR = 0, hG = 0, hB = 0;

            int width = pic.Image.Width;
            int height = pic.Image.Height;

            double[,] macierz = new double[,] { { 1, 1, 1 }, { 1, 1, 1 }, { 1, 1, 1 } };


            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {

                    hR = 0; hG = 0; hB = 0;

                    for (int k = -1; k <= 1; k++)
                    {
                        for (int l = -1; l <= 1; l++)
                        {
                            int x1 = i + k;
                            int y1 = j + l;

                            if (x1 < 0)
                            {
                                x1 = 0;
                            }
                            if (x1 >= bitmap.Height)
                            {
                                x1 = bitmap.Height - 1;
                            }
                            if (y1 < 0)
                            {
                                y1 = 0;
                            }
                            if (y1 >= bitmap.Width)
                            {
                                y1 = bitmap.Width - 1;
                            }
                            Color p = bitmapCopy.GetPixel(y1, x1);

                            double r = (double)p.R;
                            double g = (double)p.G;
                            double b = (double)p.B;

                            hR += r * macierz[k + 1, l + 1];
                            hG += g * macierz[k + 1, l + 1];
                            hB += b * macierz[k + 1, l + 1];

                        }
                    }

                    hR = hR / 9;
                    hG = hG / 9;
                    hB = hB / 9;


                    if (hR < 0)
                    {
                        hR = 0;
                    }
                    if (hG < 0)
                    {
                        hG = 0;
                    }
                    if (hB < 0)
                    {
                        hB = 0;
                    }
                    if (hR > 255)
                    {
                        hR = 255;
                    }
                    if (hG > 255)
                    {
                        hG = 255;
                    }
                    if (hB > 255)
                    {
                        hB = 255;
                    }

                    bitmapEdited.SetPixel(j, i, Color.FromArgb((int)hR, (int)hG, (int)hB));
                }
            }

            filter1.Image = bitmapEdited;
        }

        private void button3_Click(object sender, EventArgs e)
        { 
            int sigma = 10;
            double sum = 0;
            int kk = 7;
            int rr = 15;



            matrix = new double[rr, rr];

            for (int i = 0; i < 15; i++)
            {
                for (int j = 0; j < 15; j++)
                {
                    matrix[i, j] = (1 / (2 * Math.PI * Math.Pow(sigma, 2))) * Math.Pow(Math.E, -(Math.Pow(i - kk, 2) + Math.Pow(j - kk, 2)) / (2 * Math.Pow(sigma, 2)));
                    sum = sum + matrix[i, j];

                    Debug.WriteLine(matrix[i, j]);
                }
            }

            Bitmap bitmapEdited = (Bitmap)bitmap.Clone();
            Bitmap bitmapCopy = (Bitmap)bitmap.Clone();

            double hR = 0, hG = 0, hB = 0;

            int width = pic.Image.Width;
            int height = pic.Image.Height;

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {

                    hR = 0; hG = 0; hB = 0;

                    for (int k = -7; k <= 7; k++)
                    {
                        for (int l = -7; l <= 7; l++)
                        {
                            int x1 = i + k;
                            int y1 = j + l;

                            if (x1 < 0)
                            {
                                x1 = 0;
                            }
                            if (x1 >= bitmap.Height)
                            {
                                x1 = bitmap.Height - 1;
                            }
                            if (y1 < 0)
                            {
                                y1 = 0;
                            }
                            if (y1 >= bitmap.Width)
                            {
                                y1 = bitmap.Width - 1;
                            }
                            Color p = bitmapCopy.GetPixel(y1, x1);

                            double r = (double)p.R;
                            double g = (double)p.G;
                            double b = (double)p.B;

                            hR += r * matrix[k + kk, l + kk];
                            hG += g * matrix[k + kk, l + kk];
                            hB += b * matrix[k + kk, l + kk];

                        }
                    }

                    hR = hR / sum;
                    hG = hG / sum;
                    hB = hB / sum;


                    if (hR < 0)
                    {
                        hR = 0;
                    }
                    if (hG < 0)
                    {
                        hG = 0;
                    }
                    if (hB < 0)
                    {
                        hB = 0;
                    }
                    if (hR > 255)
                    {
                        hR = 255;
                    }
                    if (hG > 255)
                    {
                        hG = 255;
                    }
                    if (hB > 255)
                    {
                        hB = 255;
                    }

                    bitmapEdited.SetPixel(j, i, Color.FromArgb((int)hR, (int)hG, (int)hB));
                }
            }

            filter2.Image = bitmapEdited;
        }

        private void histogram()
        {
            int width = pic.Image.Width;
            int height = pic.Image.Height;

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color cA = bitmap.GetPixel(x, y);

                    int r = cA.R;
                    int g = cA.G;
                    int b = cA.B;

                    partR[r]++;
                    partG[g]++;
                    partB[b]++;
                }
            }

            for (int i = 0; i < final_hist.Length; i++)
            {
                final_hist[i] = partR[i] + partB[i] + partG[i];
            }
        }

        private void histogram2(Bitmap bitmapEdited)
        {
            int width = pic.Image.Width;
            int height = pic.Image.Height;

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color cA = bitmapEdited.GetPixel(x, y);

                    int r = cA.R;
                    int g = cA.G;
                    int b = cA.B;

                    partR[r]++;
                    partG[g]++;
                    partB[b]++;
                }
            }

            for (int i = 0; i < final_hist.Length; i++)
            {
                final_hist[i] = partR[i] + partB[i] + partG[i];
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            if (read == true)
            {
                Graphics graphR = e.Graphics;

                for (int i = 0; i < 256; i++)
                {
                    float r = final_hist[i];

                    r = r / (pic.Image.Height * pic.Image.Width);
                    r *= 1700;

                    graphR.DrawLine(new Pen(Color.Black), i, his1.Height, i, his1.Height - r);
                }
            }
        }


        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            if (read == true)
            {
                Graphics graphR = e.Graphics;

                for (int i = 0; i < 256; i++)
                {
                    float r = final_hist[i];

                    r = r / (pic.Image.Height * pic.Image.Width);
                    r *= 1700;

                    graphR.DrawLine(new Pen(Color.Black), i, his1.Height, i, his1.Height - r);
                }
            }
        }
    }
}
