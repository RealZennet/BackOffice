namespace BackOffice
{
    partial class ShippingManagementForm
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
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBoxIDBatchShippManagement = new System.Windows.Forms.TextBox();
            this.txtBoxIDTruckShippManagement = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewShippingManagement = new System.Windows.Forms.DataGridView();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonRefreshShipps = new System.Windows.Forms.Button();
            this.buttonDeleteShipp = new System.Windows.Forms.Button();
            this.buttonAddShipp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dateTimePickerShippManagement = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShippingManagement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 403);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 61;
            this.label6.Text = "Fecha de salida";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 361);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 59;
            this.label5.Text = "ID Lote";
            // 
            // txtBoxIDBatchShippManagement
            // 
            this.txtBoxIDBatchShippManagement.Location = new System.Drawing.Point(13, 377);
            this.txtBoxIDBatchShippManagement.Name = "txtBoxIDBatchShippManagement";
            this.txtBoxIDBatchShippManagement.Size = new System.Drawing.Size(41, 20);
            this.txtBoxIDBatchShippManagement.TabIndex = 58;
            // 
            // txtBoxIDTruckShippManagement
            // 
            this.txtBoxIDTruckShippManagement.Location = new System.Drawing.Point(13, 332);
            this.txtBoxIDTruckShippManagement.Name = "txtBoxIDTruckShippManagement";
            this.txtBoxIDTruckShippManagement.Size = new System.Drawing.Size(41, 20);
            this.txtBoxIDTruckShippManagement.TabIndex = 57;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 56;
            this.label4.Text = "ID Camion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label2.Location = new System.Drawing.Point(48, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 25);
            this.label2.TabIndex = 55;
            this.label2.Text = "Gestionar envio";
            // 
            // dataGridViewShippingManagement
            // 
            this.dataGridViewShippingManagement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewShippingManagement.Location = new System.Drawing.Point(12, 69);
            this.dataGridViewShippingManagement.Name = "dataGridViewShippingManagement";
            this.dataGridViewShippingManagement.Size = new System.Drawing.Size(290, 228);
            this.dataGridViewShippingManagement.TabIndex = 54;
            // 
            // buttonBack
            // 
            this.buttonBack.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBack.Location = new System.Drawing.Point(12, 12);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(96, 26);
            this.buttonBack.TabIndex = 52;
            this.buttonBack.Text = "Volver";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonRefreshShipps
            // 
            this.buttonRefreshShipps.Location = new System.Drawing.Point(160, 500);
            this.buttonRefreshShipps.Name = "buttonRefreshShipps";
            this.buttonRefreshShipps.Size = new System.Drawing.Size(68, 26);
            this.buttonRefreshShipps.TabIndex = 51;
            this.buttonRefreshShipps.Text = "Recargar";
            this.buttonRefreshShipps.UseVisualStyleBackColor = true;
            this.buttonRefreshShipps.Click += new System.EventHandler(this.buttonRefreshShipps_Click);
            // 
            // buttonDeleteShipp
            // 
            this.buttonDeleteShipp.Location = new System.Drawing.Point(86, 500);
            this.buttonDeleteShipp.Name = "buttonDeleteShipp";
            this.buttonDeleteShipp.Size = new System.Drawing.Size(68, 26);
            this.buttonDeleteShipp.TabIndex = 50;
            this.buttonDeleteShipp.Text = "Eliminar";
            this.buttonDeleteShipp.UseVisualStyleBackColor = true;
            this.buttonDeleteShipp.Click += new System.EventHandler(this.buttonDeleteShipp_Click);
            // 
            // buttonAddShipp
            // 
            this.buttonAddShipp.Location = new System.Drawing.Point(12, 500);
            this.buttonAddShipp.Name = "buttonAddShipp";
            this.buttonAddShipp.Size = new System.Drawing.Size(68, 26);
            this.buttonAddShipp.TabIndex = 49;
            this.buttonAddShipp.Text = "Agregar";
            this.buttonAddShipp.UseVisualStyleBackColor = true;
            this.buttonAddShipp.Click += new System.EventHandler(this.buttonAddShipp_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label1.Location = new System.Drawing.Point(491, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 25);
            this.label1.TabIndex = 65;
            this.label1.Text = "Asignar ruta";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(455, 69);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(290, 228);
            this.dataGridView1.TabIndex = 64;
            // 
            // dateTimePickerShippManagement
            // 
            this.dateTimePickerShippManagement.Location = new System.Drawing.Point(13, 431);
            this.dateTimePickerShippManagement.Name = "dateTimePickerShippManagement";
            this.dateTimePickerShippManagement.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerShippManagement.TabIndex = 66;
            // 
            // ShippingManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(75)))), ((int)(((byte)(96)))));
            this.ClientSize = new System.Drawing.Size(773, 559);
            this.Controls.Add(this.dateTimePickerShippManagement);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBoxIDBatchShippManagement);
            this.Controls.Add(this.txtBoxIDTruckShippManagement);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewShippingManagement);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonRefreshShipps);
            this.Controls.Add(this.buttonDeleteShipp);
            this.Controls.Add(this.buttonAddShipp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ShippingManagementForm";
            this.Text = "ShippingManagementForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShippingManagement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBoxIDBatchShippManagement;
        private System.Windows.Forms.TextBox txtBoxIDTruckShippManagement;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewShippingManagement;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonRefreshShipps;
        private System.Windows.Forms.Button buttonDeleteShipp;
        private System.Windows.Forms.Button buttonAddShipp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dateTimePickerShippManagement;
    }
}