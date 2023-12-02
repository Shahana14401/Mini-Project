using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;

namespace ImageForensic
{
    public partial class FormEmbed : Form
    {
        public FormEmbed(string f)
        {
            InitializeComponent();
            pictureBox1.Image = Image.FromFile(f);
            Program.org = (Bitmap)Image.FromFile(f);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
        public string DataToByteArray(string str)
        {
            byte[] b = System.Text.ASCIIEncoding.ASCII.GetBytes(str);
            string str1 = Convert.ToBase64String(b);
            return str1;
        }  
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
               // string ss = DataToByteArray(textBox2.Text);
                string ss = textBox2.Text; 
                Program.text = ss;
                Filehandler obj = new Filehandler();
                Bitmap c = obj.savefile();

                SaveFileDialog saveFileDialog1 = new SaveFileDialog();      
                   
                 saveFileDialog1.Title = "Save text Files";      
                  


                 if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                 {
                     string str=saveFileDialog1.FileName + ".jpg";
                     MessageBox.Show(str);

                     c.Save(str, ImageFormat.Png);
                 }      
               // string[] filelist = Directory.GetFiles(Application.StartupPath + "\\dataset", "*.jpg");
               // int i = filelist.Length;
               // i++;

                //c.Save(Application.StartupPath + "\\dataset\\dataset_" + i.ToString() + ".jpg", ImageFormat.Png);

               


                MessageBox.Show("Training finished....");
                Application.Exit();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Training Failure....");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Extract1 obj = new Extract1();
            obj.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void FormEmbed_Load(object sender, EventArgs e)
        {

        }
    }
}
