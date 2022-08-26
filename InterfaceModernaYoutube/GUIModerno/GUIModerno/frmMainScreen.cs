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

namespace GUIModerno
{
    public partial class frmDesignModern : Form
    {
        public frmDesignModern()
        {
            InitializeComponent();
        }

        private void picButtonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void picButtonMaximize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            picButtonMaximize.Visible = false;
            picButtonRestore.Visible = true;
        }

        private void picButtonMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void picButtonRestore_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            picButtonRestore.Visible = false;
            picButtonMaximize.Visible = true;
        }

        private void pnlTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMesg, int wParam, int lParam);

    }
}
