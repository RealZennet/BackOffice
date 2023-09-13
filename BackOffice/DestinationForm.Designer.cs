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
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBoxDestinationCorner = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBoxDestinationStreet = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridViewDestinations = new System.Windows.Forms.DataGridView();
            this.buttonEditDestination = new System.Windows.Forms.Button();
            this.buttonRefreshDestination = new System.Windows.Forms.Button();
            this.buttonDeleteDestination = new System.Windows.Forms.Button();
            this.buttonAddDestination = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxDestinationDoorNumber = new System.Windows.Forms.TextBox();
            this.txtBoxIDDestination = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDestinations)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 443);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 63;
            this.label7.Text = "Activo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 402);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 61;
            this.label6.Text = "Esquina";
            // 
            // txtBoxDestinationCorner
            // 
            this.txtBoxDestinationCorner.Location = new System.Drawing.Point(12, 417);
            this.txtBoxDestinationCorner.Name = "txtBoxDestinationCorner";
            this.txtBoxDestinationCorner.Size = new System.Drawing.Size(100, 20);
            this.txtBoxDestinationCorner.TabIndex = 60;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 360);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 59;
            this.label5.Text = "Numero";
            // 
            // txtBoxDestinationStreet
            // 
            this.txtBoxDestinationStreet.Location = new System.Drawing.Point(13, 331);
            this.txtBoxDestinationStreet.Name = "txtBoxDestinationStreet";
            this.txtBoxDestinationStreet.Size = new System.Drawing.Size(100, 20);
            this.txtBoxDestinationStreet.TabIndex = 58;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 315);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 57;
            this.label4.Text = "Calle";
            // 
            // dataGridViewDestinations
            // 
            this.dataGridViewDestinations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDestinations.Location = new System.Drawing.Point(12, 68);
            this.dataGridViewDestinations.Name = "dataGridViewDestinations";
            this.dataGridViewDestinations.Size = new System.Drawing.Size(733, 228);
            this.dataGridViewDestinations.TabIndex = 55;
            // 
            // buttonEditDestination
            // 
            this.buttonEditDestination.Location = new System.Drawing.Point(160, 360);
            this.buttonEditDestination.Name = "buttonEditDestination";
            this.buttonEditDestination.Size = new System.Drawing.Size(46, 26);
            this.buttonEditDestination.TabIndex = 54;
            this.buttonEditDestination.Text = "Editar";
            this.buttonEditDestination.UseVisualStyleBackColor = true;
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
            // txtBoxDestinationDoorNumber
            // 
            this.txtBoxDestinationDoorNumber.Location = new System.Drawing.Point(15, 379);
            this.txtBoxDestinationDoorNumber.Name = "txtBoxDestinationDoorNumber";
            this.txtBoxDestinationDoorNumber.Size = new System.Drawing.Size(100, 20);
            this.txtBoxDestinationDoorNumber.TabIndex = 64;
            // 
            // txtBoxIDDestination
            // 
            this.txtBoxIDDestination.Location = new System.Drawing.Point(160, 331);
            this.txtBoxIDDestination.Name = "txtBoxIDDestination";
            this.txtBoxIDDestination.Size = new System.Drawing.Size(46, 20);
            this.txtBoxIDDestination.TabIndex = 66;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(159, 315);
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
            // DestinationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(75)))), ((int)(((byte)(96)))));
            this.ClientSize = new System.Drawing.Size(757, 520);
            this.ControlBox = false;
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.txtBoxIDDestination);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxDestinationDoorNumber);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBoxDestinationCorner);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBoxDestinationStreet);
            this.Controls.Add(this.label4);
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

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBoxDestinationCorner;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBoxDestinationStreet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridViewDestinations;
        private System.Windows.Forms.Button buttonEditDestination;
        private System.Windows.Forms.Button buttonRefreshDestination;
        private System.Windows.Forms.Button buttonDeleteDestination;
        private System.Windows.Forms.Button buttonAddDestination;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxDestinationDoorNumber;
        private System.Windows.Forms.TextBox txtBoxIDDestination;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.ComboBox comboBoxStatus;
    }
}