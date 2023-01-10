using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity6_2
{
    public partial class frmEmployeeInfo : Form
    {
        public frmEmployeeInfo()
        {
            InitializeComponent();
        }

        private void btnExistingEmployee_Click(object sender, EventArgs e)
        {
            Employee oEmployee = new Employee(int.Parse(txtEmployeeId.Text));

            txtEmployeeId.Enabled = false;
            txtEmployeeLoginName.Text = oEmployee.LoginName;
            txtEmployeePassword.Text = oEmployee.Password;
            txtEmployeeSsn.Text = oEmployee.Ssn.ToString();
            txtEmployeeDepartment.Text = oEmployee.Department;
        }

        private void btnNewEmployee_Click(object sender, EventArgs e)
        {
            Employee oEmployee = new Employee();

            txtEmployeeId.Text = oEmployee.EmployeeID.ToString();
            txtEmployeeId.Enabled = false;
            txtEmployeeLoginName.Text = "";
            txtEmployeePassword.Text = "";
            txtEmployeeSsn.Text = "";
            txtEmployeeDepartment.Text = "";
        }

        private void btnResetEmployeeId_Click(object sender, EventArgs e)
        {
            txtEmployeeId.Enabled = true;
        }

        private void btnEmployeeUpdateInformationSecurity_Click(object sender, EventArgs e)
        {
            Employee oEmployee = new Employee(int.Parse(txtEmployeeId.Text));

            MessageBox.Show(oEmployee.Update(txtEmployeeLoginName.Text, txtEmployeePassword.Text));

            txtEmployeeLoginName.Text = oEmployee.LoginName;
            txtEmployeePassword.Text = oEmployee.Password;
        }

        private void btnEmployeeUpdateHumanResource_Click(object sender, EventArgs e)
        {
            Employee oEmployee = new Employee(int.Parse(txtEmployeeId.Text));
            MessageBox.Show(oEmployee.Update(int.Parse(txtEmployeeSsn.Text), txtEmployeeDepartment.Text));
            txtEmployeeSsn.Text = oEmployee.Ssn.ToString();
            txtEmployeeDepartment.Text = oEmployee.Department;
        }
    }
}
