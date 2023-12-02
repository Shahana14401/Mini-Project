using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace ImageForensic
{
    public partial class MinerHome : Form
    {
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

            LoadImage obj = new LoadImage();
            obj.Show();
            
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            // Application.Exit();
            Login obj = new Login();
            ActiveForm.Hide();
            obj.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

          
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            //MinerSearchTranscation obj = new MinerSearchTranscation();
            //obj.Show();
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
           
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
           
        }

        private void MinerHome_Load(object sender, EventArgs e)
        {
            
        }
    }
}
