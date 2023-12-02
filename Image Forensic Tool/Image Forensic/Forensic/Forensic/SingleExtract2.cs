using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Forensic
{
    public partial class SingleExtract2 : Form
    {
        string DSaveFilePath;
        FolderBrowserDialog f = new FolderBrowserDialog();
        Bitmap DecryptedBitmap;
        System.Drawing.Image DecryptedImage;
      
        string DLoadImagePath;
        int height, width;
        public SingleExtract2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
        public void imgload()
        {
            //tb_image.Text = o.FileName; 
            DLoadImagePath = Program.targetpath;
            pictureBox1.ImageLocation = DLoadImagePath;

            DecryptedImage = System.Drawing.Image.FromFile(DLoadImagePath);
            height = DecryptedImage.Height;
            width = DecryptedImage.Width;
            DecryptedBitmap = new Bitmap(DecryptedImage);
           
            FileInfo imginf = new FileInfo(DLoadImagePath);
            float fs = (float)imginf.Length / 1024;
            
            this.Invalidate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                if (f.ShowDialog() == DialogResult.OK)
                {
                    tb_file.Text = f.SelectedPath;
                    DSaveFilePath = tb_file.Text;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb_file.Text == "")
                {

                    if (tb_file.Text == "")
                        MessageBox.Show("Select a location....");
                }
                else
                {

                    if (tb_file.Text == String.Empty)
                    {
                        MessageBox.Show("Text boxes must not be empty!", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    //if (System.IO.File.Exists(Program.orgpath) == false)
                    //{
                    //    MessageBox.Show("Select image file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    //    return;
                    //}
                    DecryptLayer();
                }
            }
            catch (Exception ex)
            {
                label11.Text = "No file embedded.....";
            }
        }
        private void DecryptLayer()
        {
            //toolStripStatusLabel1.Text = "Decrypting... Please wait";
            Application.DoEvents();
            int i, j = 0;
            bool[] t = new bool[8];
            bool[] rb = new bool[8];
            bool[] gb = new bool[8];
            bool[] bb = new bool[8];
            Color pixel = new Color();
            byte r, g, b;
            try
            {
                pixel = DecryptedBitmap.GetPixel(width - 1, height - 1);
                long fSize = pixel.R + pixel.G * 100 + pixel.B * 10000;
                pixel = DecryptedBitmap.GetPixel(width - 2, height - 1);
                long fNameSize = pixel.R + pixel.G * 100 + pixel.B * 10000;
                byte[] res = new byte[fSize];
                string resFName = "";
                byte temp;

                //Read file name:
                for (i = 0; i < height && i * (height / 3) < fNameSize; i++)
                    for (j = 0; j < (width / 3) * 3 && i * (height / 3) + (j / 3) < fNameSize; j++)
                    {
                        pixel = DecryptedBitmap.GetPixel(j, i);
                        r = pixel.R;
                        g = pixel.G;
                        b = pixel.B;
                        byte2bool(r, ref rb);
                        byte2bool(g, ref gb);
                        byte2bool(b, ref bb);
                        if (j % 3 == 0)
                        {
                            t[0] = rb[7];
                            t[1] = gb[7];
                            t[2] = bb[7];
                        }
                        else if (j % 3 == 1)
                        {
                            t[3] = rb[7];
                            t[4] = gb[7];
                            t[5] = bb[7];
                        }
                        else
                        {
                            t[6] = rb[7];
                            t[7] = gb[7];
                            temp = bool2byte(t);
                            resFName += (char)temp;
                        }
                    }

                //Read file on layer 8 (after file name):
                int tempj = j;
                i--;

                for (; i < height && i * (height / 3) < fSize + fNameSize; i++)
                    for (j = 0; j < (width / 3) * 3 && i * (height / 3) + (j / 3) < (height * (width / 3) * 3) / 3 - 1 && i * (height / 3) + (j / 3) < fSize + fNameSize; j++)
                    {
                        if (tempj != 0)
                        {
                            j = tempj;
                            tempj = 0;
                        }
                        pixel = DecryptedBitmap.GetPixel(j, i);
                        r = pixel.R;
                        g = pixel.G;
                        b = pixel.B;
                        byte2bool(r, ref rb);
                        byte2bool(g, ref gb);
                        byte2bool(b, ref bb);
                        if (j % 3 == 0)
                        {
                            t[0] = rb[7];
                            t[1] = gb[7];
                            t[2] = bb[7];
                        }
                        else if (j % 3 == 1)
                        {
                            t[3] = rb[7];
                            t[4] = gb[7];
                            t[5] = bb[7];
                        }
                        else
                        {
                            t[6] = rb[7];
                            t[7] = gb[7];
                            temp = bool2byte(t);
                            res[i * (height / 3) + j / 3 - fNameSize] = temp;
                        }
                    }

                //Read file on other layers:
                long readedOnL8 = (height * (width / 3) * 3) / 3 - fNameSize - 1;

                for (int layer = 6; layer >= 0 && readedOnL8 + (6 - layer) * ((height * (width / 3) * 3) / 3 - 1) < fSize; layer--)
                    for (i = 0; i < height && i * (height / 3) + readedOnL8 + (6 - layer) * ((height * (width / 3) * 3) / 3 - 1) < fSize; i++)
                        for (j = 0; j < (width / 3) * 3 && i * (height / 3) + (j / 3) + readedOnL8 + (6 - layer) * ((height * (width / 3) * 3) / 3 - 1) < fSize; j++)
                        {
                            pixel = DecryptedBitmap.GetPixel(j, i);
                            r = pixel.R;
                            g = pixel.G;
                            b = pixel.B;
                            byte2bool(r, ref rb);
                            byte2bool(g, ref gb);
                            byte2bool(b, ref bb);
                            if (j % 3 == 0)
                            {
                                t[0] = rb[layer];
                                t[1] = gb[layer];
                                t[2] = bb[layer];
                            }
                            else if (j % 3 == 1)
                            {
                                t[3] = rb[layer];
                                t[4] = gb[layer];
                                t[5] = bb[layer];
                            }
                            else
                            {
                                t[6] = rb[layer];
                                t[7] = gb[layer];
                                temp = bool2byte(t);
                                res[i * (height / 3) + j / 3 + (6 - layer) * ((height * (width / 3) * 3) / 3 - 1) + readedOnL8] = temp;
                            }
                        }

                if (File.Exists(DSaveFilePath + "\\" + resFName))
                {
                    MessageBox.Show("File \"" + resFName + "\" already exist please choose another path to save file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                    File.WriteAllBytes(DSaveFilePath + "\\" + resFName, res);
                label11.Text = "There was an embedded file in the image..file saved in specified path";
                tb_file.Text = "";

                pictureBox1.Image = null;
                //toolStripStatusLabel1.Text = "Decrypted file has been successfully saved.";
                Application.DoEvents();
            }
            catch (Exception ex)
            {
                label11.Text = "No file embedded.....";
            }
        }
        private void byte2bool(byte inp, ref bool[] outp)
        {
            try
            {
                if (inp >= 0 && inp <= 255)
                    for (short i = 7; i >= 0; i--)
                    {
                        if (inp % 2 == 1)
                            outp[i] = true;
                        else
                            outp[i] = false;
                        inp /= 2;
                    }
                else
                    throw new Exception("Input number is illegal.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private byte bool2byte(bool[] inp)
        {
            byte outp = 0;
            try
            {
                for (short i = 7; i >= 0; i--)
                {
                    if (inp[i])
                        outp += (byte)Math.Pow(2.0, (double)(7 - i));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return outp;
        }

        private void SingleExtract2_Load(object sender, EventArgs e)
        {
            imgload();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
