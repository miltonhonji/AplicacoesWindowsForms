namespace GUIModerno
{
    partial class frmStart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStart));
            this.picProductNotebook = new System.Windows.Forms.PictureBox();
            this.picCompanyLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picProductNotebook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCompanyLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // picProductNotebook
            // 
            this.picProductNotebook.Image = ((System.Drawing.Image)(resources.GetObject("picProductNotebook.Image")));
            this.picProductNotebook.Location = new System.Drawing.Point(415, 247);
            this.picProductNotebook.Name = "picProductNotebook";
            this.picProductNotebook.Size = new System.Drawing.Size(159, 125);
            this.picProductNotebook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picProductNotebook.TabIndex = 0;
            this.picProductNotebook.TabStop = false;
            // 
            // picCompanyLogo
            // 
            this.picCompanyLogo.Image = ((System.Drawing.Image)(resources.GetObject("picCompanyLogo.Image")));
            this.picCompanyLogo.Location = new System.Drawing.Point(31, 12);
            this.picCompanyLogo.Name = "picCompanyLogo";
            this.picCompanyLogo.Size = new System.Drawing.Size(543, 229);
            this.picCompanyLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCompanyLogo.TabIndex = 1;
            this.picCompanyLogo.TabStop = false;
            // 
            // frmStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1080, 612);
            this.Controls.Add(this.picCompanyLogo);
            this.Controls.Add(this.picProductNotebook);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmStart";
            this.Text = "Início";
            ((System.ComponentModel.ISupportInitialize)(this.picProductNotebook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCompanyLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picProductNotebook;
        private System.Windows.Forms.PictureBox picCompanyLogo;
    }
}