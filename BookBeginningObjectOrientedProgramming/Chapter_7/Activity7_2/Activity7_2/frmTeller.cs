using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity7_2
{
    public partial class frmTeller : Form
    {
        public frmTeller()
        {
            InitializeComponent();
        }

        private void btnGetBalance_Click(object sender, EventArgs e)
        {
            GetBalance();
        }

        private void GetBalance()
        {
            CheckingAccount oCheckingAccount = new CheckingAccount();
            SavingsAccount oSavingsAccount = new SavingsAccount();
            Account oAccount = new Account();

            try
            {
                if(rdbChecking.Checked)
                    txtBalance.Text = oCheckingAccount.GetBalance(int.Parse(txtAccountNumber.Text)).ToString();
                else if(rdbSavings.Checked)
                    txtBalance.Text = oSavingsAccount.GetBalance(int.Parse(txtAccountNumber.Text)).ToString();
                else if(rdbGeneral.Checked)
                    txtBalance.Text = oAccount.GetBalance(int.Parse(txtAccountNumber.Text)).ToString();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            Withdraw();
        }

        private void Withdraw()
        {
            CheckingAccount oCheckingAccount = new CheckingAccount();
            SavingsAccount oSavingsAccount = new SavingsAccount();

            try
            {
                if (rdbChecking.Checked)
                {
                    oCheckingAccount.AccountNumber = int.Parse(txtAccountNumber.Text);
                    oCheckingAccount.Balance = double.Parse(txtBalance.Text);
                    txtBalance.Text = oCheckingAccount.Withdraw(double.Parse(txtAmount.Text)).ToString();
                }
                else if (rdbSavings.Checked)
                {
                    oSavingsAccount.AccountNumber = int.Parse(txtAccountNumber.Text);
                    oSavingsAccount.Balance = double.Parse(txtBalance.Text);
                    txtBalance.Text = oSavingsAccount.Withdraw(double.Parse(txtAmount.Text)).ToString();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
