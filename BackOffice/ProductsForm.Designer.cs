namespace BackOffice
{
    partial class ProductsForm
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
            this.dataGridViewProducts = new System.Windows.Forms.DataGridView();
            this.buttonAddProduct = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.txtBoxWeight = new System.Windows.Forms.TextBox();
            this.txtBoxActive = new System.Windows.Forms.TextBox();
            this.txtBoxCustomer = new System.Windows.Forms.TextBox();
            this.labelProductWeight = new System.Windows.Forms.Label();
            this.labelActived = new System.Windows.Forms.Label();
            this.labelCustomer = new System.Windows.Forms.Label();
            this.labelProductVolume = new System.Windows.Forms.Label();
            this.txtBoxVolume = new System.Windows.Forms.TextBox();
            this.labelProductStreet = new System.Windows.Forms.Label();
            this.txtBoxStreet = new System.Windows.Forms.TextBox();
            this.labelDoorNumber = new System.Windows.Forms.Label();
            this.txtBoxDoorNumber = new System.Windows.Forms.TextBox();
            this.labelProductCorner = new System.Windows.Forms.Label();
            this.txtBoxCorner = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewProducts
            // 
            this.dataGridViewProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewProducts.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(47)))), ((int)(((byte)(68)))));
            this.dataGridViewProducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProducts.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridViewProducts.Location = new System.Drawing.Point(12, 44);
            this.dataGridViewProducts.Name = "dataGridViewProducts";
            this.dataGridViewProducts.Size = new System.Drawing.Size(480, 503);
            this.dataGridViewProducts.TabIndex = 0;
            this.dataGridViewProducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProducts_CellContentClick);
            // 
            // buttonAddProduct
            // 
            this.buttonAddProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddProduct.Location = new System.Drawing.Point(498, 492);
            this.buttonAddProduct.Name = "buttonAddProduct";
            this.buttonAddProduct.Size = new System.Drawing.Size(68, 26);
            this.buttonAddProduct.TabIndex = 1;
            this.buttonAddProduct.Text = "Agregar";
            this.buttonAddProduct.UseVisualStyleBackColor = true;
            this.buttonAddProduct.Click += new System.EventHandler(this.buttonAddProduct_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDelete.Location = new System.Drawing.Point(594, 492);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(68, 26);
            this.buttonDelete.TabIndex = 2;
            this.buttonDelete.Text = "Eliminar";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRefresh.Location = new System.Drawing.Point(690, 492);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(68, 26);
            this.buttonRefresh.TabIndex = 3;
            this.buttonRefresh.Text = "Recargar";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBack.Location = new System.Drawing.Point(12, 12);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(96, 26);
            this.buttonBack.TabIndex = 4;
            this.buttonBack.Text = "Volver";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // txtBoxWeight
            // 
            this.txtBoxWeight.Location = new System.Drawing.Point(498, 145);
            this.txtBoxWeight.Name = "txtBoxWeight";
            this.txtBoxWeight.Size = new System.Drawing.Size(253, 20);
            this.txtBoxWeight.TabIndex = 6;
            // 
            // txtBoxActive
            // 
            this.txtBoxActive.Location = new System.Drawing.Point(498, 409);
            this.txtBoxActive.Name = "txtBoxActive";
            this.txtBoxActive.Size = new System.Drawing.Size(37, 20);
            this.txtBoxActive.TabIndex = 7;
            // 
            // txtBoxCustomer
            // 
            this.txtBoxCustomer.Location = new System.Drawing.Point(498, 453);
            this.txtBoxCustomer.Name = "txtBoxCustomer";
            this.txtBoxCustomer.Size = new System.Drawing.Size(253, 20);
            this.txtBoxCustomer.TabIndex = 8;
            // 
            // labelProductWeight
            // 
            this.labelProductWeight.AutoSize = true;
            this.labelProductWeight.Location = new System.Drawing.Point(495, 129);
            this.labelProductWeight.Name = "labelProductWeight";
            this.labelProductWeight.Size = new System.Drawing.Size(94, 13);
            this.labelProductWeight.TabIndex = 10;
            this.labelProductWeight.Text = "Peso de producto:";
            // 
            // labelActived
            // 
            this.labelActived.AutoSize = true;
            this.labelActived.Location = new System.Drawing.Point(498, 393);
            this.labelActived.Name = "labelActived";
            this.labelActived.Size = new System.Drawing.Size(122, 13);
            this.labelActived.TabIndex = 11;
            this.labelActived.Text = "Activo (1) - No activo (0)";
            // 
            // labelCustomer
            // 
            this.labelCustomer.AutoSize = true;
            this.labelCustomer.Location = new System.Drawing.Point(498, 437);
            this.labelCustomer.Name = "labelCustomer";
            this.labelCustomer.Size = new System.Drawing.Size(42, 13);
            this.labelCustomer.TabIndex = 12;
            this.labelCustomer.Text = "Cliente:";
            // 
            // labelProductVolume
            // 
            this.labelProductVolume.AutoSize = true;
            this.labelProductVolume.Location = new System.Drawing.Point(495, 180);
            this.labelProductVolume.Name = "labelProductVolume";
            this.labelProductVolume.Size = new System.Drawing.Size(111, 13);
            this.labelProductVolume.TabIndex = 15;
            this.labelProductVolume.Text = "Volumen de producto:";
            // 
            // txtBoxVolume
            // 
            this.txtBoxVolume.Location = new System.Drawing.Point(498, 196);
            this.txtBoxVolume.Name = "txtBoxVolume";
            this.txtBoxVolume.Size = new System.Drawing.Size(253, 20);
            this.txtBoxVolume.TabIndex = 14;
            // 
            // labelProductStreet
            // 
            this.labelProductStreet.AutoSize = true;
            this.labelProductStreet.Location = new System.Drawing.Point(495, 230);
            this.labelProductStreet.Name = "labelProductStreet";
            this.labelProductStreet.Size = new System.Drawing.Size(68, 13);
            this.labelProductStreet.TabIndex = 17;
            this.labelProductStreet.Text = "Calle (envio):";
            // 
            // txtBoxStreet
            // 
            this.txtBoxStreet.Location = new System.Drawing.Point(498, 246);
            this.txtBoxStreet.Name = "txtBoxStreet";
            this.txtBoxStreet.Size = new System.Drawing.Size(253, 20);
            this.txtBoxStreet.TabIndex = 16;
            // 
            // labelDoorNumber
            // 
            this.labelDoorNumber.AutoSize = true;
            this.labelDoorNumber.Location = new System.Drawing.Point(495, 339);
            this.labelDoorNumber.Name = "labelDoorNumber";
            this.labelDoorNumber.Size = new System.Drawing.Size(124, 13);
            this.labelDoorNumber.TabIndex = 19;
            this.labelDoorNumber.Text = "Numero de puerta(envio)";
            // 
            // txtBoxDoorNumber
            // 
            this.txtBoxDoorNumber.Location = new System.Drawing.Point(498, 355);
            this.txtBoxDoorNumber.Name = "txtBoxDoorNumber";
            this.txtBoxDoorNumber.Size = new System.Drawing.Size(37, 20);
            this.txtBoxDoorNumber.TabIndex = 18;
            // 
            // labelProductCorner
            // 
            this.labelProductCorner.AutoSize = true;
            this.labelProductCorner.Location = new System.Drawing.Point(495, 271);
            this.labelProductCorner.Name = "labelProductCorner";
            this.labelProductCorner.Size = new System.Drawing.Size(83, 13);
            this.labelProductCorner.TabIndex = 21;
            this.labelProductCorner.Text = "Esquina (envio):";
            // 
            // txtBoxCorner
            // 
            this.txtBoxCorner.Location = new System.Drawing.Point(498, 287);
            this.txtBoxCorner.Name = "txtBoxCorner";
            this.txtBoxCorner.Size = new System.Drawing.Size(253, 20);
            this.txtBoxCorner.TabIndex = 20;
            // 
            // ProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(47)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(773, 559);
            this.Controls.Add(this.labelProductCorner);
            this.Controls.Add(this.txtBoxCorner);
            this.Controls.Add(this.labelDoorNumber);
            this.Controls.Add(this.txtBoxDoorNumber);
            this.Controls.Add(this.labelProductStreet);
            this.Controls.Add(this.txtBoxStreet);
            this.Controls.Add(this.labelProductVolume);
            this.Controls.Add(this.txtBoxVolume);
            this.Controls.Add(this.labelCustomer);
            this.Controls.Add(this.labelActived);
            this.Controls.Add(this.labelProductWeight);
            this.Controls.Add(this.txtBoxCustomer);
            this.Controls.Add(this.txtBoxActive);
            this.Controls.Add(this.txtBoxWeight);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAddProduct);
            this.Controls.Add(this.dataGridViewProducts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProductsForm";
            this.Text = "ProductsAndLotsForm";
            this.Load += new System.EventHandler(this.ProductsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewProducts;
        private System.Windows.Forms.Button buttonAddProduct;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.TextBox txtBoxWeight;
        private System.Windows.Forms.TextBox txtBoxActive;
        private System.Windows.Forms.TextBox txtBoxCustomer;
        private System.Windows.Forms.Label labelProductWeight;
        private System.Windows.Forms.Label labelActived;
        private System.Windows.Forms.Label labelCustomer;
        private System.Windows.Forms.Label labelProductVolume;
        private System.Windows.Forms.TextBox txtBoxVolume;
        private System.Windows.Forms.Label labelProductStreet;
        private System.Windows.Forms.TextBox txtBoxStreet;
        private System.Windows.Forms.Label labelDoorNumber;
        private System.Windows.Forms.TextBox txtBoxDoorNumber;
        private System.Windows.Forms.Label labelProductCorner;
        private System.Windows.Forms.TextBox txtBoxCorner;
    }
}