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
    public partial class SingleImageMain : Form
    {
        ImageHandler imageHandler = new ImageHandler();
        public static double s1, s2;
        public SingleImageMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                System.Windows.Forms.OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "JPG|*.jpg;*.jpeg";
                //ofd.Filter = ofd.Filter = "Jpeg Images(*.jpg)|*.jpg";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    targetpic.ImageLocation = ofd.FileName;
                    targetpic.BackgroundImageLayout = ImageLayout.Stretch;
                    targetpic.Dock = DockStyle.Fill;
                    textBox1.Text = ofd.FileName;
                    Program.targetpath = textBox1.Text;
                    Program.suspected = (Bitmap)Image.FromFile(textBox1.Text);

                }


                targetpic.Image = (Image)Program.suspected;
                
                information2();
               

            }
            catch (Exception ex)
            {
                MessageBox.Show("error....");
            }
        }
        public void information2()
        {
            imageHandler.CurrentBitmap = Program.suspected;
            imageHandler.BitmapPath = Program.targetpath;
            imageinfo(imageHandler);
        }
        public void imageinfo(ImageHandler h)
        {
            FileInfo fileInfo = new FileInfo(h.BitmapPath);
            lblImageName2.Text = fileInfo.Name.Replace(fileInfo.Extension, "");
            lblImageExtension2.Text = fileInfo.Extension;
            string loc = fileInfo.DirectoryName;
            if (loc.Length > 50)
                loc = loc.Substring(0, 15) + "..." + loc.Substring(loc.LastIndexOf("\\"));
            lblImageLocation2.Text = loc;
            lblImageDimension2.Text = imageHandler.CurrentBitmap.Width + " x " + imageHandler.CurrentBitmap.Height;
            s1 = fileInfo.Length / 1024.0;
            lblImageCreatedOn2.Text = fileInfo.CreationTime.ToString("dddd MMMM dd, yyyy");

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Extract1 obj = new Extract1();
            obj.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            SingleExtract2 obj = new SingleExtract2();
            obj.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
