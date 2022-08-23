using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void picButtonRestore_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            picButtonRestore.Visible = false;
            picButtonMaximize.Visible = true;
        }
    }
}
