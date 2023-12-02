using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace ImageForensic
{
    public partial class Login : Form
    {
         BaseConnection con = new BaseConnection();
        public Login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
            //this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "select * from logintb where username='" + tid.Text + "'";
            SqlDataReader sdr = con.ret_dr(query);
            if (sdr.Read())
            {
                if (tid.Text == sdr[0].ToString() && tpwd.Text == sdr[1].ToString())
                {
                    if (sdr[2].ToString() == "1".ToString())
                    {

                        MinerHome bf = new MinerHome();
                            bf.Show();
                        
                    }
                    else
                    {
                        MessageBox.Show("invalid user ");
                    }

                }
                else
                {
                    MessageBox.Show("invalid user ");
                }
            }
            else
            {
                MessageBox.Show("invalid user ");
            }
        }
    }
}
