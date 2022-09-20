namespace ExamploCrudVeterinary.Views
{
    partial class frmMainPetView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainPetView));
            this.pnlTitleBar = new System.Windows.Forms.Panel();
            this.pnlVerticalMenu = new System.Windows.Forms.Panel();
            this.btnPetsScreen = new System.Windows.Forms.Button();
            this.pnlBorderLeftPets = new System.Windows.Forms.Panel();
            this.picPetVetLogo = new System.Windows.Forms.PictureBox();
            this.pnlVerticalMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPetVetLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTitleBar
            // 
            this.pnlTitleBar.BackColor = System.Drawing.Color.DarkOrange;
            this.pnlTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitleBar.Location = new System.Drawing.Point(0, 0);
            this.pnlTitleBar.Name = "pnlTitleBar";
            this.pnlTitleBar.Size = new System.Drawing.Size(800, 32);
            this.pnlTitleBar.TabIndex = 1;
            // 
            // pnlVerticalMenu
            // 
            this.pnlVerticalMenu.BackColor = System.Drawing.Color.White;
            this.pnlVerticalMenu.Controls.Add(this.btnPetsScreen);
            this.pnlVerticalMenu.Controls.Add(this.pnlBorderLeftPets);
            this.pnlVerticalMenu.Controls.Add(this.picPetVetLogo);
            this.pnlVerticalMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlVerticalMenu.Location = new System.Drawing.Point(0, 32);
            this.pnlVerticalMenu.Name = "pnlVerticalMenu";
            this.pnlVerticalMenu.Size = new System.Drawing.Size(160, 418);
            this.pnlVerticalMenu.TabIndex = 2;
            // 
            // btnPetsScreen
            // 
            this.btnPetsScreen.FlatAppearance.BorderSize = 0;
            this.btnPetsScreen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.btnPetsScreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPetsScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPetsScreen.Image = ((System.Drawing.Image)(resources.GetObject("btnPetsScreen.Image")));
            this.btnPetsScreen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPetsScreen.Location = new System.Drawing.Point(4, 152);
            this.btnPetsScreen.Name = "btnPetsScreen";
            this.btnPetsScreen.Size = new System.Drawing.Size(156, 32);
            this.btnPetsScreen.TabIndex = 2;
            this.btnPetsScreen.Text = "Pets";
            this.btnPetsScreen.UseVisualStyleBackColor = true;
            // 
            // pnlBorderLeftPets
            // 
            this.pnlBorderLeftPets.BackColor = System.Drawing.Color.DarkOrange;
            this.pnlBorderLeftPets.Location = new System.Drawing.Point(1, 152);
            this.pnlBorderLeftPets.Name = "pnlBorderLeftPets";
            this.pnlBorderLeftPets.Size = new System.Drawing.Size(5, 32);
            this.pnlBorderLeftPets.TabIndex = 1;
            // 
            // picPetVetLogo
            // 
            this.picPetVetLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picPetVetLogo.BackgroundImage")));
            this.picPetVetLogo.Image = ((System.Drawing.Image)(resources.GetObject("picPetVetLogo.Image")));
            this.picPetVetLogo.Location = new System.Drawing.Point(0, 0);
            this.picPetVetLogo.Name = "picPetVetLogo";
            this.picPetVetLogo.Size = new System.Drawing.Size(160, 120);
            this.picPetVetLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPetVetLogo.TabIndex = 0;
            this.picPetVetLogo.TabStop = false;
            // 
            // frmMainPetView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlVerticalMenu);
            this.Controls.Add(this.pnlTitleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.IsMdiContainer = true;
            this.Name = "frmMainPetView";
            this.Text = "frmMainPetView";
            this.pnlVerticalMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picPetVetLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlTitleBar;
        private System.Windows.Forms.Panel pnlVerticalMenu;
        private System.Windows.Forms.PictureBox picPetVetLogo;
        private System.Windows.Forms.Panel pnlBorderLeftPets;
        private System.Windows.Forms.Button btnPetsScreen;
    }
}