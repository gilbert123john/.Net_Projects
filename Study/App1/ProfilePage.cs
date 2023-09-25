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
        public static string name = "";
        public static string des = "";
        public static string desigination = "";
        public static string experience = "";
        public static string mca = "";
        public static string bsc = "";
        public static string project = "";
        public ProfilePage()
        {
            InitializeComponent();
        }
        public void getData()
        {
            name = HomeScreen.fName + " " + HomeScreen.lName;
            des = HomeScreen.designation;
            desigination = AboutPage.disc;
            experience = AboutPage.experience;
            mca = AboutPage.mca;
            bsc = AboutPage.bsc;
            project = AboutPage.project;

        }
        private void ProfilePage_Load(object sender, EventArgs e)
        {
            getData();
            lblName.Text = name;
            lblDes.Text = des;
            lblDesignation.Text = desigination;
            lblExperience.Text = experience; 
            lblMca.Text = mca;
            lblBsc.Text = bsc;
            lblProject.Text = project;
        }
        protected override void OnPaint(PaintEventArgs pea)
        {
            getLine(pea);

            //pea.Graphics.DrawRectangle(pen, 10.0F, 100.0F, 30.0F, 100.0F);

            //Rectangle rect = new Rectangle(50, 50, 200, 200);

            // Draw rectangle to screen.
            //pea.Graphics.DrawRectangle(pen, rect);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public void getLine(PaintEventArgs pea)
        {
            Pen pen = new Pen(ForeColor);
            float end = 650F;
            // for long vertical line
            PointF verticalTop = new PointF(150F, 70F);
            PointF verticalBottom = new PointF(150.0F, 700.0F);
            pea.Graphics.DrawLine(pen, verticalTop, verticalBottom);

            // for first horizontal line 
            PointF HorizontalHeadFront = new PointF(10F, 60F);
            PointF HorizontalHeadRear = new PointF(end, 60F);
            pea.Graphics.DrawLine(pen, HorizontalHeadFront, HorizontalHeadRear);

            //for horizontal line under summery
            PointF HorizontalSummeryF = new PointF(155F, 180F);
            PointF HorizontalSummeryR = new PointF(end, 180F);
            pea.Graphics.DrawLine(pen, HorizontalSummeryF, HorizontalSummeryR);

            //for horizontal line under experience
            PointF HorizontalExpF = new PointF(155F, 310F);
            PointF HorizontalExpR = new PointF(end, 310F);
            pea.Graphics.DrawLine(pen, HorizontalExpF, HorizontalExpR);

            //for horizontal line under experience
            PointF HorizontalCourseF = new PointF(155F, 465F);
            PointF HorizontalCourseR = new PointF(end, 465F);
            pea.Graphics.DrawLine(pen, HorizontalCourseF, HorizontalCourseR);
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            HomeScreen hs = new HomeScreen();
            hs.Show();
            this.Hide();
        }
    }
}
