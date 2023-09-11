namespace BackOffice
{
    partial class TruckManagerForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAddTruck = new System.Windows.Forms.Button();
            this.buttonDeleteTruck = new System.Windows.Forms.Button();
            this.buttonRefreshTruck = new System.Windows.Forms.Button();
            this.dataGridViewAddTruck = new System.Windows.Forms.DataGridView();
            this.txtBoxWeightTruck = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBoxIDAssignedTruck = new System.Windows.Forms.TextBox();
            this.dataGridViewAssignTruck = new System.Windows.Forms.DataGridView();
            this.buttonRefreshAssignTrucker = new System.Windows.Forms.Button();
            this.buttonDeleteAssignedTruck = new System.Windows.Forms.Button();
            this.buttonAddAssignedTruck = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBoxIDAssignedTrucker = new System.Windows.Forms.TextBox();
            this.buttonBack = new System.Windows.Forms.Button();
            this.txtBoxVolumeTruck = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBoxActiveTruck = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.txtBoxTruckID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAddTruck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAssignTruck)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label1.Location = new System.Drawing.Point(340, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestion de camiones.";
            // 
            // buttonAddTruck
            // 
            this.buttonAddTruck.Location = new System.Drawing.Point(425, 516);
            this.buttonAddTruck.Name = "buttonAddTruck";
            this.buttonAddTruck.Size = new System.Drawing.Size(68, 26);
            this.buttonAddTruck.TabIndex = 1;
            this.buttonAddTruck.Text = "Agregar";
            this.buttonAddTruck.UseVisualStyleBackColor = true;
            this.buttonAddTruck.Click += new System.EventHandler(this.buttonAddTruck_Click);
            // 
            // buttonDeleteTruck
            // 
            this.buttonDeleteTruck.Location = new System.Drawing.Point(593, 516);
            this.buttonDeleteTruck.Name = "buttonDeleteTruck";
            this.buttonDeleteTruck.Size = new System.Drawing.Size(68, 26);
            this.buttonDeleteTruck.TabIndex = 2;
            this.buttonDeleteTruck.Text = "Eliminar";
            this.buttonDeleteTruck.UseVisualStyleBackColor = true;
            this.buttonDeleteTruck.Click += new System.EventHandler(this.buttonDeleteTruck_Click);
            // 
            // buttonRefreshTruck
            // 
            this.buttonRefreshTruck.Location = new System.Drawing.Point(684, 516);
            this.buttonRefreshTruck.Name = "buttonRefreshTruck";
            this.buttonRefreshTruck.Size = new System.Drawing.Size(68, 26);
            this.buttonRefreshTruck.TabIndex = 3;
            this.buttonRefreshTruck.Text = "Recargar";
            this.buttonRefreshTruck.UseVisualStyleBackColor = true;
            this.buttonRefreshTruck.Click += new System.EventHandler(this.buttonRefreshTruck_Click);
            // 
            // dataGridViewAddTruck
            // 
            this.dataGridViewAddTruck.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAddTruck.Location = new System.Drawing.Point(425, 297);
            this.dataGridViewAddTruck.Name = "dataGridViewAddTruck";
            this.dataGridViewAddTruck.Size = new System.Drawing.Size(327, 150);
            this.dataGridViewAddTruck.TabIndex = 4;
            // 
            // txtBoxWeightTruck
            // 
            this.txtBoxWeightTruck.Location = new System.Drawing.Point(499, 479);
            this.txtBoxWeightTruck.Name = "txtBoxWeightTruck";
            this.txtBoxWeightTruck.Size = new System.Drawing.Size(61, 20);
            this.txtBoxWeightTruck.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(496, 450);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Peso de camion:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.label3.Location = new System.Drawing.Point(558, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Agregar camion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.label4.Location = new System.Drawing.Point(85, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Asignar camion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 450);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "ID Camion";
            // 
            // txtBoxIDAssignedTruck
            // 
            this.txtBoxIDAssignedTruck.Location = new System.Drawing.Point(26, 479);
            this.txtBoxIDAssignedTruck.Name = "txtBoxIDAssignedTruck";
            this.txtBoxIDAssignedTruck.Size = new System.Drawing.Size(44, 20);
            this.txtBoxIDAssignedTruck.TabIndex = 12;
            // 
            // dataGridViewAssignTruck
            // 
            this.dataGridViewAssignTruck.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAssignTruck.Location = new System.Drawing.Point(26, 297);
            this.dataGridViewAssignTruck.Name = "dataGridViewAssignTruck";
            this.dataGridViewAssignTruck.Size = new System.Drawing.Size(297, 150);
            this.dataGridViewAssignTruck.TabIndex = 11;
            // 
            // buttonRefreshAssignTrucker
            // 
            this.buttonRefreshAssignTrucker.Location = new System.Drawing.Point(211, 516);
            this.buttonRefreshAssignTrucker.Name = "buttonRefreshAssignTrucker";
            this.buttonRefreshAssignTrucker.Size = new System.Drawing.Size(68, 26);
            this.buttonRefreshAssignTrucker.TabIndex = 10;
            this.buttonRefreshAssignTrucker.Text = "Recargar";
            this.buttonRefreshAssignTrucker.UseVisualStyleBackColor = true;
            this.buttonRefreshAssignTrucker.Click += new System.EventHandler(this.buttonRefreshAssignTrucker_Click);
            // 
            // buttonDeleteAssignedTruck
            // 
            this.buttonDeleteAssignedTruck.Location = new System.Drawing.Point(120, 516);
            this.buttonDeleteAssignedTruck.Name = "buttonDeleteAssignedTruck";
            this.buttonDeleteAssignedTruck.Size = new System.Drawing.Size(68, 26);
            this.buttonDeleteAssignedTruck.TabIndex = 9;
            this.buttonDeleteAssignedTruck.Text = "Eliminar";
            this.buttonDeleteAssignedTruck.UseVisualStyleBackColor = true;
            this.buttonDeleteAssignedTruck.Click += new System.EventHandler(this.buttonDeleteAssignedTruck_Click);
            // 
            // buttonAddAssignedTruck
            // 
            this.buttonAddAssignedTruck.Location = new System.Drawing.Point(26, 516);
            this.buttonAddAssignedTruck.Name = "buttonAddAssignedTruck";
            this.buttonAddAssignedTruck.Size = new System.Drawing.Size(68, 26);
            this.buttonAddAssignedTruck.TabIndex = 8;
            this.buttonAddAssignedTruck.Text = "Agregar";
            this.buttonAddAssignedTruck.UseVisualStyleBackColor = true;
            this.buttonAddAssignedTruck.Click += new System.EventHandler(this.buttonAddAssignedTruck_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(95, 450);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "ID Chofer";
            // 
            // txtBoxIDAssignedTrucker
            // 
            this.txtBoxIDAssignedTrucker.Location = new System.Drawing.Point(98, 479);
            this.txtBoxIDAssignedTrucker.Name = "txtBoxIDAssignedTrucker";
            this.txtBoxIDAssignedTrucker.Size = new System.Drawing.Size(44, 20);
            this.txtBoxIDAssignedTrucker.TabIndex = 18;
            // 
            // buttonBack
            // 
            this.buttonBack.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBack.Location = new System.Drawing.Point(12, 12);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(96, 26);
            this.buttonBack.TabIndex = 21;
            this.buttonBack.Text = "Volver";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // txtBoxVolumeTruck
            // 
            this.txtBoxVolumeTruck.Location = new System.Drawing.Point(593, 479);
            this.txtBoxVolumeTruck.Name = "txtBoxVolumeTruck";
            this.txtBoxVolumeTruck.Size = new System.Drawing.Size(61, 20);
            this.txtBoxVolumeTruck.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(588, 450);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Volumen de camion:";
            // 
            // txtBoxActiveTruck
            // 
            this.txtBoxActiveTruck.Location = new System.Drawing.Point(709, 479);
            this.txtBoxActiveTruck.Name = "txtBoxActiveTruck";
            this.txtBoxActiveTruck.Size = new System.Drawing.Size(31, 20);
            this.txtBoxActiveTruck.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(697, 450);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Activo (1-0):";
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(499, 516);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(68, 26);
            this.buttonEdit.TabIndex = 26;
            this.buttonEdit.Text = "Editar";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // txtBoxTruckID
            // 
            this.txtBoxTruckID.Location = new System.Drawing.Point(425, 479);
            this.txtBoxTruckID.Name = "txtBoxTruckID";
            this.txtBoxTruckID.Size = new System.Drawing.Size(31, 20);
            this.txtBoxTruckID.TabIndex = 27;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(422, 450);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "ID de camion:";
            // 
            // TruckManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(75)))), ((int)(((byte)(96)))));
            this.ClientSize = new System.Drawing.Size(773, 559);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtBoxTruckID);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtBoxActiveTruck);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtBoxVolumeTruck);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.txtBoxIDAssignedTrucker);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBoxIDAssignedTruck);
            this.Controls.Add(this.dataGridViewAssignTruck);
            this.Controls.Add(this.buttonRefreshAssignTrucker);
            this.Controls.Add(this.buttonDeleteAssignedTruck);
            this.Controls.Add(this.buttonAddAssignedTruck);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxWeightTruck);
            this.Controls.Add(this.dataGridViewAddTruck);
            this.Controls.Add(this.buttonRefreshTruck);
            this.Controls.Add(this.buttonDeleteTruck);
            this.Controls.Add(this.buttonAddTruck);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TruckManagerForm";
            this.Text = "UserManagerForm";
            this.Load += new System.EventHandler(this.TruckManagerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAddTruck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAssignTruck)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAddTruck;
        private System.Windows.Forms.Button buttonDeleteTruck;
        private System.Windows.Forms.Button buttonRefreshTruck;
        private System.Windows.Forms.DataGridView dataGridViewAddTruck;
        private System.Windows.Forms.TextBox txtBoxWeightTruck;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBoxIDAssignedTruck;
        private System.Windows.Forms.DataGridView dataGridViewAssignTruck;
        private System.Windows.Forms.Button buttonRefreshAssignTrucker;
        private System.Windows.Forms.Button buttonDeleteAssignedTruck;
        private System.Windows.Forms.Button buttonAddAssignedTruck;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBoxIDAssignedTrucker;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.TextBox txtBoxVolumeTruck;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBoxActiveTruck;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.TextBox txtBoxTruckID;
        private System.Windows.Forms.Label label9;
    }
}