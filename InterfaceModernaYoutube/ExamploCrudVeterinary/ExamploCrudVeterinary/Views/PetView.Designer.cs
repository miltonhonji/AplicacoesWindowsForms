namespace ExamploCrudVeterinary.Views
{
    partial class frmPetView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPetView));
            this.lblPetsTitle = new System.Windows.Forms.Label();
            this.pnlTitleTop = new System.Windows.Forms.Panel();
            this.picLogoImage = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.tabPetsOptions = new System.Windows.Forms.TabControl();
            this.tpPetList = new System.Windows.Forms.TabPage();
            this.btnDeletePet = new System.Windows.Forms.Button();
            this.btnEditPet = new System.Windows.Forms.Button();
            this.btnAddNewPet = new System.Windows.Forms.Button();
            this.dgvPetsList = new System.Windows.Forms.DataGridView();
            this.btnSearchPet = new System.Windows.Forms.Button();
            this.txtSearchPet = new System.Windows.Forms.TextBox();
            this.lblSearchPet = new System.Windows.Forms.Label();
            this.tpPetDetail = new System.Windows.Forms.TabPage();
            this.btnCancelDetail = new System.Windows.Forms.Button();
            this.btnSaveDetail = new System.Windows.Forms.Button();
            this.txtPetType = new System.Windows.Forms.TextBox();
            this.lblPetType = new System.Windows.Forms.Label();
            this.txtPetColour = new System.Windows.Forms.TextBox();
            this.lblPetColour = new System.Windows.Forms.Label();
            this.txtPetName = new System.Windows.Forms.TextBox();
            this.lblPetName = new System.Windows.Forms.Label();
            this.txtPetId = new System.Windows.Forms.TextBox();
            this.lblPetId = new System.Windows.Forms.Label();
            this.pnlTitleTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoImage)).BeginInit();
            this.tabPetsOptions.SuspendLayout();
            this.tpPetList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPetsList)).BeginInit();
            this.tpPetDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPetsTitle
            // 
            this.lblPetsTitle.AutoSize = true;
            this.lblPetsTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPetsTitle.ForeColor = System.Drawing.Color.White;
            this.lblPetsTitle.Location = new System.Drawing.Point(53, 17);
            this.lblPetsTitle.Name = "lblPetsTitle";
            this.lblPetsTitle.Size = new System.Drawing.Size(65, 25);
            this.lblPetsTitle.TabIndex = 0;
            this.lblPetsTitle.Text = "PETS";
            // 
            // pnlTitleTop
            // 
            this.pnlTitleTop.BackColor = System.Drawing.Color.DarkOrange;
            this.pnlTitleTop.Controls.Add(this.picLogoImage);
            this.pnlTitleTop.Controls.Add(this.btnClose);
            this.pnlTitleTop.Controls.Add(this.lblPetsTitle);
            this.pnlTitleTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitleTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTitleTop.Name = "pnlTitleTop";
            this.pnlTitleTop.Size = new System.Drawing.Size(876, 56);
            this.pnlTitleTop.TabIndex = 1;
            // 
            // picLogoImage
            // 
            this.picLogoImage.Image = ((System.Drawing.Image)(resources.GetObject("picLogoImage.Image")));
            this.picLogoImage.Location = new System.Drawing.Point(16, 16);
            this.picLogoImage.Name = "picLogoImage";
            this.picLogoImage.Size = new System.Drawing.Size(32, 32);
            this.picLogoImage.TabIndex = 2;
            this.picLogoImage.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.DarkOrange;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(830, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(37, 30);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // tabPetsOptions
            // 
            this.tabPetsOptions.Controls.Add(this.tpPetList);
            this.tabPetsOptions.Controls.Add(this.tpPetDetail);
            this.tabPetsOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPetsOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.tabPetsOptions.Location = new System.Drawing.Point(0, 56);
            this.tabPetsOptions.Name = "tabPetsOptions";
            this.tabPetsOptions.SelectedIndex = 0;
            this.tabPetsOptions.Size = new System.Drawing.Size(876, 372);
            this.tabPetsOptions.TabIndex = 2;
            // 
            // tpPetList
            // 
            this.tpPetList.BackColor = System.Drawing.Color.White;
            this.tpPetList.Controls.Add(this.btnDeletePet);
            this.tpPetList.Controls.Add(this.btnEditPet);
            this.tpPetList.Controls.Add(this.btnAddNewPet);
            this.tpPetList.Controls.Add(this.dgvPetsList);
            this.tpPetList.Controls.Add(this.btnSearchPet);
            this.tpPetList.Controls.Add(this.txtSearchPet);
            this.tpPetList.Controls.Add(this.lblSearchPet);
            this.tpPetList.Location = new System.Drawing.Point(4, 29);
            this.tpPetList.Name = "tpPetList";
            this.tpPetList.Padding = new System.Windows.Forms.Padding(3);
            this.tpPetList.Size = new System.Drawing.Size(868, 339);
            this.tpPetList.TabIndex = 0;
            this.tpPetList.Text = "Pet List";
            // 
            // btnDeletePet
            // 
            this.btnDeletePet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeletePet.BackColor = System.Drawing.Color.Red;
            this.btnDeletePet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletePet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletePet.ForeColor = System.Drawing.Color.White;
            this.btnDeletePet.Location = new System.Drawing.Point(767, 134);
            this.btnDeletePet.Name = "btnDeletePet";
            this.btnDeletePet.Size = new System.Drawing.Size(99, 30);
            this.btnDeletePet.TabIndex = 6;
            this.btnDeletePet.Text = "Delete";
            this.btnDeletePet.UseVisualStyleBackColor = false;
            // 
            // btnEditPet
            // 
            this.btnEditPet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditPet.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnEditPet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditPet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditPet.ForeColor = System.Drawing.Color.White;
            this.btnEditPet.Location = new System.Drawing.Point(767, 98);
            this.btnEditPet.Name = "btnEditPet";
            this.btnEditPet.Size = new System.Drawing.Size(99, 30);
            this.btnEditPet.TabIndex = 5;
            this.btnEditPet.Text = "Edit";
            this.btnEditPet.UseVisualStyleBackColor = false;
            // 
            // btnAddNewPet
            // 
            this.btnAddNewPet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddNewPet.BackColor = System.Drawing.Color.Green;
            this.btnAddNewPet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewPet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewPet.ForeColor = System.Drawing.Color.White;
            this.btnAddNewPet.Location = new System.Drawing.Point(767, 62);
            this.btnAddNewPet.Name = "btnAddNewPet";
            this.btnAddNewPet.Size = new System.Drawing.Size(99, 30);
            this.btnAddNewPet.TabIndex = 4;
            this.btnAddNewPet.Text = "Add New";
            this.btnAddNewPet.UseVisualStyleBackColor = false;
            // 
            // dgvPetsList
            // 
            this.dgvPetsList.AllowUserToAddRows = false;
            this.dgvPetsList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPetsList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPetsList.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvPetsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPetsList.Location = new System.Drawing.Point(24, 63);
            this.dgvPetsList.Name = "dgvPetsList";
            this.dgvPetsList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPetsList.Size = new System.Drawing.Size(737, 273);
            this.dgvPetsList.TabIndex = 3;
            // 
            // btnSearchPet
            // 
            this.btnSearchPet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchPet.BackColor = System.Drawing.Color.Orange;
            this.btnSearchPet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchPet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchPet.ForeColor = System.Drawing.Color.Black;
            this.btnSearchPet.Location = new System.Drawing.Point(668, 30);
            this.btnSearchPet.Name = "btnSearchPet";
            this.btnSearchPet.Size = new System.Drawing.Size(99, 30);
            this.btnSearchPet.TabIndex = 2;
            this.btnSearchPet.Text = "Search";
            this.btnSearchPet.UseVisualStyleBackColor = false;
            // 
            // txtSearchPet
            // 
            this.txtSearchPet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchPet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchPet.Location = new System.Drawing.Point(24, 31);
            this.txtSearchPet.Name = "txtSearchPet";
            this.txtSearchPet.Size = new System.Drawing.Size(638, 26);
            this.txtSearchPet.TabIndex = 1;
            // 
            // lblSearchPet
            // 
            this.lblSearchPet.AutoSize = true;
            this.lblSearchPet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchPet.ForeColor = System.Drawing.Color.Black;
            this.lblSearchPet.Location = new System.Drawing.Point(20, 8);
            this.lblSearchPet.Name = "lblSearchPet";
            this.lblSearchPet.Size = new System.Drawing.Size(92, 20);
            this.lblSearchPet.TabIndex = 0;
            this.lblSearchPet.Text = "Search Pet:";
            // 
            // tpPetDetail
            // 
            this.tpPetDetail.BackColor = System.Drawing.Color.White;
            this.tpPetDetail.Controls.Add(this.btnCancelDetail);
            this.tpPetDetail.Controls.Add(this.btnSaveDetail);
            this.tpPetDetail.Controls.Add(this.txtPetType);
            this.tpPetDetail.Controls.Add(this.lblPetType);
            this.tpPetDetail.Controls.Add(this.txtPetColour);
            this.tpPetDetail.Controls.Add(this.lblPetColour);
            this.tpPetDetail.Controls.Add(this.txtPetName);
            this.tpPetDetail.Controls.Add(this.lblPetName);
            this.tpPetDetail.Controls.Add(this.txtPetId);
            this.tpPetDetail.Controls.Add(this.lblPetId);
            this.tpPetDetail.Location = new System.Drawing.Point(4, 29);
            this.tpPetDetail.Name = "tpPetDetail";
            this.tpPetDetail.Padding = new System.Windows.Forms.Padding(3);
            this.tpPetDetail.Size = new System.Drawing.Size(868, 339);
            this.tpPetDetail.TabIndex = 1;
            this.tpPetDetail.Text = "Pet Detail";
            // 
            // btnCancelDetail
            // 
            this.btnCancelDetail.BackColor = System.Drawing.Color.Red;
            this.btnCancelDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelDetail.ForeColor = System.Drawing.Color.White;
            this.btnCancelDetail.Location = new System.Drawing.Point(260, 247);
            this.btnCancelDetail.Name = "btnCancelDetail";
            this.btnCancelDetail.Size = new System.Drawing.Size(183, 44);
            this.btnCancelDetail.TabIndex = 9;
            this.btnCancelDetail.Text = "Cancel";
            this.btnCancelDetail.UseVisualStyleBackColor = false;
            // 
            // btnSaveDetail
            // 
            this.btnSaveDetail.BackColor = System.Drawing.Color.Green;
            this.btnSaveDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveDetail.ForeColor = System.Drawing.Color.White;
            this.btnSaveDetail.Location = new System.Drawing.Point(63, 247);
            this.btnSaveDetail.Name = "btnSaveDetail";
            this.btnSaveDetail.Size = new System.Drawing.Size(183, 44);
            this.btnSaveDetail.TabIndex = 8;
            this.btnSaveDetail.Text = "Save";
            this.btnSaveDetail.UseVisualStyleBackColor = false;
            // 
            // txtPetType
            // 
            this.txtPetType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPetType.Location = new System.Drawing.Point(260, 125);
            this.txtPetType.Name = "txtPetType";
            this.txtPetType.Size = new System.Drawing.Size(154, 26);
            this.txtPetType.TabIndex = 7;
            // 
            // lblPetType
            // 
            this.lblPetType.AutoSize = true;
            this.lblPetType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPetType.Location = new System.Drawing.Point(256, 102);
            this.lblPetType.Name = "lblPetType";
            this.lblPetType.Size = new System.Drawing.Size(75, 20);
            this.lblPetType.TabIndex = 6;
            this.lblPetType.Text = "Pet Type:";
            // 
            // txtPetColour
            // 
            this.txtPetColour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPetColour.Location = new System.Drawing.Point(63, 198);
            this.txtPetColour.Name = "txtPetColour";
            this.txtPetColour.Size = new System.Drawing.Size(380, 26);
            this.txtPetColour.TabIndex = 5;
            // 
            // lblPetColour
            // 
            this.lblPetColour.AutoSize = true;
            this.lblPetColour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPetColour.Location = new System.Drawing.Point(59, 175);
            this.lblPetColour.Name = "lblPetColour";
            this.lblPetColour.Size = new System.Drawing.Size(87, 20);
            this.lblPetColour.TabIndex = 4;
            this.lblPetColour.Text = "Pet Colour:";
            // 
            // txtPetName
            // 
            this.txtPetName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPetName.Location = new System.Drawing.Point(63, 125);
            this.txtPetName.Name = "txtPetName";
            this.txtPetName.Size = new System.Drawing.Size(154, 26);
            this.txtPetName.TabIndex = 3;
            // 
            // lblPetName
            // 
            this.lblPetName.AutoSize = true;
            this.lblPetName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPetName.Location = new System.Drawing.Point(59, 102);
            this.lblPetName.Name = "lblPetName";
            this.lblPetName.Size = new System.Drawing.Size(83, 20);
            this.lblPetName.TabIndex = 2;
            this.lblPetName.Text = "Pet Name:";
            // 
            // txtPetId
            // 
            this.txtPetId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPetId.Location = new System.Drawing.Point(63, 54);
            this.txtPetId.Name = "txtPetId";
            this.txtPetId.Size = new System.Drawing.Size(154, 26);
            this.txtPetId.TabIndex = 1;
            // 
            // lblPetId
            // 
            this.lblPetId.AutoSize = true;
            this.lblPetId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPetId.Location = new System.Drawing.Point(59, 31);
            this.lblPetId.Name = "lblPetId";
            this.lblPetId.Size = new System.Drawing.Size(55, 20);
            this.lblPetId.TabIndex = 0;
            this.lblPetId.Text = "Pet Id:";
            // 
            // frmPetView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 428);
            this.Controls.Add(this.tabPetsOptions);
            this.Controls.Add(this.pnlTitleTop);
            this.Name = "frmPetView";
            this.Text = "PetView";
            this.pnlTitleTop.ResumeLayout(false);
            this.pnlTitleTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoImage)).EndInit();
            this.tabPetsOptions.ResumeLayout(false);
            this.tpPetList.ResumeLayout(false);
            this.tpPetList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPetsList)).EndInit();
            this.tpPetDetail.ResumeLayout(false);
            this.tpPetDetail.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblPetsTitle;
        private System.Windows.Forms.Panel pnlTitleTop;
        private System.Windows.Forms.TabControl tabPetsOptions;
        private System.Windows.Forms.TabPage tpPetList;
        private System.Windows.Forms.Label lblSearchPet;
        private System.Windows.Forms.TabPage tpPetDetail;
        private System.Windows.Forms.TextBox txtSearchPet;
        private System.Windows.Forms.Button btnSearchPet;
        private System.Windows.Forms.Button btnDeletePet;
        private System.Windows.Forms.Button btnEditPet;
        private System.Windows.Forms.Button btnAddNewPet;
        private System.Windows.Forms.DataGridView dgvPetsList;
        private System.Windows.Forms.Label lblPetId;
        private System.Windows.Forms.TextBox txtPetName;
        private System.Windows.Forms.Label lblPetName;
        private System.Windows.Forms.TextBox txtPetId;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnCancelDetail;
        private System.Windows.Forms.Button btnSaveDetail;
        private System.Windows.Forms.TextBox txtPetType;
        private System.Windows.Forms.Label lblPetType;
        private System.Windows.Forms.TextBox txtPetColour;
        private System.Windows.Forms.Label lblPetColour;
        private System.Windows.Forms.PictureBox picLogoImage;
    }
}