namespace Activity7_1
{
    partial class frmTeller
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
            this.btnGetBalance = new System.Windows.Forms.Button();
            this.pnlAccountOptions = new System.Windows.Forms.Panel();
            this.rdbGeneral = new System.Windows.Forms.RadioButton();
            this.rdbSavings = new System.Windows.Forms.RadioButton();
            this.rdbChecking = new System.Windows.Forms.RadioButton();
            this.lblAccountNumber = new System.Windows.Forms.Label();
            this.txtAccountNumber = new System.Windows.Forms.TextBox();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.lblBalance = new System.Windows.Forms.Label();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.pnlAccountOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGetBalance
            // 
            this.btnGetBalance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetBalance.Location = new System.Drawing.Point(229, 9);
            this.btnGetBalance.Name = "btnGetBalance";
            this.btnGetBalance.Size = new System.Drawing.Size(101, 35);
            this.btnGetBalance.TabIndex = 7;
            this.btnGetBalance.Text = "Get Balance";
            this.btnGetBalance.UseVisualStyleBackColor = true;
            this.btnGetBalance.Click += new System.EventHandler(this.btnGetBalance_Click);
            // 
            // pnlAccountOptions
            // 
            this.pnlAccountOptions.Controls.Add(this.rdbGeneral);
            this.pnlAccountOptions.Controls.Add(this.rdbSavings);
            this.pnlAccountOptions.Controls.Add(this.rdbChecking);
            this.pnlAccountOptions.Location = new System.Drawing.Point(12, 96);
            this.pnlAccountOptions.Name = "pnlAccountOptions";
            this.pnlAccountOptions.Size = new System.Drawing.Size(182, 86);
            this.pnlAccountOptions.TabIndex = 1;
            // 
            // rdbGeneral
            // 
            this.rdbGeneral.AutoSize = true;
            this.rdbGeneral.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdbGeneral.Location = new System.Drawing.Point(16, 58);
            this.rdbGeneral.Name = "rdbGeneral";
            this.rdbGeneral.Size = new System.Drawing.Size(104, 17);
            this.rdbGeneral.TabIndex = 10;
            this.rdbGeneral.TabStop = true;
            this.rdbGeneral.Text = "General Account";
            this.rdbGeneral.UseVisualStyleBackColor = true;
            // 
            // rdbSavings
            // 
            this.rdbSavings.AutoSize = true;
            this.rdbSavings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdbSavings.Location = new System.Drawing.Point(15, 35);
            this.rdbSavings.Name = "rdbSavings";
            this.rdbSavings.Size = new System.Drawing.Size(105, 17);
            this.rdbSavings.TabIndex = 9;
            this.rdbSavings.TabStop = true;
            this.rdbSavings.Text = "Savings Account";
            this.rdbSavings.UseVisualStyleBackColor = true;
            // 
            // rdbChecking
            // 
            this.rdbChecking.AutoSize = true;
            this.rdbChecking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdbChecking.Location = new System.Drawing.Point(15, 12);
            this.rdbChecking.Name = "rdbChecking";
            this.rdbChecking.Size = new System.Drawing.Size(112, 17);
            this.rdbChecking.TabIndex = 8;
            this.rdbChecking.TabStop = true;
            this.rdbChecking.Text = "Checking Account";
            this.rdbChecking.UseVisualStyleBackColor = true;
            // 
            // lblAccountNumber
            // 
            this.lblAccountNumber.AutoSize = true;
            this.lblAccountNumber.Location = new System.Drawing.Point(12, 11);
            this.lblAccountNumber.Name = "lblAccountNumber";
            this.lblAccountNumber.Size = new System.Drawing.Size(90, 13);
            this.lblAccountNumber.TabIndex = 0;
            this.lblAccountNumber.Text = "Account Number:";
            // 
            // txtAccountNumber
            // 
            this.txtAccountNumber.Location = new System.Drawing.Point(104, 9);
            this.txtAccountNumber.Name = "txtAccountNumber";
            this.txtAccountNumber.Size = new System.Drawing.Size(90, 20);
            this.txtAccountNumber.TabIndex = 1;
            // 
            // txtBalance
            // 
            this.txtBalance.Location = new System.Drawing.Point(104, 63);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(90, 20);
            this.txtBalance.TabIndex = 5;
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Location = new System.Drawing.Point(50, 66);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(49, 13);
            this.lblBalance.TabIndex = 4;
            this.lblBalance.Text = "Balance:";
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWithdraw.Location = new System.Drawing.Point(229, 55);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(101, 35);
            this.btnWithdraw.TabIndex = 6;
            this.btnWithdraw.Text = "Withdraw";
            this.btnWithdraw.UseVisualStyleBackColor = true;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(104, 36);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(90, 20);
            this.txtAmount.TabIndex = 3;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(50, 39);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(46, 13);
            this.lblAmount.TabIndex = 2;
            this.lblAmount.Text = "Amount:";
            // 
            // frmTeller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 188);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.btnWithdraw);
            this.Controls.Add(this.txtBalance);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.txtAccountNumber);
            this.Controls.Add(this.lblAccountNumber);
            this.Controls.Add(this.pnlAccountOptions);
            this.Controls.Add(this.btnGetBalance);
            this.Name = "frmTeller";
            this.Text = "Teller";
            this.pnlAccountOptions.ResumeLayout(false);
            this.pnlAccountOptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetBalance;
        private System.Windows.Forms.Panel pnlAccountOptions;
        private System.Windows.Forms.RadioButton rdbChecking;
        private System.Windows.Forms.RadioButton rdbGeneral;
        private System.Windows.Forms.RadioButton rdbSavings;
        private System.Windows.Forms.Label lblAccountNumber;
        private System.Windows.Forms.TextBox txtAccountNumber;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label lblAmount;
    }
}

