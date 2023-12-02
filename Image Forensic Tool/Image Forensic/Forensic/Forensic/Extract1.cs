using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Forensic
{
    public partial class Extract1 : Form
    {
        public static string jf = "";
        public Extract1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BitClassifier obj = new BitClassifier();
            string final = obj.extractText((Bitmap)pictureBox1.Image);
            jf = final;
            readfile(final);
        }
        public string ConvertToByte(string str)
        {
            byte[] b;
            string ss;
            try
            {
                b = Convert.FromBase64String(str);
                ss= System.Text.ASCIIEncoding.ASCII.GetString(b);
            }
            catch (FormatException fe)
            {
                ss = "";
            }
            return ss;
        }  
        private void button1_Click(object sender, EventArgs e)
        {
           
        }
        public void readfile(string n)
        {

            string[] files = n.Split(new[] { "^&*#(" }, StringSplitOptions.None);

            if (files.Length >= 2)
            {
               
                // pictureBox6.Visible = true;
                string t = files[0].ToString();
                string text = files[1].ToString();

              
              //  textBox2.Text = ConvertToByte(text);
                textBox2.Text = text;
                
            }
            else
            {
                MessageBox.Show("Not  detected");
              

            }


        }

        private void Extract1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(Program.targetpath);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
