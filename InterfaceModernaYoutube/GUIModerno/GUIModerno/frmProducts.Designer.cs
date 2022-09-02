namespace GUIModerno
{
    partial class frmProducts
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
            this.lblProducts = new System.Windows.Forms.Label();
            this.txtNameProduct = new System.Windows.Forms.TextBox();
            this.lblNameProduct = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblStock = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblProducts
            // 
            this.lblProducts.AutoSize = true;
            this.lblProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducts.ForeColor = System.Drawing.Color.White;
            this.lblProducts.Location = new System.Drawing.Point(493, 32);
            this.lblProducts.Name = "lblProducts";
            this.lblProducts.Size = new System.Drawing.Size(136, 26);
            this.lblProducts.TabIndex = 0;
            this.lblProducts.Text = "PRODUTOS";
            // 
            // txtNameProduct
            // 
            this.txtNameProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameProduct.Location = new System.Drawing.Point(401, 73);
            this.txtNameProduct.Name = "txtNameProduct";
            this.txtNameProduct.Size = new System.Drawing.Size(311, 24);
            this.txtNameProduct.TabIndex = 1;
            // 
            // lblNameProduct
            // 
            this.lblNameProduct.AutoSize = true;
            this.lblNameProduct.ForeColor = System.Drawing.Color.White;
            this.lblNameProduct.Location = new System.Drawing.Point(358, 73);
            this.lblNameProduct.Name = "lblNameProduct";
            this.lblNameProduct.Size = new System.Drawing.Size(38, 13);
            this.lblNameProduct.TabIndex = 2;
            this.lblNameProduct.Text = "Nome:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.ForeColor = System.Drawing.Color.White;
            this.lblPrice.Location = new System.Drawing.Point(357, 103);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(38, 13);
            this.lblPrice.TabIndex = 4;
            this.lblPrice.Text = "Preço:";
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(401, 103);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(311, 24);
            this.txtPrice.TabIndex = 3;
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.ForeColor = System.Drawing.Color.White;
            this.lblStock.Location = new System.Drawing.Point(347, 135);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(49, 13);
            this.lblStock.TabIndex = 6;
            this.lblStock.Text = "Estoque:";
            // 
            // txtStock
            // 
            this.txtStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStock.Location = new System.Drawing.Point(401, 133);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(311, 24);
            this.txtStock.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SeaGreen;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(436, 176);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(205, 38);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // frmProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1080, 612);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lblNameProduct);
            this.Controls.Add(this.txtNameProduct);
            this.Controls.Add(this.lblProducts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmProducts";
            this.Text = "Produtos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProducts;
        private System.Windows.Forms.TextBox txtNameProduct;
        private System.Windows.Forms.Label lblNameProduct;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Button button1;
    }
}