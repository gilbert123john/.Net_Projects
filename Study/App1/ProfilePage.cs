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
    public partial class ProfilePage : Form
    {
        public ProfilePage()
        {
            InitializeComponent();
        }

        private void ProfilePage_Load(object sender, EventArgs e)
        {
            lblName.Text = HomeScreen.fName + HomeScreen.lName;
            lblDes.Text = HomeScreen.designation;
        }
    }
}
