﻿#region Imports

using System.Windows.Forms;
using BCD_Restaurant_Project.Classes;

#endregion

namespace BCD_Restaurant_Project.Forms.Employees.Regular {
    public partial class frmPaycheck : Form {
        public frmPaycheck() {
            InitializeComponent();
        }

        private void frmPaycheck_Load(object sender, System.EventArgs e) {
            ProgOps.showPaycheck(lblEmployeeID, lblEmployeeName, lblSalaryType, lblHourlyRate, lblWeeklyHoursWorked,
                                 lblGrossPay, lblSocialSecurityWithheld, lblFICAWithheld, lblRetirement, lblNetPay);

        }
    }
}