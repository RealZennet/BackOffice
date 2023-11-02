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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelShipDate = new System.Windows.Forms.Label();
            this.labelIDLot = new System.Windows.Forms.Label();
            this.txtBoxIDBatchShippManagement = new System.Windows.Forms.TextBox();
            this.txtBoxIDTruckShippManagement = new System.Windows.Forms.TextBox();
            this.labelIDTruck = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewShippingManagement = new System.Windows.Forms.DataGridView();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonRefreshShipps = new System.Windows.Forms.Button();
            this.buttonDeleteShipp = new System.Windows.Forms.Button();
            this.buttonAddShipp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewCarry = new System.Windows.Forms.DataGridView();
            this.dateTimePickerShippManagement = new System.Windows.Forms.DateTimePicker();
            this.buttonRefreshCarry = new System.Windows.Forms.Button();
            this.buttonDeleteCarry = new System.Windows.Forms.Button();
            this.buttonAddCarry = new System.Windows.Forms.Button();
            this.buttonEditCarry = new System.Windows.Forms.Button();
            this.labelIDLot2 = new System.Windows.Forms.Label();
            this.txtBoxIDBatchCarrie = new System.Windows.Forms.TextBox();
            this.txtBoxIDTruckCarrie = new System.Windows.Forms.TextBox();
            this.labelIDestination = new System.Windows.Forms.Label();
            this.txtBoxIDDestinationCarrie = new System.Windows.Forms.TextBox();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.dateTimePickerShippManagementTime = new System.Windows.Forms.DateTimePicker();
            this.panelSeparator = new System.Windows.Forms.Panel();
            this.labelIDTruck2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShippingManagement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCarry)).BeginInit();
            this.SuspendLayout();
            // 
            // labelShipDate
            // 
            this.labelShipDate.AutoSize = true;
            this.labelShipDate.Location = new System.Drawing.Point(12, 403);
            this.labelShipDate.Name = "labelShipDate";
            this.labelShipDate.Size = new System.Drawing.Size(82, 13);
            this.labelShipDate.TabIndex = 61;
            this.labelShipDate.Text = "Fecha de salida";
            // 
            // labelIDLot
            // 
            this.labelIDLot.AutoSize = true;
            this.labelIDLot.Location = new System.Drawing.Point(12, 361);
            this.labelIDLot.Name = "labelIDLot";
            this.labelIDLot.Size = new System.Drawing.Size(42, 13);
            this.labelIDLot.TabIndex = 59;
            this.labelIDLot.Text = "ID Lote";
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
            // labelIDTruck
            // 
            this.labelIDTruck.AutoSize = true;
            this.labelIDTruck.Location = new System.Drawing.Point(12, 316);
            this.labelIDTruck.Name = "labelIDTruck";
            this.labelIDTruck.Size = new System.Drawing.Size(56, 13);
            this.labelIDTruck.TabIndex = 56;
            this.labelIDTruck.Text = "ID Camion";
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
            this.dataGridViewShippingManagement.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(47)))), ((int)(((byte)(68)))));
            this.dataGridViewShippingManagement.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewShippingManagement.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(84)))), ((int)(((byte)(112)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewShippingManagement.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewShippingManagement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(84)))), ((int)(((byte)(112)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewShippingManagement.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewShippingManagement.EnableHeadersVisualStyles = false;
            this.dataGridViewShippingManagement.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(47)))), ((int)(((byte)(68)))));
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
            // dataGridViewCarry
            // 
            this.dataGridViewCarry.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(47)))), ((int)(((byte)(68)))));
            this.dataGridViewCarry.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewCarry.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(84)))), ((int)(((byte)(112)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCarry.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewCarry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(84)))), ((int)(((byte)(112)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewCarry.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewCarry.EnableHeadersVisualStyles = false;
            this.dataGridViewCarry.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(47)))), ((int)(((byte)(68)))));
            this.dataGridViewCarry.Location = new System.Drawing.Point(455, 69);
            this.dataGridViewCarry.Name = "dataGridViewCarry";
            this.dataGridViewCarry.Size = new System.Drawing.Size(290, 228);
            this.dataGridViewCarry.TabIndex = 64;
            // 
            // dateTimePickerShippManagement
            // 
            this.dateTimePickerShippManagement.Location = new System.Drawing.Point(13, 431);
            this.dateTimePickerShippManagement.Name = "dateTimePickerShippManagement";
            this.dateTimePickerShippManagement.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerShippManagement.TabIndex = 66;
            // 
            // buttonRefreshCarry
            // 
            this.buttonRefreshCarry.Location = new System.Drawing.Point(625, 500);
            this.buttonRefreshCarry.Name = "buttonRefreshCarry";
            this.buttonRefreshCarry.Size = new System.Drawing.Size(68, 26);
            this.buttonRefreshCarry.TabIndex = 69;
            this.buttonRefreshCarry.Text = "Recargar";
            this.buttonRefreshCarry.UseVisualStyleBackColor = true;
            this.buttonRefreshCarry.Click += new System.EventHandler(this.buttonRefreshCarry_Click);
            // 
            // buttonDeleteCarry
            // 
            this.buttonDeleteCarry.Location = new System.Drawing.Point(551, 500);
            this.buttonDeleteCarry.Name = "buttonDeleteCarry";
            this.buttonDeleteCarry.Size = new System.Drawing.Size(68, 26);
            this.buttonDeleteCarry.TabIndex = 68;
            this.buttonDeleteCarry.Text = "Eliminar";
            this.buttonDeleteCarry.UseVisualStyleBackColor = true;
            this.buttonDeleteCarry.Click += new System.EventHandler(this.buttonDeleteCarry_Click);
            // 
            // buttonAddCarry
            // 
            this.buttonAddCarry.Location = new System.Drawing.Point(477, 500);
            this.buttonAddCarry.Name = "buttonAddCarry";
            this.buttonAddCarry.Size = new System.Drawing.Size(68, 26);
            this.buttonAddCarry.TabIndex = 67;
            this.buttonAddCarry.Text = "Agregar";
            this.buttonAddCarry.UseVisualStyleBackColor = true;
            this.buttonAddCarry.Click += new System.EventHandler(this.buttonAddCarry_Click);
            // 
            // buttonEditCarry
            // 
            this.buttonEditCarry.Location = new System.Drawing.Point(699, 500);
            this.buttonEditCarry.Name = "buttonEditCarry";
            this.buttonEditCarry.Size = new System.Drawing.Size(68, 26);
            this.buttonEditCarry.TabIndex = 70;
            this.buttonEditCarry.Text = "Editar";
            this.buttonEditCarry.UseVisualStyleBackColor = true;
            // 
            // labelIDLot2
            // 
            this.labelIDLot2.AutoSize = true;
            this.labelIDLot2.Location = new System.Drawing.Point(476, 361);
            this.labelIDLot2.Name = "labelIDLot2";
            this.labelIDLot2.Size = new System.Drawing.Size(42, 13);
            this.labelIDLot2.TabIndex = 74;
            this.labelIDLot2.Text = "ID Lote";
            // 
            // txtBoxIDBatchCarrie
            // 
            this.txtBoxIDBatchCarrie.Location = new System.Drawing.Point(477, 377);
            this.txtBoxIDBatchCarrie.Name = "txtBoxIDBatchCarrie";
            this.txtBoxIDBatchCarrie.Size = new System.Drawing.Size(41, 20);
            this.txtBoxIDBatchCarrie.TabIndex = 73;
            // 
            // txtBoxIDTruckCarrie
            // 
            this.txtBoxIDTruckCarrie.Location = new System.Drawing.Point(477, 332);
            this.txtBoxIDTruckCarrie.Name = "txtBoxIDTruckCarrie";
            this.txtBoxIDTruckCarrie.Size = new System.Drawing.Size(41, 20);
            this.txtBoxIDTruckCarrie.TabIndex = 72;
            // 
            // labelIDestination
            // 
            this.labelIDestination.AutoSize = true;
            this.labelIDestination.Location = new System.Drawing.Point(478, 405);
            this.labelIDestination.Name = "labelIDestination";
            this.labelIDestination.Size = new System.Drawing.Size(57, 13);
            this.labelIDestination.TabIndex = 76;
            this.labelIDestination.Text = "ID Destino";
            // 
            // txtBoxIDDestinationCarrie
            // 
            this.txtBoxIDDestinationCarrie.Location = new System.Drawing.Point(479, 421);
            this.txtBoxIDDestinationCarrie.Name = "txtBoxIDDestinationCarrie";
            this.txtBoxIDDestinationCarrie.Size = new System.Drawing.Size(41, 20);
            this.txtBoxIDDestinationCarrie.TabIndex = 75;
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Location = new System.Drawing.Point(477, 460);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(121, 21);
            this.comboBoxStatus.TabIndex = 79;
            // 
            // dateTimePickerShippManagementTime
            // 
            this.dateTimePickerShippManagementTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerShippManagementTime.Location = new System.Drawing.Point(15, 460);
            this.dateTimePickerShippManagementTime.Name = "dateTimePickerShippManagementTime";
            this.dateTimePickerShippManagementTime.Size = new System.Drawing.Size(196, 20);
            this.dateTimePickerShippManagementTime.TabIndex = 80;
            // 
            // panelSeparator
            // 
            this.panelSeparator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(84)))), ((int)(((byte)(112)))));
            this.panelSeparator.Location = new System.Drawing.Point(359, 1);
            this.panelSeparator.Name = "panelSeparator";
            this.panelSeparator.Size = new System.Drawing.Size(3, 557);
            this.panelSeparator.TabIndex = 81;
            // 
            // labelIDTruck2
            // 
            this.labelIDTruck2.AutoSize = true;
            this.labelIDTruck2.Location = new System.Drawing.Point(474, 316);
            this.labelIDTruck2.Name = "labelIDTruck2";
            this.labelIDTruck2.Size = new System.Drawing.Size(56, 13);
            this.labelIDTruck2.TabIndex = 82;
            this.labelIDTruck2.Text = "ID Camion";
            // 
            // ShippingManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(47)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(773, 559);
            this.Controls.Add(this.labelIDTruck2);
            this.Controls.Add(this.panelSeparator);
            this.Controls.Add(this.dateTimePickerShippManagementTime);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.labelIDestination);
            this.Controls.Add(this.txtBoxIDDestinationCarrie);
            this.Controls.Add(this.labelIDLot2);
            this.Controls.Add(this.txtBoxIDBatchCarrie);
            this.Controls.Add(this.txtBoxIDTruckCarrie);
            this.Controls.Add(this.buttonEditCarry);
            this.Controls.Add(this.buttonRefreshCarry);
            this.Controls.Add(this.buttonDeleteCarry);
            this.Controls.Add(this.buttonAddCarry);
            this.Controls.Add(this.dateTimePickerShippManagement);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewCarry);
            this.Controls.Add(this.labelShipDate);
            this.Controls.Add(this.labelIDLot);
            this.Controls.Add(this.txtBoxIDBatchShippManagement);
            this.Controls.Add(this.txtBoxIDTruckShippManagement);
            this.Controls.Add(this.labelIDTruck);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewShippingManagement);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonRefreshShipps);
            this.Controls.Add(this.buttonDeleteShipp);
            this.Controls.Add(this.buttonAddShipp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ShippingManagementForm";
            this.Text = "ShippingManagementForm";
            this.Load += new System.EventHandler(this.ShippingManagementForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShippingManagement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCarry)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelShipDate;
        private System.Windows.Forms.Label labelIDLot;
        private System.Windows.Forms.TextBox txtBoxIDBatchShippManagement;
        private System.Windows.Forms.TextBox txtBoxIDTruckShippManagement;
        private System.Windows.Forms.Label labelIDTruck;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewShippingManagement;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonRefreshShipps;
        private System.Windows.Forms.Button buttonDeleteShipp;
        private System.Windows.Forms.Button buttonAddShipp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewCarry;
        private System.Windows.Forms.DateTimePicker dateTimePickerShippManagement;
        private System.Windows.Forms.Button buttonRefreshCarry;
        private System.Windows.Forms.Button buttonDeleteCarry;
        private System.Windows.Forms.Button buttonAddCarry;
        private System.Windows.Forms.Button buttonEditCarry;
        private System.Windows.Forms.Label labelIDLot2;
        private System.Windows.Forms.TextBox txtBoxIDBatchCarrie;
        private System.Windows.Forms.TextBox txtBoxIDTruckCarrie;
        private System.Windows.Forms.Label labelIDestination;
        private System.Windows.Forms.TextBox txtBoxIDDestinationCarrie;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.DateTimePicker dateTimePickerShippManagementTime;
        private System.Windows.Forms.Panel panelSeparator;
        private System.Windows.Forms.Label labelIDTruck2;
    }
}