using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace App1
{
    public partial class AboutPage : Form
    {
        public static string disc = "";
        public AboutPage()
        {
            InitializeComponent();
        }
        private void getData()
        {
            disc = discriptionBox.Text;
        }
        public void setData()
        {
            discriptionBox.Text = disc;
        }
        private void bProgress_Click(object sender, EventArgs e)
        {
            getData();
            ProfilePage pp = new ProfilePage();
            pp.Show();
            this.Hide();
        }

        private void AboutPage_Load(object sender, EventArgs e)
        {
            setData();
        }
    }
}
