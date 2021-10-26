﻿using System;
using System.Windows.Forms;
using BCD_Restaurant_Project.Forms;
using BCD_Restaurant_Project.Forms.Customers;

namespace BCD_Restaurant_Project
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());

        }
    }
}
