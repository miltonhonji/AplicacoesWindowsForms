using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace FlatLoginWatermark
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pnlLogo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtLoginPassword_Enter(object sender, EventArgs e)
        {
            if(txtLoginPassword.Text == "DIGITE SUA SENHA")
            {
                txtLoginPassword.Text = String.Empty;
                txtLoginPassword.ForeColor = Color.LightGray;
                txtLoginPassword.UseSystemPasswordChar = true;
            }
        }

        private void txtLoginPassword_Leave(object sender, EventArgs e)
        {
            if (txtLoginPassword.Text == String.Empty)
            {
                txtLoginPassword.Text = "DIGITE SUA SENHA";
                txtLoginPassword.ForeColor = Color.DimGray;
                txtLoginPassword.UseSystemPasswordChar = false;
            }
        }

        private void txtLoginUser_Enter(object sender, EventArgs e)
        {
            if(txtLoginUser.Text == "DIGITE SEU USUÁRIO")
            {
                txtLoginUser.Text = String.Empty;
                txtLoginUser.ForeColor = Color.LightGray;
            }
        }

        private void txtLoginUser_Leave(object sender, EventArgs e)
        {
            if(txtLoginUser.Text == String.Empty)
            {
                txtLoginUser.Text = "DIGITE SEU USUÁRIO";
                txtLoginUser.ForeColor = Color.DimGray;
            }
        }
    }
}
