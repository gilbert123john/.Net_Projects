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
        public static string disc = "", experience = "";
        public static string mca = "", bsc = "";
        public static string project = "";
        public AboutPage()
        {
            InitializeComponent();
        }
        private void getData()
        {
            disc = discriptionBox.Text;
            experience = expBox.Text;
            mca = mcaBox.Text;  
            bsc = bscBox.Text;
            project = projectBox.Text;
        }
        public void setData()
        {
            discriptionBox.Text = disc;
            expBox.Text = experience;
            mcaBox.Text = mca;
            bscBox.Text = bsc;
            projectBox.Text = project;
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
        protected override void OnPaint(PaintEventArgs pea)
        {
            Pen pen = new Pen(ForeColor);
            // for long vertical line
            PointF verticalTop = new PointF(240F, 20F);
            PointF verticalBottom = new PointF(240.0F, 350.0F);
            pea.Graphics.DrawLine(pen, verticalTop, verticalBottom);
        }
    }
}
