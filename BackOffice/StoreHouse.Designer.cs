namespace BackOffice
{
    partial class StoreHouse
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonEditStoreHouse = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonRefreshStoreHouse = new System.Windows.Forms.Button();
            this.buttonDeleteStoreHouse = new System.Windows.Forms.Button();
            this.buttonAddStoreHouse = new System.Windows.Forms.Button();
            this.dataGridViewStoreHouses = new System.Windows.Forms.DataGridView();
            this.dataGridViewAddOperatorStoreHouse = new System.Windows.Forms.DataGridView();
            this.buttonRefreshAddOperatorStoreHouses = new System.Windows.Forms.Button();
            this.buttonDeleteOperatorFromStoreHouse = new System.Windows.Forms.Button();
            this.buttonAddOperatorToStoreHouse = new System.Windows.Forms.Button();
            this.labelStreet = new System.Windows.Forms.Label();
            this.txtBoxStoreHouseStreet = new System.Windows.Forms.TextBox();
            this.txtBoxStoreHouseDoorNumber = new System.Windows.Forms.TextBox();
            this.labelNumber = new System.Windows.Forms.Label();
            this.txtBoxStoreHouseCorner = new System.Windows.Forms.TextBox();
            this.labelCorner = new System.Windows.Forms.Label();
            this.txtBoxStoreHouseActived = new System.Windows.Forms.TextBox();
            this.labelActived = new System.Windows.Forms.Label();
            this.labelIDOperator = new System.Windows.Forms.Label();
            this.txtBoxIDOperator = new System.Windows.Forms.TextBox();
            this.txtBoxIDAddOperatorToStoreHouse = new System.Windows.Forms.TextBox();
            this.labelIDStoreHouse = new System.Windows.Forms.Label();
            this.panelSeparator = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStoreHouses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAddOperatorStoreHouse)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonEditStoreHouse
            // 
            this.buttonEditStoreHouse.Location = new System.Drawing.Point(234, 504);
            this.buttonEditStoreHouse.Name = "buttonEditStoreHouse";
            this.buttonEditStoreHouse.Size = new System.Drawing.Size(68, 26);
            this.buttonEditStoreHouse.TabIndex = 32;
            this.buttonEditStoreHouse.Text = "Editar";
            this.buttonEditStoreHouse.UseVisualStyleBackColor = true;
            // 
            // buttonBack
            // 
            this.buttonBack.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBack.Location = new System.Drawing.Point(12, 16);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(96, 26);
            this.buttonBack.TabIndex = 31;
            this.buttonBack.Text = "Volver";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonRefreshStoreHouse
            // 
            this.buttonRefreshStoreHouse.Location = new System.Drawing.Point(160, 504);
            this.buttonRefreshStoreHouse.Name = "buttonRefreshStoreHouse";
            this.buttonRefreshStoreHouse.Size = new System.Drawing.Size(68, 26);
            this.buttonRefreshStoreHouse.TabIndex = 30;
            this.buttonRefreshStoreHouse.Text = "Recargar";
            this.buttonRefreshStoreHouse.UseVisualStyleBackColor = true;
            this.buttonRefreshStoreHouse.Click += new System.EventHandler(this.buttonRefreshStoreHouse_Click);
            // 
            // buttonDeleteStoreHouse
            // 
            this.buttonDeleteStoreHouse.Location = new System.Drawing.Point(86, 504);
            this.buttonDeleteStoreHouse.Name = "buttonDeleteStoreHouse";
            this.buttonDeleteStoreHouse.Size = new System.Drawing.Size(68, 26);
            this.buttonDeleteStoreHouse.TabIndex = 29;
            this.buttonDeleteStoreHouse.Text = "Eliminar";
            this.buttonDeleteStoreHouse.UseVisualStyleBackColor = true;
            // 
            // buttonAddStoreHouse
            // 
            this.buttonAddStoreHouse.Location = new System.Drawing.Point(12, 504);
            this.buttonAddStoreHouse.Name = "buttonAddStoreHouse";
            this.buttonAddStoreHouse.Size = new System.Drawing.Size(68, 26);
            this.buttonAddStoreHouse.TabIndex = 28;
            this.buttonAddStoreHouse.Text = "Agregar";
            this.buttonAddStoreHouse.UseVisualStyleBackColor = true;
            this.buttonAddStoreHouse.Click += new System.EventHandler(this.buttonAddStoreHouse_Click);
            // 
            // dataGridViewStoreHouses
            // 
            this.dataGridViewStoreHouses.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(47)))), ((int)(((byte)(68)))));
            this.dataGridViewStoreHouses.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewStoreHouses.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(84)))), ((int)(((byte)(112)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewStoreHouses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewStoreHouses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(84)))), ((int)(((byte)(112)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewStoreHouses.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewStoreHouses.EnableHeadersVisualStyles = false;
            this.dataGridViewStoreHouses.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(47)))), ((int)(((byte)(68)))));
            this.dataGridViewStoreHouses.Location = new System.Drawing.Point(12, 73);
            this.dataGridViewStoreHouses.Name = "dataGridViewStoreHouses";
            this.dataGridViewStoreHouses.Size = new System.Drawing.Size(290, 228);
            this.dataGridViewStoreHouses.TabIndex = 33;
            // 
            // dataGridViewAddOperatorStoreHouse
            // 
            this.dataGridViewAddOperatorStoreHouse.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(47)))), ((int)(((byte)(68)))));
            this.dataGridViewAddOperatorStoreHouse.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewAddOperatorStoreHouse.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(84)))), ((int)(((byte)(112)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAddOperatorStoreHouse.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewAddOperatorStoreHouse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(84)))), ((int)(((byte)(112)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewAddOperatorStoreHouse.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewAddOperatorStoreHouse.EnableHeadersVisualStyles = false;
            this.dataGridViewAddOperatorStoreHouse.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(47)))), ((int)(((byte)(68)))));
            this.dataGridViewAddOperatorStoreHouse.Location = new System.Drawing.Point(455, 73);
            this.dataGridViewAddOperatorStoreHouse.Name = "dataGridViewAddOperatorStoreHouse";
            this.dataGridViewAddOperatorStoreHouse.Size = new System.Drawing.Size(290, 228);
            this.dataGridViewAddOperatorStoreHouse.TabIndex = 38;
            // 
            // buttonRefreshAddOperatorStoreHouses
            // 
            this.buttonRefreshAddOperatorStoreHouses.Location = new System.Drawing.Point(605, 504);
            this.buttonRefreshAddOperatorStoreHouses.Name = "buttonRefreshAddOperatorStoreHouses";
            this.buttonRefreshAddOperatorStoreHouses.Size = new System.Drawing.Size(68, 26);
            this.buttonRefreshAddOperatorStoreHouses.TabIndex = 36;
            this.buttonRefreshAddOperatorStoreHouses.Text = "Recargar";
            this.buttonRefreshAddOperatorStoreHouses.UseVisualStyleBackColor = true;
            this.buttonRefreshAddOperatorStoreHouses.Click += new System.EventHandler(this.buttonRefreshAddOperatorStoreHouses_Click);
            // 
            // buttonDeleteOperatorFromStoreHouse
            // 
            this.buttonDeleteOperatorFromStoreHouse.Location = new System.Drawing.Point(531, 504);
            this.buttonDeleteOperatorFromStoreHouse.Name = "buttonDeleteOperatorFromStoreHouse";
            this.buttonDeleteOperatorFromStoreHouse.Size = new System.Drawing.Size(68, 26);
            this.buttonDeleteOperatorFromStoreHouse.TabIndex = 35;
            this.buttonDeleteOperatorFromStoreHouse.Text = "Eliminar";
            this.buttonDeleteOperatorFromStoreHouse.UseVisualStyleBackColor = true;
            this.buttonDeleteOperatorFromStoreHouse.Click += new System.EventHandler(this.buttonDeleteOperatorFromStoreHouse_Click);
            // 
            // buttonAddOperatorToStoreHouse
            // 
            this.buttonAddOperatorToStoreHouse.Location = new System.Drawing.Point(457, 504);
            this.buttonAddOperatorToStoreHouse.Name = "buttonAddOperatorToStoreHouse";
            this.buttonAddOperatorToStoreHouse.Size = new System.Drawing.Size(68, 26);
            this.buttonAddOperatorToStoreHouse.TabIndex = 34;
            this.buttonAddOperatorToStoreHouse.Text = "Agregar";
            this.buttonAddOperatorToStoreHouse.UseVisualStyleBackColor = true;
            this.buttonAddOperatorToStoreHouse.Click += new System.EventHandler(this.buttonAddOperatorToStoreHouse_Click);
            // 
            // labelStreet
            // 
            this.labelStreet.AutoSize = true;
            this.labelStreet.Location = new System.Drawing.Point(12, 320);
            this.labelStreet.Name = "labelStreet";
            this.labelStreet.Size = new System.Drawing.Size(30, 13);
            this.labelStreet.TabIndex = 41;
            this.labelStreet.Text = "Calle";
            // 
            // txtBoxStoreHouseStreet
            // 
            this.txtBoxStoreHouseStreet.Location = new System.Drawing.Point(13, 336);
            this.txtBoxStoreHouseStreet.Name = "txtBoxStoreHouseStreet";
            this.txtBoxStoreHouseStreet.Size = new System.Drawing.Size(100, 20);
            this.txtBoxStoreHouseStreet.TabIndex = 42;
            // 
            // txtBoxStoreHouseDoorNumber
            // 
            this.txtBoxStoreHouseDoorNumber.Location = new System.Drawing.Point(13, 381);
            this.txtBoxStoreHouseDoorNumber.Name = "txtBoxStoreHouseDoorNumber";
            this.txtBoxStoreHouseDoorNumber.Size = new System.Drawing.Size(100, 20);
            this.txtBoxStoreHouseDoorNumber.TabIndex = 43;
            // 
            // labelNumber
            // 
            this.labelNumber.AutoSize = true;
            this.labelNumber.Location = new System.Drawing.Point(12, 365);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(44, 13);
            this.labelNumber.TabIndex = 44;
            this.labelNumber.Text = "Numero";
            // 
            // txtBoxStoreHouseCorner
            // 
            this.txtBoxStoreHouseCorner.Location = new System.Drawing.Point(12, 422);
            this.txtBoxStoreHouseCorner.Name = "txtBoxStoreHouseCorner";
            this.txtBoxStoreHouseCorner.Size = new System.Drawing.Size(100, 20);
            this.txtBoxStoreHouseCorner.TabIndex = 45;
            // 
            // labelCorner
            // 
            this.labelCorner.AutoSize = true;
            this.labelCorner.Location = new System.Drawing.Point(12, 407);
            this.labelCorner.Name = "labelCorner";
            this.labelCorner.Size = new System.Drawing.Size(45, 13);
            this.labelCorner.TabIndex = 46;
            this.labelCorner.Text = "Esquina";
            // 
            // txtBoxStoreHouseActived
            // 
            this.txtBoxStoreHouseActived.Location = new System.Drawing.Point(13, 464);
            this.txtBoxStoreHouseActived.Name = "txtBoxStoreHouseActived";
            this.txtBoxStoreHouseActived.Size = new System.Drawing.Size(100, 20);
            this.txtBoxStoreHouseActived.TabIndex = 47;
            // 
            // labelActived
            // 
            this.labelActived.AutoSize = true;
            this.labelActived.Location = new System.Drawing.Point(12, 448);
            this.labelActived.Name = "labelActived";
            this.labelActived.Size = new System.Drawing.Size(37, 13);
            this.labelActived.TabIndex = 48;
            this.labelActived.Text = "Activo";
            // 
            // labelIDOperator
            // 
            this.labelIDOperator.AutoSize = true;
            this.labelIDOperator.Location = new System.Drawing.Point(454, 381);
            this.labelIDOperator.Name = "labelIDOperator";
            this.labelIDOperator.Size = new System.Drawing.Size(61, 13);
            this.labelIDOperator.TabIndex = 52;
            this.labelIDOperator.Text = "ID Operario";
            // 
            // txtBoxIDOperator
            // 
            this.txtBoxIDOperator.Location = new System.Drawing.Point(455, 397);
            this.txtBoxIDOperator.Name = "txtBoxIDOperator";
            this.txtBoxIDOperator.Size = new System.Drawing.Size(43, 20);
            this.txtBoxIDOperator.TabIndex = 51;
            // 
            // txtBoxIDAddOperatorToStoreHouse
            // 
            this.txtBoxIDAddOperatorToStoreHouse.Location = new System.Drawing.Point(455, 352);
            this.txtBoxIDAddOperatorToStoreHouse.Name = "txtBoxIDAddOperatorToStoreHouse";
            this.txtBoxIDAddOperatorToStoreHouse.Size = new System.Drawing.Size(43, 20);
            this.txtBoxIDAddOperatorToStoreHouse.TabIndex = 50;
            // 
            // labelIDStoreHouse
            // 
            this.labelIDStoreHouse.AutoSize = true;
            this.labelIDStoreHouse.Location = new System.Drawing.Point(454, 336);
            this.labelIDStoreHouse.Name = "labelIDStoreHouse";
            this.labelIDStoreHouse.Size = new System.Drawing.Size(62, 13);
            this.labelIDStoreHouse.TabIndex = 49;
            this.labelIDStoreHouse.Text = "ID Almacen";
            // 
            // panelSeparator
            // 
            this.panelSeparator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(84)))), ((int)(((byte)(112)))));
            this.panelSeparator.Location = new System.Drawing.Point(385, 1);
            this.panelSeparator.Name = "panelSeparator";
            this.panelSeparator.Size = new System.Drawing.Size(3, 557);
            this.panelSeparator.TabIndex = 82;
            // 
            // StoreHouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(47)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(773, 559);
            this.ControlBox = false;
            this.Controls.Add(this.panelSeparator);
            this.Controls.Add(this.labelIDOperator);
            this.Controls.Add(this.txtBoxIDOperator);
            this.Controls.Add(this.txtBoxIDAddOperatorToStoreHouse);
            this.Controls.Add(this.labelIDStoreHouse);
            this.Controls.Add(this.labelActived);
            this.Controls.Add(this.txtBoxStoreHouseActived);
            this.Controls.Add(this.labelCorner);
            this.Controls.Add(this.txtBoxStoreHouseCorner);
            this.Controls.Add(this.labelNumber);
            this.Controls.Add(this.txtBoxStoreHouseDoorNumber);
            this.Controls.Add(this.txtBoxStoreHouseStreet);
            this.Controls.Add(this.labelStreet);
            this.Controls.Add(this.dataGridViewAddOperatorStoreHouse);
            this.Controls.Add(this.buttonRefreshAddOperatorStoreHouses);
            this.Controls.Add(this.buttonDeleteOperatorFromStoreHouse);
            this.Controls.Add(this.buttonAddOperatorToStoreHouse);
            this.Controls.Add(this.dataGridViewStoreHouses);
            this.Controls.Add(this.buttonEditStoreHouse);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonRefreshStoreHouse);
            this.Controls.Add(this.buttonDeleteStoreHouse);
            this.Controls.Add(this.buttonAddStoreHouse);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StoreHouse";
            this.Text = "StoreHouse";
            this.Load += new System.EventHandler(this.StoreHouse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStoreHouses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAddOperatorStoreHouse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEditStoreHouse;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonRefreshStoreHouse;
        private System.Windows.Forms.Button buttonDeleteStoreHouse;
        private System.Windows.Forms.Button buttonAddStoreHouse;
        private System.Windows.Forms.DataGridView dataGridViewStoreHouses;
        private System.Windows.Forms.DataGridView dataGridViewAddOperatorStoreHouse;
        private System.Windows.Forms.Button buttonRefreshAddOperatorStoreHouses;
        private System.Windows.Forms.Button buttonDeleteOperatorFromStoreHouse;
        private System.Windows.Forms.Button buttonAddOperatorToStoreHouse;
        private System.Windows.Forms.Label labelStreet;
        private System.Windows.Forms.TextBox txtBoxStoreHouseStreet;
        private System.Windows.Forms.TextBox txtBoxStoreHouseDoorNumber;
        private System.Windows.Forms.Label labelNumber;
        private System.Windows.Forms.TextBox txtBoxStoreHouseCorner;
        private System.Windows.Forms.Label labelCorner;
        private System.Windows.Forms.TextBox txtBoxStoreHouseActived;
        private System.Windows.Forms.Label labelActived;
        private System.Windows.Forms.Label labelIDOperator;
        private System.Windows.Forms.TextBox txtBoxIDOperator;
        private System.Windows.Forms.TextBox txtBoxIDAddOperatorToStoreHouse;
        private System.Windows.Forms.Label labelIDStoreHouse;
        private System.Windows.Forms.Panel panelSeparator;
    }
}