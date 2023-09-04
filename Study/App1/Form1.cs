using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App1
{
    public partial class Form1 : Form
    {
        public static string passId;
        public Form1()
        {
            InitializeComponent();
        }

        private void bReset_Click(object sender, EventArgs e)
        {
            txtUser.Text = string.Empty;
            txtPwd.Text = string.Empty;
        }

        private void bLogin_Click(object sender, EventArgs e)
        {
            goLogin();
        }
        private void goLogin()
        {
            String id = txtUser.Text;
            String pwd = txtPwd.Text;

            if (id == "root" && pwd == "root")
            {

                passId = id;
                HomeScreen hs = new HomeScreen();
                hs.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid User Name or Password (use root as default)");
            }
        }

        private void txtPwd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                goLogin();
            }
            if (e.KeyChar == (char)Keys.Escape)
            {
                //txtUser.Text = string.Empty;
                txtPwd.Text = string.Empty;
            }
        }
    }
}
