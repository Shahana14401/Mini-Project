using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ImageForensic
{
    public partial class Quantization1 : Form
    {
        public static string s = "";
        private ImageForensic.HistogramaDesenat Histogram;
        public Quantization1()
        {
            InitializeComponent();
           
        }
        public Quantization1(Bitmap dct)
        {
            InitializeComponent();
         
            DCTimage.Image = (Image)dct;
            long[] myValues = GetHistogram(new Bitmap(DCTimage.Image));

           // histogramaDesenat1.DrawHistogram(myValues);
            ConvertDCTImage((Bitmap)DCTimage.Image);

        }
        public long[] GetHistogram(System.Drawing.Bitmap picture)
        {
            long[] myHistogram = new long[256];

            for (int i = 0; i < picture.Size.Width; i++)
                for (int j = 0; j < picture.Size.Height; j++)
                {
                    System.Drawing.Color c = picture.GetPixel(i, j);

                    long Temp = 0;
                    Temp += c.R;
                    Temp += c.G;
                    Temp += c.B;

                    Temp = (int)Temp / 3;
                    myHistogram[Temp]++;
                }

            return myHistogram;
        }
        public void ConvertDCTImage(Bitmap img)
        {
            string raw = "";
            int x = 0;
            List<Color> pixels = new List<Color>();
            if (img.Height > img.Width)
            {
                x = img.Width;
            }
            else
            {
                x = img.Height;
            }
            for (int y = 0; y < x; y += 5)
            {

                for (int j = 0; j < x; j += 5)
                {
                    pixels.Add(img.GetPixel(j, y));
                }

                foreach (Color item in pixels)
                {
                    // raw = raw + RetColor(item);
                    s = s + RetColor(item) + " ";

                }
                dataGridView2.Rows.Add();
                dataGridView2.Rows[dataGridView2.RowCount - 1].Cells[0].Value = s;
                s = "";

            }




        }
        public static string RetColor(Color color)
        {
            char[] hexDigits = {
     '0', '1', '2', '3', '4', '5', '6', '7',
     '8', '9', 'A', 'B', 'C', 'D', 'E', 'F'};
            byte[] bytes = new byte[3];
            bytes[0] = color.R;
            bytes[1] = color.G;
            bytes[2] = color.B;
            char[] chars = new char[bytes.Length * 2];
            for (int i = 0; i < bytes.Length; i++)
            {
                int b = bytes[i];
                chars[i * 2] = hexDigits[b >> 4];
                chars[i * 2 + 1] = hexDigits[b & 0xF];
            }


            string sraw = new string(chars);
            string final = sraw;
            return final;

        }
        public Bitmap pixelquantization(Bitmap scrBitmap)
        {
            Bitmap newBitmap = new Bitmap(scrBitmap.Width, scrBitmap.Height);
            for (int i = 0; i < scrBitmap.Width; i++)
            {
                for (int j = 0; j < scrBitmap.Height; j++)
                {
                    Color originalColor = scrBitmap.GetPixel(i, j);
                    if (originalColor.R > 250)
                    {
                        Color newcolor = GetRgb(originalColor.R, originalColor.G, originalColor.B);
                        newBitmap.SetPixel(i, j, newcolor);
                    }
                    else if (originalColor.G > 180)
                    {
                        Color newcolor = GetRgb1(originalColor.R, originalColor.G, originalColor.B);
                        newBitmap.SetPixel(i, j, newcolor);
                    }
                    else if (originalColor.B > 180)
                    {
                        Color newcolor = GetRgb2(originalColor.R, originalColor.G, originalColor.B);
                        newBitmap.SetPixel(i, j, newcolor);
                    }
                    else
                    {
                        newBitmap.SetPixel(i, j, originalColor);
                    }
                }

            }
            return newBitmap;

        }
        public static Color GetRgb(double r, double g, double b)
        {
            return Color.FromArgb(255, (byte)(r - 5), (byte)(g - 1), (byte)(b - 1));
        }
        public static Color GetRgb1(double r, double g, double b)
        {
            return Color.FromArgb(255, (byte)(r - 1), (byte)(g - 5), (byte)(b - 1));
        }
        public static Color GetRgb2(double r, double g, double b)
        {
            return Color.FromArgb(255, (byte)(r - 1), (byte)(g - 1), (byte)(b - 5));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bitmap bmp = pixelquantization((Bitmap)DCTimage.Image);
            NewDctImage.Image = (Image)bmp;

            long[] myValues = GetHistogram(new Bitmap(NewDctImage.Image));

           // histogramaDesenat2.DrawHistogram(myValues);
            ConvertDCTImage2(bmp);
        }
        public void ConvertDCTImage2(Bitmap img)
        {
            string raw = "";
            int x = 0;
            List<Color> pixels = new List<Color>();
            if (img.Height > img.Width)
            {
                x = img.Width;
            }
            else
            {
                x = img.Height;
            }
            for (int y = 0; y < x; y += 5)
            {

                for (int j = 0; j < x; j += 5)
                {
                    pixels.Add(img.GetPixel(j, y));
                }

                foreach (Color item in pixels)
                {
                    // raw = raw + RetColor(item);
                    s = s + RetColor(item) + " ";

                }
                dataGridView3.Rows.Add();
                dataGridView3.Rows[dataGridView3.RowCount - 1].Cells[0].Value = s;
                s = "";

            }




        }

        private void button2_Click(object sender, EventArgs e)
        {
            Noise1 obj = new Noise1((Bitmap)DCTimage.Image, (Bitmap)NewDctImage.Image);
            ActiveForm.Hide();
            obj.Show();
        }

    }
}
