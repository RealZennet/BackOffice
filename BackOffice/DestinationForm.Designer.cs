namespace BackOffice
{
    partial class DestinationForm
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
            this.labelActivated = new System.Windows.Forms.Label();
            this.dataGridViewDestinations = new System.Windows.Forms.DataGridView();
            this.buttonEditDestination = new System.Windows.Forms.Button();
            this.buttonRefreshDestination = new System.Windows.Forms.Button();
            this.buttonDeleteDestination = new System.Windows.Forms.Button();
            this.buttonAddDestination = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxIDDestination = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.dateTimePickerDestinationManagementTime = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDestinationManagement = new System.Windows.Forms.DateTimePicker();
            this.labelShipDate = new System.Windows.Forms.Label();
            this.txtBoxDestinationStreet = new System.Windows.Forms.TextBox();
            this.labelStreet = new System.Windows.Forms.Label();
            this.txtBoxDestinationCorner = new System.Windows.Forms.TextBox();
            this.labelCorner = new System.Windows.Forms.Label();
            this.txtBoxDestinationDoorNumber = new System.Windows.Forms.TextBox();
            this.labelNumber = new System.Windows.Forms.Label();
            this.buttonShowMap = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDestinations)).BeginInit();
            this.SuspendLayout();
            // 
            // labelActivated
            // 
            this.labelActivated.AutoSize = true;
            this.labelActivated.Location = new System.Drawing.Point(12, 443);
            this.labelActivated.Name = "labelActivated";
            this.labelActivated.Size = new System.Drawing.Size(37, 13);
            this.labelActivated.TabIndex = 63;
            this.labelActivated.Text = "Activo";
            // 
            // dataGridViewDestinations
            // 
            this.dataGridViewDestinations.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(47)))), ((int)(((byte)(68)))));
            this.dataGridViewDestinations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDestinations.Location = new System.Drawing.Point(12, 68);
            this.dataGridViewDestinations.Name = "dataGridViewDestinations";
            this.dataGridViewDestinations.Size = new System.Drawing.Size(722, 228);
            this.dataGridViewDestinations.TabIndex = 55;
            this.dataGridViewDestinations.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDestinations_CellClick);
            this.dataGridViewDestinations.SelectionChanged += new System.EventHandler(this.dataGridViewDestinations_SelectionChanged);
            // 
            // buttonEditDestination
            // 
            this.buttonEditDestination.Location = new System.Drawing.Point(142, 359);
            this.buttonEditDestination.Name = "buttonEditDestination";
            this.buttonEditDestination.Size = new System.Drawing.Size(46, 26);
            this.buttonEditDestination.TabIndex = 54;
            this.buttonEditDestination.Text = "Editar";
            this.buttonEditDestination.UseVisualStyleBackColor = true;
            this.buttonEditDestination.Click += new System.EventHandler(this.buttonEditDestination_Click);
            // 
            // buttonRefreshDestination
            // 
            this.buttonRefreshDestination.Location = new System.Drawing.Point(160, 485);
            this.buttonRefreshDestination.Name = "buttonRefreshDestination";
            this.buttonRefreshDestination.Size = new System.Drawing.Size(68, 26);
            this.buttonRefreshDestination.TabIndex = 52;
            this.buttonRefreshDestination.Text = "Recargar";
            this.buttonRefreshDestination.UseVisualStyleBackColor = true;
            this.buttonRefreshDestination.Click += new System.EventHandler(this.buttonRefreshDestination_Click);
            // 
            // buttonDeleteDestination
            // 
            this.buttonDeleteDestination.Location = new System.Drawing.Point(86, 485);
            this.buttonDeleteDestination.Name = "buttonDeleteDestination";
            this.buttonDeleteDestination.Size = new System.Drawing.Size(68, 26);
            this.buttonDeleteDestination.TabIndex = 51;
            this.buttonDeleteDestination.Text = "Eliminar";
            this.buttonDeleteDestination.UseVisualStyleBackColor = true;
            this.buttonDeleteDestination.Click += new System.EventHandler(this.buttonDeleteDestination_Click);
            // 
            // buttonAddDestination
            // 
            this.buttonAddDestination.Location = new System.Drawing.Point(12, 485);
            this.buttonAddDestination.Name = "buttonAddDestination";
            this.buttonAddDestination.Size = new System.Drawing.Size(68, 26);
            this.buttonAddDestination.TabIndex = 50;
            this.buttonAddDestination.Text = "Agregar";
            this.buttonAddDestination.UseVisualStyleBackColor = true;
            this.buttonAddDestination.Click += new System.EventHandler(this.buttonAddDestination_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label1.Location = new System.Drawing.Point(284, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 25);
            this.label1.TabIndex = 49;
            this.label1.Text = "Gestion de destinos.";
            // 
            // txtBoxIDDestination
            // 
            this.txtBoxIDDestination.Location = new System.Drawing.Point(142, 334);
            this.txtBoxIDDestination.Name = "txtBoxIDDestination";
            this.txtBoxIDDestination.Size = new System.Drawing.Size(46, 20);
            this.txtBoxIDDestination.TabIndex = 66;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 315);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 65;
            this.label2.Text = "ID";
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(15, 10);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(86, 23);
            this.buttonBack.TabIndex = 67;
            this.buttonBack.Text = "Volver";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Location = new System.Drawing.Point(12, 459);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(121, 21);
            this.comboBoxStatus.TabIndex = 68;
            // 
            // dateTimePickerDestinationManagementTime
            // 
            this.dateTimePickerDestinationManagementTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerDestinationManagementTime.Location = new System.Drawing.Point(206, 365);
            this.dateTimePickerDestinationManagementTime.Name = "dateTimePickerDestinationManagementTime";
            this.dateTimePickerDestinationManagementTime.Size = new System.Drawing.Size(196, 20);
            this.dateTimePickerDestinationManagementTime.TabIndex = 83;
            // 
            // dateTimePickerDestinationManagement
            // 
            this.dateTimePickerDestinationManagement.Location = new System.Drawing.Point(204, 336);
            this.dateTimePickerDestinationManagement.Name = "dateTimePickerDestinationManagement";
            this.dateTimePickerDestinationManagement.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerDestinationManagement.TabIndex = 82;
            // 
            // labelShipDate
            // 
            this.labelShipDate.AutoSize = true;
            this.labelShipDate.Location = new System.Drawing.Point(203, 308);
            this.labelShipDate.Name = "labelShipDate";
            this.labelShipDate.Size = new System.Drawing.Size(82, 13);
            this.labelShipDate.TabIndex = 81;
            this.labelShipDate.Text = "Fecha de salida";
            // 
            // txtBoxDestinationStreet
            // 
            this.txtBoxDestinationStreet.Location = new System.Drawing.Point(13, 331);
            this.txtBoxDestinationStreet.Name = "txtBoxDestinationStreet";
            this.txtBoxDestinationStreet.Size = new System.Drawing.Size(100, 20);
            this.txtBoxDestinationStreet.TabIndex = 58;
            // 
            // labelStreet
            // 
            this.labelStreet.AutoSize = true;
            this.labelStreet.Location = new System.Drawing.Point(12, 315);
            this.labelStreet.Name = "labelStreet";
            this.labelStreet.Size = new System.Drawing.Size(30, 13);
            this.labelStreet.TabIndex = 57;
            this.labelStreet.Text = "Calle";
            // 
            // txtBoxDestinationCorner
            // 
            this.txtBoxDestinationCorner.Location = new System.Drawing.Point(12, 368);
            this.txtBoxDestinationCorner.Name = "txtBoxDestinationCorner";
            this.txtBoxDestinationCorner.Size = new System.Drawing.Size(100, 20);
            this.txtBoxDestinationCorner.TabIndex = 86;
            // 
            // labelCorner
            // 
            this.labelCorner.AutoSize = true;
            this.labelCorner.Location = new System.Drawing.Point(11, 352);
            this.labelCorner.Name = "labelCorner";
            this.labelCorner.Size = new System.Drawing.Size(45, 13);
            this.labelCorner.TabIndex = 85;
            this.labelCorner.Text = "Esquina";
            // 
            // txtBoxDestinationDoorNumber
            // 
            this.txtBoxDestinationDoorNumber.Location = new System.Drawing.Point(12, 410);
            this.txtBoxDestinationDoorNumber.Name = "txtBoxDestinationDoorNumber";
            this.txtBoxDestinationDoorNumber.Size = new System.Drawing.Size(100, 20);
            this.txtBoxDestinationDoorNumber.TabIndex = 88;
            // 
            // labelNumber
            // 
            this.labelNumber.AutoSize = true;
            this.labelNumber.Location = new System.Drawing.Point(11, 394);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(44, 13);
            this.labelNumber.TabIndex = 87;
            this.labelNumber.Text = "Numero";
            // 
            // buttonShowMap
            // 
            this.buttonShowMap.Location = new System.Drawing.Point(234, 485);
            this.buttonShowMap.Name = "buttonShowMap";
            this.buttonShowMap.Size = new System.Drawing.Size(68, 26);
            this.buttonShowMap.TabIndex = 89;
            this.buttonShowMap.Text = "Ver Mapa";
            this.buttonShowMap.UseVisualStyleBackColor = true;
            this.buttonShowMap.Click += new System.EventHandler(this.buttonShowMap_Click);
            // 
            // DestinationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(47)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(757, 520);
            this.ControlBox = false;
            this.Controls.Add(this.buttonShowMap);
            this.Controls.Add(this.txtBoxDestinationDoorNumber);
            this.Controls.Add(this.labelNumber);
            this.Controls.Add(this.txtBoxDestinationCorner);
            this.Controls.Add(this.labelCorner);
            this.Controls.Add(this.dateTimePickerDestinationManagementTime);
            this.Controls.Add(this.dateTimePickerDestinationManagement);
            this.Controls.Add(this.labelShipDate);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.txtBoxIDDestination);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelActivated);
            this.Controls.Add(this.txtBoxDestinationStreet);
            this.Controls.Add(this.labelStreet);
            this.Controls.Add(this.dataGridViewDestinations);
            this.Controls.Add(this.buttonEditDestination);
            this.Controls.Add(this.buttonRefreshDestination);
            this.Controls.Add(this.buttonDeleteDestination);
            this.Controls.Add(this.buttonAddDestination);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DestinationForm";
            this.Text = "DestinationForm";
            this.Load += new System.EventHandler(this.DestinationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDestinations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelActivated;
        private System.Windows.Forms.DataGridView dataGridViewDestinations;
        private System.Windows.Forms.Button buttonEditDestination;
        private System.Windows.Forms.Button buttonRefreshDestination;
        private System.Windows.Forms.Button buttonDeleteDestination;
        private System.Windows.Forms.Button buttonAddDestination;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxIDDestination;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.DateTimePicker dateTimePickerDestinationManagementTime;
        private System.Windows.Forms.DateTimePicker dateTimePickerDestinationManagement;
        private System.Windows.Forms.Label labelShipDate;
        private System.Windows.Forms.TextBox txtBoxDestinationStreet;
        private System.Windows.Forms.Label labelStreet;
        private System.Windows.Forms.TextBox txtBoxDestinationCorner;
        private System.Windows.Forms.Label labelCorner;
        private System.Windows.Forms.TextBox txtBoxDestinationDoorNumber;
        private System.Windows.Forms.Label labelNumber;
        private System.Windows.Forms.Button buttonShowMap;
    }
}