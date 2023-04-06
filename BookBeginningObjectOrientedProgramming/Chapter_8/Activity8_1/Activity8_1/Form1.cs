using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity8_1
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void formClose(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Employee oEmployee = new Employee();
            oEmployee.LoginEvent += new Employee.LoginEventHandler(oEmployee_LoginEvent);
            oEmployee.Login(txtName.Text, txtPassword.Text);
        }

        void oEmployee_LoginEvent(string loginName, bool status)
        {
            MessageBox.Show($"Login status: { status }");
        }
    }
}
