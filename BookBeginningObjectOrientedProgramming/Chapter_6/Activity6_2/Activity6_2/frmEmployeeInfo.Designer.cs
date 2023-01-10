namespace Activity6_2
{
    partial class frmEmployeeInfo
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
            this.btnNewEmployee = new System.Windows.Forms.Button();
            this.lblEmployeeId = new System.Windows.Forms.Label();
            this.txtEmployeeId = new System.Windows.Forms.TextBox();
            this.txtEmployeeLoginName = new System.Windows.Forms.TextBox();
            this.lblEmployeeLoginName = new System.Windows.Forms.Label();
            this.txtEmployeePassword = new System.Windows.Forms.TextBox();
            this.lblEmployeePassword = new System.Windows.Forms.Label();
            this.txtEmployeeSsn = new System.Windows.Forms.TextBox();
            this.lblEmployeeSsn = new System.Windows.Forms.Label();
            this.txtEmployeeDepartment = new System.Windows.Forms.TextBox();
            this.lblEmployeeDepartment = new System.Windows.Forms.Label();
            this.btnExistingEmployee = new System.Windows.Forms.Button();
            this.btnResetEmployeeId = new System.Windows.Forms.Button();
            this.btnEmployeeUpdateInformationSecurity = new System.Windows.Forms.Button();
            this.btnEmployeeUpdateHumanResource = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNewEmployee
            // 
            this.btnNewEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewEmployee.Location = new System.Drawing.Point(234, 13);
            this.btnNewEmployee.Name = "btnNewEmployee";
            this.btnNewEmployee.Size = new System.Drawing.Size(123, 33);
            this.btnNewEmployee.TabIndex = 0;
            this.btnNewEmployee.Text = "New Employee";
            this.btnNewEmployee.UseVisualStyleBackColor = true;
            this.btnNewEmployee.Click += new System.EventHandler(this.btnNewEmployee_Click);
            // 
            // lblEmployeeId
            // 
            this.lblEmployeeId.AutoSize = true;
            this.lblEmployeeId.Location = new System.Drawing.Point(17, 20);
            this.lblEmployeeId.Name = "lblEmployeeId";
            this.lblEmployeeId.Size = new System.Drawing.Size(71, 13);
            this.lblEmployeeId.TabIndex = 1;
            this.lblEmployeeId.Text = "Id Employee: ";
            // 
            // txtEmployeeId
            // 
            this.txtEmployeeId.Location = new System.Drawing.Point(94, 17);
            this.txtEmployeeId.Name = "txtEmployeeId";
            this.txtEmployeeId.Size = new System.Drawing.Size(101, 20);
            this.txtEmployeeId.TabIndex = 2;
            // 
            // txtEmployeeLoginName
            // 
            this.txtEmployeeLoginName.Location = new System.Drawing.Point(94, 48);
            this.txtEmployeeLoginName.Name = "txtEmployeeLoginName";
            this.txtEmployeeLoginName.Size = new System.Drawing.Size(101, 20);
            this.txtEmployeeLoginName.TabIndex = 4;
            // 
            // lblEmployeeLoginName
            // 
            this.lblEmployeeLoginName.AutoSize = true;
            this.lblEmployeeLoginName.Location = new System.Drawing.Point(17, 51);
            this.lblEmployeeLoginName.Name = "lblEmployeeLoginName";
            this.lblEmployeeLoginName.Size = new System.Drawing.Size(70, 13);
            this.lblEmployeeLoginName.TabIndex = 3;
            this.lblEmployeeLoginName.Text = "Login Name: ";
            // 
            // txtEmployeePassword
            // 
            this.txtEmployeePassword.Location = new System.Drawing.Point(94, 78);
            this.txtEmployeePassword.Name = "txtEmployeePassword";
            this.txtEmployeePassword.Size = new System.Drawing.Size(101, 20);
            this.txtEmployeePassword.TabIndex = 6;
            // 
            // lblEmployeePassword
            // 
            this.lblEmployeePassword.AutoSize = true;
            this.lblEmployeePassword.Location = new System.Drawing.Point(26, 81);
            this.lblEmployeePassword.Name = "lblEmployeePassword";
            this.lblEmployeePassword.Size = new System.Drawing.Size(59, 13);
            this.lblEmployeePassword.TabIndex = 5;
            this.lblEmployeePassword.Text = "Password: ";
            // 
            // txtEmployeeSsn
            // 
            this.txtEmployeeSsn.Location = new System.Drawing.Point(94, 107);
            this.txtEmployeeSsn.Name = "txtEmployeeSsn";
            this.txtEmployeeSsn.Size = new System.Drawing.Size(101, 20);
            this.txtEmployeeSsn.TabIndex = 8;
            // 
            // lblEmployeeSsn
            // 
            this.lblEmployeeSsn.AutoSize = true;
            this.lblEmployeeSsn.Location = new System.Drawing.Point(48, 110);
            this.lblEmployeeSsn.Name = "lblEmployeeSsn";
            this.lblEmployeeSsn.Size = new System.Drawing.Size(35, 13);
            this.lblEmployeeSsn.TabIndex = 7;
            this.lblEmployeeSsn.Text = "SSN: ";
            // 
            // txtEmployeeDepartment
            // 
            this.txtEmployeeDepartment.Location = new System.Drawing.Point(94, 136);
            this.txtEmployeeDepartment.Name = "txtEmployeeDepartment";
            this.txtEmployeeDepartment.Size = new System.Drawing.Size(101, 20);
            this.txtEmployeeDepartment.TabIndex = 10;
            // 
            // lblEmployeeDepartment
            // 
            this.lblEmployeeDepartment.AutoSize = true;
            this.lblEmployeeDepartment.Location = new System.Drawing.Point(10, 139);
            this.lblEmployeeDepartment.Name = "lblEmployeeDepartment";
            this.lblEmployeeDepartment.Size = new System.Drawing.Size(74, 13);
            this.lblEmployeeDepartment.TabIndex = 9;
            this.lblEmployeeDepartment.Text = "Departament: ";
            // 
            // btnExistingEmployee
            // 
            this.btnExistingEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExistingEmployee.Location = new System.Drawing.Point(234, 51);
            this.btnExistingEmployee.Name = "btnExistingEmployee";
            this.btnExistingEmployee.Size = new System.Drawing.Size(123, 33);
            this.btnExistingEmployee.TabIndex = 11;
            this.btnExistingEmployee.Text = "Existing Employee";
            this.btnExistingEmployee.UseVisualStyleBackColor = true;
            this.btnExistingEmployee.Click += new System.EventHandler(this.btnExistingEmployee_Click);
            // 
            // btnResetEmployeeId
            // 
            this.btnResetEmployeeId.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetEmployeeId.Location = new System.Drawing.Point(234, 90);
            this.btnResetEmployeeId.Name = "btnResetEmployeeId";
            this.btnResetEmployeeId.Size = new System.Drawing.Size(123, 33);
            this.btnResetEmployeeId.TabIndex = 12;
            this.btnResetEmployeeId.Text = "Reset Employee ID";
            this.btnResetEmployeeId.UseVisualStyleBackColor = true;
            this.btnResetEmployeeId.Click += new System.EventHandler(this.btnResetEmployeeId_Click);
            // 
            // btnEmployeeUpdateInformationSecurity
            // 
            this.btnEmployeeUpdateInformationSecurity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployeeUpdateInformationSecurity.Location = new System.Drawing.Point(234, 129);
            this.btnEmployeeUpdateInformationSecurity.Name = "btnEmployeeUpdateInformationSecurity";
            this.btnEmployeeUpdateInformationSecurity.Size = new System.Drawing.Size(123, 33);
            this.btnEmployeeUpdateInformationSecurity.TabIndex = 13;
            this.btnEmployeeUpdateInformationSecurity.Text = "Update Employee IS";
            this.btnEmployeeUpdateInformationSecurity.UseVisualStyleBackColor = true;
            this.btnEmployeeUpdateInformationSecurity.Click += new System.EventHandler(this.btnEmployeeUpdateInformationSecurity_Click);
            // 
            // btnEmployeeUpdateHumanResource
            // 
            this.btnEmployeeUpdateHumanResource.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployeeUpdateHumanResource.Location = new System.Drawing.Point(234, 168);
            this.btnEmployeeUpdateHumanResource.Name = "btnEmployeeUpdateHumanResource";
            this.btnEmployeeUpdateHumanResource.Size = new System.Drawing.Size(123, 33);
            this.btnEmployeeUpdateHumanResource.TabIndex = 14;
            this.btnEmployeeUpdateHumanResource.Text = "Update Employee HR";
            this.btnEmployeeUpdateHumanResource.UseVisualStyleBackColor = true;
            this.btnEmployeeUpdateHumanResource.Click += new System.EventHandler(this.btnEmployeeUpdateHumanResource_Click);
            // 
            // frmEmployeeInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 209);
            this.Controls.Add(this.btnEmployeeUpdateHumanResource);
            this.Controls.Add(this.btnEmployeeUpdateInformationSecurity);
            this.Controls.Add(this.btnResetEmployeeId);
            this.Controls.Add(this.btnExistingEmployee);
            this.Controls.Add(this.txtEmployeeDepartment);
            this.Controls.Add(this.lblEmployeeDepartment);
            this.Controls.Add(this.txtEmployeeSsn);
            this.Controls.Add(this.lblEmployeeSsn);
            this.Controls.Add(this.txtEmployeePassword);
            this.Controls.Add(this.lblEmployeePassword);
            this.Controls.Add(this.txtEmployeeLoginName);
            this.Controls.Add(this.lblEmployeeLoginName);
            this.Controls.Add(this.txtEmployeeId);
            this.Controls.Add(this.lblEmployeeId);
            this.Controls.Add(this.btnNewEmployee);
            this.Name = "frmEmployeeInfo";
            this.Text = "frmEmployeeInfo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNewEmployee;
        private System.Windows.Forms.Label lblEmployeeId;
        private System.Windows.Forms.TextBox txtEmployeeId;
        private System.Windows.Forms.TextBox txtEmployeeLoginName;
        private System.Windows.Forms.Label lblEmployeeLoginName;
        private System.Windows.Forms.TextBox txtEmployeePassword;
        private System.Windows.Forms.Label lblEmployeePassword;
        private System.Windows.Forms.TextBox txtEmployeeSsn;
        private System.Windows.Forms.Label lblEmployeeSsn;
        private System.Windows.Forms.TextBox txtEmployeeDepartment;
        private System.Windows.Forms.Label lblEmployeeDepartment;
        private System.Windows.Forms.Button btnExistingEmployee;
        private System.Windows.Forms.Button btnResetEmployeeId;
        private System.Windows.Forms.Button btnEmployeeUpdateInformationSecurity;
        private System.Windows.Forms.Button btnEmployeeUpdateHumanResource;
    }
}