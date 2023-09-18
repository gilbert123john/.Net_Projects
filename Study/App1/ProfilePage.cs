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
    public partial class ProfilePage : Form
    {
        public static string name = "", des = "", desigination = "";
        public ProfilePage()
        {
            InitializeComponent();
        }
        public void getData()
        {
            name = HomeScreen.fName + " " + HomeScreen.lName;
            des = HomeScreen.designation;
            desigination = AboutPage.disc;
        }
        private void ProfilePage_Load(object sender, EventArgs e)
        {
            getData();
            lblName.Text = name;
            lblDes.Text = des;
            lblDesignation.Text = desigination;
        }
        protected override void OnPaint(PaintEventArgs pea)
        {

            Pen pen = new Pen(ForeColor);
            PointF verticalTop = new PointF(150F, 70F);
            PointF verticalBottom = new PointF(150.0F, 700.0F);
            PointF HorizontalHeadFront = new PointF(10F, 60F);
            PointF HorizontalHeadRear = new PointF(580F, 60F);
            pea.Graphics.DrawLine(pen, verticalTop, verticalBottom);
            pea.Graphics.DrawLine(pen, HorizontalHeadFront, HorizontalHeadRear);
            //pea.Graphics.DrawRectangle(pen, 10.0F, 100.0F, 30.0F, 100.0F);

            //Rectangle rect = new Rectangle(50, 50, 200, 200);

            // Draw rectangle to screen.
            //pea.Graphics.DrawRectangle(pen, rect);
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            HomeScreen hs = new HomeScreen();
            hs.Show();
            this.Hide();
        }
    }
}
