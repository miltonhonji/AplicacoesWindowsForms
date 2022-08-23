namespace GUIModerno
{
    partial class frmDesignModern
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDesignModern));
            this.pnlBarraTitulo = new System.Windows.Forms.Panel();
            this.picButtonRestore = new System.Windows.Forms.PictureBox();
            this.picButtonMinimize = new System.Windows.Forms.PictureBox();
            this.picButtonMaximize = new System.Windows.Forms.PictureBox();
            this.picButtonClose = new System.Windows.Forms.PictureBox();
            this.pnlMenuVertical = new System.Windows.Forms.Panel();
            this.pnlKontenedor = new System.Windows.Forms.Panel();
            this.pnlBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picButtonRestore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picButtonMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picButtonMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picButtonClose)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBarraTitulo
            // 
            this.pnlBarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.pnlBarraTitulo.Controls.Add(this.picButtonRestore);
            this.pnlBarraTitulo.Controls.Add(this.picButtonMinimize);
            this.pnlBarraTitulo.Controls.Add(this.picButtonMaximize);
            this.pnlBarraTitulo.Controls.Add(this.picButtonClose);
            this.pnlBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlBarraTitulo.Name = "pnlBarraTitulo";
            this.pnlBarraTitulo.Size = new System.Drawing.Size(1300, 38);
            this.pnlBarraTitulo.TabIndex = 0;
            // 
            // picButtonRestore
            // 
            this.picButtonRestore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picButtonRestore.Image = ((System.Drawing.Image)(resources.GetObject("picButtonRestore.Image")));
            this.picButtonRestore.Location = new System.Drawing.Point(1169, 5);
            this.picButtonRestore.Name = "picButtonRestore";
            this.picButtonRestore.Size = new System.Drawing.Size(25, 25);
            this.picButtonRestore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picButtonRestore.TabIndex = 3;
            this.picButtonRestore.TabStop = false;
            this.picButtonRestore.Click += new System.EventHandler(this.picButtonRestore_Click);
            // 
            // picButtonMinimize
            // 
            this.picButtonMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picButtonMinimize.Image = ((System.Drawing.Image)(resources.GetObject("picButtonMinimize.Image")));
            this.picButtonMinimize.Location = new System.Drawing.Point(1200, 5);
            this.picButtonMinimize.Name = "picButtonMinimize";
            this.picButtonMinimize.Size = new System.Drawing.Size(25, 25);
            this.picButtonMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picButtonMinimize.TabIndex = 2;
            this.picButtonMinimize.TabStop = false;
            this.picButtonMinimize.Click += new System.EventHandler(this.picButtonMinimize_Click);
            // 
            // picButtonMaximize
            // 
            this.picButtonMaximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picButtonMaximize.Image = ((System.Drawing.Image)(resources.GetObject("picButtonMaximize.Image")));
            this.picButtonMaximize.Location = new System.Drawing.Point(1231, 6);
            this.picButtonMaximize.Name = "picButtonMaximize";
            this.picButtonMaximize.Size = new System.Drawing.Size(25, 25);
            this.picButtonMaximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picButtonMaximize.TabIndex = 1;
            this.picButtonMaximize.TabStop = false;
            this.picButtonMaximize.Click += new System.EventHandler(this.picButtonMaximize_Click);
            // 
            // picButtonClose
            // 
            this.picButtonClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picButtonClose.Image = ((System.Drawing.Image)(resources.GetObject("picButtonClose.Image")));
            this.picButtonClose.Location = new System.Drawing.Point(1263, 6);
            this.picButtonClose.Name = "picButtonClose";
            this.picButtonClose.Size = new System.Drawing.Size(25, 25);
            this.picButtonClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picButtonClose.TabIndex = 0;
            this.picButtonClose.TabStop = false;
            this.picButtonClose.Click += new System.EventHandler(this.picButtonClose_Click);
            // 
            // pnlMenuVertical
            // 
            this.pnlMenuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.pnlMenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenuVertical.Location = new System.Drawing.Point(0, 38);
            this.pnlMenuVertical.Name = "pnlMenuVertical";
            this.pnlMenuVertical.Size = new System.Drawing.Size(220, 612);
            this.pnlMenuVertical.TabIndex = 1;
            // 
            // pnlKontenedor
            // 
            this.pnlKontenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.pnlKontenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlKontenedor.Location = new System.Drawing.Point(220, 38);
            this.pnlKontenedor.Name = "pnlKontenedor";
            this.pnlKontenedor.Size = new System.Drawing.Size(1080, 612);
            this.pnlKontenedor.TabIndex = 2;
            // 
            // frmDesignModern
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 650);
            this.Controls.Add(this.pnlKontenedor);
            this.Controls.Add(this.pnlMenuVertical);
            this.Controls.Add(this.pnlBarraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDesignModern";
            this.Text = "Design Moderno";
            this.pnlBarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picButtonRestore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picButtonMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picButtonMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picButtonClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBarraTitulo;
        private System.Windows.Forms.Panel pnlMenuVertical;
        private System.Windows.Forms.PictureBox picButtonClose;
        private System.Windows.Forms.PictureBox picButtonRestore;
        private System.Windows.Forms.PictureBox picButtonMinimize;
        private System.Windows.Forms.PictureBox picButtonMaximize;
        private System.Windows.Forms.Panel pnlKontenedor;
    }
}

