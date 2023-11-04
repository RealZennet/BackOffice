namespace BackOffice
{
    partial class TravelManagerForm
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
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.labelIDDestination = new System.Windows.Forms.Label();
            this.txtBoxIDDestination = new System.Windows.Forms.TextBox();
            this.labelIDStoreHouse = new System.Windows.Forms.Label();
            this.txtBoxIDStoreHouse = new System.Windows.Forms.TextBox();
            this.buttonBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewTravels = new System.Windows.Forms.DataGridView();
            this.labelTypeTravel = new System.Windows.Forms.Label();
            this.labelDateTravel = new System.Windows.Forms.Label();
            this.dateTimePickerShippmentDate = new System.Windows.Forms.DateTimePicker();
            this.comboBoxTypeTravel = new System.Windows.Forms.ComboBox();
            this.dateTimePickerShippmentDateTime = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTravels)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(661, 345);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(68, 26);
            this.buttonRefresh.TabIndex = 20;
            this.buttonRefresh.Text = "Recargar";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(587, 345);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(68, 26);
            this.buttonDelete.TabIndex = 19;
            this.buttonDelete.Text = "Eliminar";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(513, 345);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(68, 26);
            this.buttonAdd.TabIndex = 18;
            this.buttonAdd.Text = "Agregar";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // labelIDDestination
            // 
            this.labelIDDestination.AutoSize = true;
            this.labelIDDestination.Location = new System.Drawing.Point(510, 123);
            this.labelIDDestination.Name = "labelIDDestination";
            this.labelIDDestination.Size = new System.Drawing.Size(57, 13);
            this.labelIDDestination.TabIndex = 17;
            this.labelIDDestination.Text = "ID Destino";
            // 
            // txtBoxIDDestination
            // 
            this.txtBoxIDDestination.Location = new System.Drawing.Point(513, 148);
            this.txtBoxIDDestination.Name = "txtBoxIDDestination";
            this.txtBoxIDDestination.Size = new System.Drawing.Size(210, 20);
            this.txtBoxIDDestination.TabIndex = 16;
            // 
            // labelIDStoreHouse
            // 
            this.labelIDStoreHouse.AutoSize = true;
            this.labelIDStoreHouse.Location = new System.Drawing.Point(510, 56);
            this.labelIDStoreHouse.Name = "labelIDStoreHouse";
            this.labelIDStoreHouse.Size = new System.Drawing.Size(62, 13);
            this.labelIDStoreHouse.TabIndex = 15;
            this.labelIDStoreHouse.Text = "ID Almacen";
            // 
            // txtBoxIDStoreHouse
            // 
            this.txtBoxIDStoreHouse.Location = new System.Drawing.Point(513, 81);
            this.txtBoxIDStoreHouse.Name = "txtBoxIDStoreHouse";
            this.txtBoxIDStoreHouse.Size = new System.Drawing.Size(210, 20);
            this.txtBoxIDStoreHouse.TabIndex = 14;
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(7, 9);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(96, 26);
            this.buttonBack.TabIndex = 13;
            this.buttonBack.Text = "Volver";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label1.Location = new System.Drawing.Point(316, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Recorrido";
            // 
            // dataGridViewTravels
            // 
            this.dataGridViewTravels.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(47)))), ((int)(((byte)(68)))));
            this.dataGridViewTravels.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewTravels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTravels.Location = new System.Drawing.Point(7, 41);
            this.dataGridViewTravels.Name = "dataGridViewTravels";
            this.dataGridViewTravels.Size = new System.Drawing.Size(480, 475);
            this.dataGridViewTravels.TabIndex = 11;
            // 
            // labelTypeTravel
            // 
            this.labelTypeTravel.AutoSize = true;
            this.labelTypeTravel.Location = new System.Drawing.Point(510, 183);
            this.labelTypeTravel.Name = "labelTypeTravel";
            this.labelTypeTravel.Size = new System.Drawing.Size(73, 13);
            this.labelTypeTravel.TabIndex = 22;
            this.labelTypeTravel.Text = "Tipo Trayecto";
            // 
            // labelDateTravel
            // 
            this.labelDateTravel.AutoSize = true;
            this.labelDateTravel.Location = new System.Drawing.Point(510, 249);
            this.labelDateTravel.Name = "labelDateTravel";
            this.labelDateTravel.Size = new System.Drawing.Size(82, 13);
            this.labelDateTravel.TabIndex = 24;
            this.labelDateTravel.Text = "Fecha Trayecto";
            // 
            // dateTimePickerShippmentDate
            // 
            this.dateTimePickerShippmentDate.Location = new System.Drawing.Point(513, 274);
            this.dateTimePickerShippmentDate.Name = "dateTimePickerShippmentDate";
            this.dateTimePickerShippmentDate.Size = new System.Drawing.Size(210, 20);
            this.dateTimePickerShippmentDate.TabIndex = 25;
            // 
            // comboBoxTypeTravel
            // 
            this.comboBoxTypeTravel.FormattingEnabled = true;
            this.comboBoxTypeTravel.Location = new System.Drawing.Point(513, 214);
            this.comboBoxTypeTravel.Name = "comboBoxTypeTravel";
            this.comboBoxTypeTravel.Size = new System.Drawing.Size(210, 21);
            this.comboBoxTypeTravel.TabIndex = 26;
            // 
            // dateTimePickerShippmentDateTime
            // 
            this.dateTimePickerShippmentDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerShippmentDateTime.Location = new System.Drawing.Point(513, 300);
            this.dateTimePickerShippmentDateTime.Name = "dateTimePickerShippmentDateTime";
            this.dateTimePickerShippmentDateTime.Size = new System.Drawing.Size(210, 20);
            this.dateTimePickerShippmentDateTime.TabIndex = 27;
            // 
            // TravelManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(47)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(741, 481);
            this.Controls.Add(this.dateTimePickerShippmentDateTime);
            this.Controls.Add(this.comboBoxTypeTravel);
            this.Controls.Add(this.dateTimePickerShippmentDate);
            this.Controls.Add(this.labelDateTravel);
            this.Controls.Add(this.labelTypeTravel);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelIDDestination);
            this.Controls.Add(this.txtBoxIDDestination);
            this.Controls.Add(this.labelIDStoreHouse);
            this.Controls.Add(this.txtBoxIDStoreHouse);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewTravels);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TravelManagerForm";
            this.Text = "TravelManagerForm";
            this.Load += new System.EventHandler(this.TravelManagerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTravels)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label labelIDDestination;
        private System.Windows.Forms.TextBox txtBoxIDDestination;
        private System.Windows.Forms.Label labelIDStoreHouse;
        private System.Windows.Forms.TextBox txtBoxIDStoreHouse;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewTravels;
        private System.Windows.Forms.Label labelTypeTravel;
        private System.Windows.Forms.Label labelDateTravel;
        private System.Windows.Forms.DateTimePicker dateTimePickerShippmentDate;
        private System.Windows.Forms.ComboBox comboBoxTypeTravel;
        private System.Windows.Forms.DateTimePicker dateTimePickerShippmentDateTime;
    }
}