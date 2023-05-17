namespace FlatLoginWatermark
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.txtLoginUser = new System.Windows.Forms.TextBox();
            this.txtLoginPassword = new System.Windows.Forms.TextBox();
            this.lblLoginTitle = new System.Windows.Forms.Label();
            this.btnLoginAccess = new System.Windows.Forms.Button();
            this.lnkbtnForgotPassword = new System.Windows.Forms.LinkLabel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.pnlLogo.Controls.Add(this.picLogo);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(250, 330);
            this.pnlLogo.TabIndex = 0;
            this.pnlLogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlLogo_MouseDown);
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(75, 111);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(115, 91);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // txtLoginUser
            // 
            this.txtLoginUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtLoginUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLoginUser.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoginUser.ForeColor = System.Drawing.Color.DimGray;
            this.txtLoginUser.Location = new System.Drawing.Point(323, 64);
            this.txtLoginUser.Name = "txtLoginUser";
            this.txtLoginUser.Size = new System.Drawing.Size(408, 27);
            this.txtLoginUser.TabIndex = 1;
            this.txtLoginUser.Text = "DIGITE SEU USUÁRIO";
            this.txtLoginUser.Enter += new System.EventHandler(this.txtLoginUser_Enter);
            this.txtLoginUser.Leave += new System.EventHandler(this.txtLoginUser_Leave);
            // 
            // txtLoginPassword
            // 
            this.txtLoginPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.txtLoginPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLoginPassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoginPassword.ForeColor = System.Drawing.Color.DimGray;
            this.txtLoginPassword.Location = new System.Drawing.Point(323, 132);
            this.txtLoginPassword.Name = "txtLoginPassword";
            this.txtLoginPassword.Size = new System.Drawing.Size(408, 27);
            this.txtLoginPassword.TabIndex = 2;
            this.txtLoginPassword.Text = "DIGITE SUA SENHA";
            this.txtLoginPassword.Enter += new System.EventHandler(this.txtLoginPassword_Enter);
            this.txtLoginPassword.Leave += new System.EventHandler(this.txtLoginPassword_Leave);
            // 
            // lblLoginTitle
            // 
            this.lblLoginTitle.AutoSize = true;
            this.lblLoginTitle.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginTitle.ForeColor = System.Drawing.Color.DarkGray;
            this.lblLoginTitle.Location = new System.Drawing.Point(480, 0);
            this.lblLoginTitle.Name = "lblLoginTitle";
            this.lblLoginTitle.Size = new System.Drawing.Size(100, 33);
            this.lblLoginTitle.TabIndex = 9;
            this.lblLoginTitle.Text = "LOGIN";
            // 
            // btnLoginAccess
            // 
            this.btnLoginAccess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnLoginAccess.FlatAppearance.BorderSize = 0;
            this.btnLoginAccess.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnLoginAccess.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLoginAccess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoginAccess.ForeColor = System.Drawing.Color.LightGray;
            this.btnLoginAccess.Location = new System.Drawing.Point(323, 229);
            this.btnLoginAccess.Name = "btnLoginAccess";
            this.btnLoginAccess.Size = new System.Drawing.Size(408, 40);
            this.btnLoginAccess.TabIndex = 3;
            this.btnLoginAccess.Text = "ACESSAR";
            this.btnLoginAccess.UseVisualStyleBackColor = false;
            // 
            // lnkbtnForgotPassword
            // 
            this.lnkbtnForgotPassword.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lnkbtnForgotPassword.AutoSize = true;
            this.lnkbtnForgotPassword.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkbtnForgotPassword.LinkColor = System.Drawing.Color.DimGray;
            this.lnkbtnForgotPassword.Location = new System.Drawing.Point(472, 287);
            this.lnkbtnForgotPassword.Name = "lnkbtnForgotPassword";
            this.lnkbtnForgotPassword.Size = new System.Drawing.Size(132, 17);
            this.lnkbtnForgotPassword.TabIndex = 0;
            this.lnkbtnForgotPassword.TabStop = true;
            this.lnkbtnForgotPassword.Text = "Esqueceu a senha?";
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(736, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(32, 33);
            this.btnClose.TabIndex = 12;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.Location = new System.Drawing.Point(698, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(33, 30);
            this.btnMinimize.TabIndex = 13;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(780, 330);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lnkbtnForgotPassword);
            this.Controls.Add(this.btnLoginAccess);
            this.Controls.Add(this.lblLoginTitle);
            this.Controls.Add(this.txtLoginPassword);
            this.Controls.Add(this.txtLoginUser);
            this.Controls.Add(this.pnlLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLogin";
            this.Opacity = 0.9D;
            this.Text = "Form Login";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormLogin_MouseDown);
            this.pnlLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.TextBox txtLoginUser;
        private System.Windows.Forms.TextBox txtLoginPassword;
        private System.Windows.Forms.Label lblLoginTitle;
        private System.Windows.Forms.Button btnLoginAccess;
        private System.Windows.Forms.LinkLabel lnkbtnForgotPassword;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.PictureBox picLogo;
    }
}

