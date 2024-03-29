﻿using System;
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
    public partial class HomeScreen : Form
    {
        public static string fName = "", lName = "", designation = "";
        public HomeScreen()
        {
            InitializeComponent();
        }

        private void HomeScreen_Load(object sender, EventArgs e)
        {
            
            lblWelcome.Text = "Welcome "+Form1.passId;
            setData();
        }

        private void bLogout_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Close();
        }

        private void bNext_Click(object sender, EventArgs e)
        {
            getData();
            AboutPage aboutPage = new AboutPage();
            aboutPage.Show();
            this.Hide();
        }

        private void getData()
        {
            fName = txtFName.Text;
            lName = txtLName.Text;
            designation = txtDesignation.Text;
        }
        public void setData()
        {
            txtFName.Text= fName;
            txtLName.Text= lName;
            txtDesignation.Text= designation;
        }
        private void bProgress_Click(object sender, EventArgs e)
        {
            getData();
            ProfilePage pp = new ProfilePage();
            pp.Show();
            this.Hide();
        }
    }
}
