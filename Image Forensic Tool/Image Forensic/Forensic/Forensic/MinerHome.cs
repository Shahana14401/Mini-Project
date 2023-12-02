using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Forensic
{
    public partial class MinerHome : Form
    {
        public string s = "";
        public MinerHome()
        {
            InitializeComponent();
        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }

        }
        private void toolStripButton4_Click(object sender, EventArgs e)
        {

            SingleImageMain obj = new SingleImageMain();
            obj.Show();
            
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            ActiveForm.Hide();
            obj.Show();
            //  Application.Exit();
            //StartForm obj = new StartForm();
            //ActiveForm.Hide();
            //obj.Show();

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            LoadImage obj = new LoadImage();
            Form ob = Form.ActiveForm;
            Form ob1 = ob.ActiveMdiChild;
            if (ob1 != null)
                ob1.Dispose();
            obj.Show();
          
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            //MinerSearchTranscation obj = new MinerSearchTranscation();
            //obj.Show();
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
             s = "0";
            LoadImage obj = new LoadImage(s);
            obj.Show();
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            Registration obj = new Registration();
            obj.Show();
        }

        private void MinerHome_Load(object sender, EventArgs e)
        {
           
        }
    }
}
