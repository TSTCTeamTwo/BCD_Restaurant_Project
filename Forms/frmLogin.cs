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
using System.Threading;
using BCD_Restaurant_Project.Classes;
using BCD_Restaurant_Project.Forms.Customers;
using BCD_Restaurant_Project.Forms.Employees;
namespace BCD_Restaurant_Project.Forms
{
    public partial class frmLogin : Form
    {
        private bool isShowing = false;
        private static readonly StringBuilder _errorMessages = new StringBuilder();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            
            isShowing = false;
            tbxUsername.Focus();

            ////FOR TESTING

            tbxUsername.Text = "rdemeza0";
            tbxPassword.Text = "59g0GR05";

            btnLogin.Focus();

        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            ProgOps.closeDatabase();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            int employee = -1;
            if (tbxUsername.Text.Equals("") || tbxPassword.Text.Equals(""))
            {
                lblEmpty.Visible = true;
            }
            else
            {
                try
                {
                    ProgOps.openDatabase();
                    ProgOps.AccountID = ProgOps.verifyAccountExistence(tbxUsername.Text, tbxPassword.Text);
                    if (ProgOps.AccountID != -1)
                    {
                        //storing accounts first name and last name to use it later in the application
                        ProgOps.AccountFirstName = ProgOps.DTAccounts.Rows[0]["FirstName"].ToString();
                        ProgOps.AccountLastName = ProgOps.DTAccounts.Rows[0]["LastName"].ToString();
                        ProgOps.AccountID = (int)ProgOps.DTAccounts.Rows[0]["AccountID"];

                        employee = ProgOps.verifyEmployeeStatus(ProgOps.AccountID);//storing the type of account


                        if (employee == 2)//account is an admin
                        {
                            new frmMainManagers().Show();
                        }
                        else if(employee == 1)//account is employee
                        {
                            new frmMainEmployees().Show();
                        }
                        else
                        {
                            new frmMain().Show();
                        }
                        lblEmpty.Visible = false;
                        Hide();
                    }
                    else
                    {
                        MessageBox.Show("Account not found", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tbxPassword.Clear();
                        tbxUsername.Focus();
                    }
                }
                catch (SqlException ex)
                {
                    if (ex is SqlException)
                    {
                        for (int i = 0; i < ex.Errors.Count; i++)
                        {
                            _errorMessages.Append("Index#" + i + "\n" +
                                "Message: " + ex.Errors[i].Message + "\n" +
                                "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                                "Source: " + ex.Errors[i].Source + "\n" +
                                "Procedure: " + ex.Errors[i].Procedure + "\n");
                        }
                        MessageBox.Show(_errorMessages.ToString(), "Error Close Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {//handles generic ones here
                        MessageBox.Show(ex.Message + "Error (PO2)", "Error Close Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            
            
        }

        private void lnkForgot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmForgot form = new frmForgot();
            form.Show();
            //this.Hide();
        }

        private void lnkSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmSignUp sign = new frmSignUp();
            sign.Show();
            //this.Hide();
        }

        private void pbxPasswordIcon_Click(object sender, EventArgs e)
        {
            
            if (!isShowing)
            {
                Object rm = Properties.Resources.ResourceManager.GetObject("pressToShow");
                Bitmap myImage = (Bitmap)rm;
                Image image = myImage;

                pbxPasswordIcon.Image = image;
                tbxPassword.PasswordChar = default;
                isShowing = true;
            }
            else
            {
                Object rm = Properties.Resources.ResourceManager.GetObject("pressToHide");
                Bitmap myImage = (Bitmap)rm;
                Image image = myImage;

                pbxPasswordIcon.Image = image;
                tbxPassword.PasswordChar = '•';
                isShowing = false;
            }
        }
    }
}
