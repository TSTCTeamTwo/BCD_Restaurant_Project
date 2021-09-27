﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BCD_Restaurant_Project.Classes;
namespace BCD_Restaurant_Project.Forms
{
    public partial class frmLogin : Form
    {
        private bool isShowing;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            ProgOps.openDatabase();
            isShowing = false;
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            ProgOps.CloseDatabase();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            ProgOps.verifyAccountExistence(tbxUsername.Text, tbxPassword.Text);
            
        }

        private void lnkForgot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmForgot form = new frmForgot();
            form.Show();
            this.Hide();
        }

        private void lnkSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmSignUp sign = new frmSignUp();
            sign.Show();
            this.Hide();
        }

        private void pbxPasswordIcon_Click(object sender, EventArgs e)
        {
            if (!isShowing)
            {
                Object rm = Properties.Resources.ResourceManager.GetObject("pressToHide");
                Bitmap myImage = (Bitmap)rm;
                Image image = myImage;

                pbxPasswordIcon.Image = image;
                tbxPassword.PasswordChar = default;
                isShowing = true;
            }
            else
            {
                Object rm = Properties.Resources.ResourceManager.GetObject("pressToShow");
                Bitmap myImage = (Bitmap)rm;
                Image image = myImage;

                pbxPasswordIcon.Image = image;
                tbxPassword.PasswordChar = '•';
                isShowing = false;
            }
        }
    }
}