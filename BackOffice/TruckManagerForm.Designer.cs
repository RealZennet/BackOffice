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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonAddTruck = new System.Windows.Forms.Button();
            this.buttonRefreshTruck = new System.Windows.Forms.Button();
            this.dataGridViewAddTruck = new System.Windows.Forms.DataGridView();
            this.txtBoxWeightTruck = new System.Windows.Forms.TextBox();
            this.labelTruckWeight = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelIDTruck = new System.Windows.Forms.Label();
            this.txtBoxIDAssignedTruck = new System.Windows.Forms.TextBox();
            this.dataGridViewAssignTruck = new System.Windows.Forms.DataGridView();
            this.buttonRefreshAssignTrucker = new System.Windows.Forms.Button();
            this.buttonDeleteAssignedTruck = new System.Windows.Forms.Button();
            this.buttonAddAssignedTruck = new System.Windows.Forms.Button();
            this.labelIDTrucker = new System.Windows.Forms.Label();
            this.txtBoxIDAssignedTrucker = new System.Windows.Forms.TextBox();
            this.buttonBack = new System.Windows.Forms.Button();
            this.txtBoxVolumeTruck = new System.Windows.Forms.TextBox();
            this.labelTruckVolume = new System.Windows.Forms.Label();
            this.txtBoxActiveTruck = new System.Windows.Forms.TextBox();
            this.labelActived = new System.Windows.Forms.Label();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDeleteTruck = new System.Windows.Forms.Button();
            this.labelIDTruck2 = new System.Windows.Forms.Label();
            this.txtBoxTruckID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAddTruck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAssignTruck)).BeginInit();
            this.SuspendLayout();
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
            this.dataGridViewAddTruck.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(47)))), ((int)(((byte)(68)))));
            this.dataGridViewAddTruck.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewAddTruck.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(84)))), ((int)(((byte)(112)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAddTruck.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewAddTruck.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(84)))), ((int)(((byte)(112)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewAddTruck.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewAddTruck.EnableHeadersVisualStyles = false;
            this.dataGridViewAddTruck.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(47)))), ((int)(((byte)(68)))));
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
            // labelTruckWeight
            // 
            this.labelTruckWeight.AutoSize = true;
            this.labelTruckWeight.Location = new System.Drawing.Point(496, 450);
            this.labelTruckWeight.Name = "labelTruckWeight";
            this.labelTruckWeight.Size = new System.Drawing.Size(86, 13);
            this.labelTruckWeight.TabIndex = 6;
            this.labelTruckWeight.Text = "Peso de camion:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.label3.Location = new System.Drawing.Point(534, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Agregar camion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.label4.Location = new System.Drawing.Point(94, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Asignar camion";
            // 
            // labelIDTruck
            // 
            this.labelIDTruck.AutoSize = true;
            this.labelIDTruck.Location = new System.Drawing.Point(23, 450);
            this.labelIDTruck.Name = "labelIDTruck";
            this.labelIDTruck.Size = new System.Drawing.Size(56, 13);
            this.labelIDTruck.TabIndex = 13;
            this.labelIDTruck.Text = "ID Camion";
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
            this.dataGridViewAssignTruck.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(47)))), ((int)(((byte)(68)))));
            this.dataGridViewAssignTruck.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewAssignTruck.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(84)))), ((int)(((byte)(112)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAssignTruck.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewAssignTruck.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(84)))), ((int)(((byte)(112)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewAssignTruck.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewAssignTruck.EnableHeadersVisualStyles = false;
            this.dataGridViewAssignTruck.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(47)))), ((int)(((byte)(68)))));
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
            // labelIDTrucker
            // 
            this.labelIDTrucker.AutoSize = true;
            this.labelIDTrucker.Location = new System.Drawing.Point(95, 450);
            this.labelIDTrucker.Name = "labelIDTrucker";
            this.labelIDTrucker.Size = new System.Drawing.Size(52, 13);
            this.labelIDTrucker.TabIndex = 15;
            this.labelIDTrucker.Text = "ID Chofer";
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
            // labelTruckVolume
            // 
            this.labelTruckVolume.AutoSize = true;
            this.labelTruckVolume.Location = new System.Drawing.Point(588, 450);
            this.labelTruckVolume.Name = "labelTruckVolume";
            this.labelTruckVolume.Size = new System.Drawing.Size(103, 13);
            this.labelTruckVolume.TabIndex = 23;
            this.labelTruckVolume.Text = "Volumen de camion:";
            // 
            // txtBoxActiveTruck
            // 
            this.txtBoxActiveTruck.Location = new System.Drawing.Point(709, 479);
            this.txtBoxActiveTruck.Name = "txtBoxActiveTruck";
            this.txtBoxActiveTruck.Size = new System.Drawing.Size(31, 20);
            this.txtBoxActiveTruck.TabIndex = 24;
            // 
            // labelActived
            // 
            this.labelActived.AutoSize = true;
            this.labelActived.Location = new System.Drawing.Point(697, 450);
            this.labelActived.Name = "labelActived";
            this.labelActived.Size = new System.Drawing.Size(64, 13);
            this.labelActived.TabIndex = 25;
            this.labelActived.Text = "Activo (1-0):";
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
            // labelIDTruck2
            // 
            this.labelIDTruck2.AutoSize = true;
            this.labelIDTruck2.Location = new System.Drawing.Point(422, 450);
            this.labelIDTruck2.Name = "labelIDTruck2";
            this.labelIDTruck2.Size = new System.Drawing.Size(73, 13);
            this.labelIDTruck2.TabIndex = 28;
            this.labelIDTruck2.Text = "ID de camion:";
            // 
            // txtBoxTruckID
            // 
            this.txtBoxTruckID.Location = new System.Drawing.Point(425, 479);
            this.txtBoxTruckID.Name = "txtBoxTruckID";
            this.txtBoxTruckID.Size = new System.Drawing.Size(31, 20);
            this.txtBoxTruckID.TabIndex = 27;
            // 
            // TruckManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(47)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(773, 559);
            this.Controls.Add(this.labelIDTruck2);
            this.Controls.Add(this.txtBoxTruckID);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.labelActived);
            this.Controls.Add(this.txtBoxActiveTruck);
            this.Controls.Add(this.labelTruckVolume);
            this.Controls.Add(this.txtBoxVolumeTruck);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.txtBoxIDAssignedTrucker);
            this.Controls.Add(this.labelIDTrucker);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelIDTruck);
            this.Controls.Add(this.txtBoxIDAssignedTruck);
            this.Controls.Add(this.dataGridViewAssignTruck);
            this.Controls.Add(this.buttonRefreshAssignTrucker);
            this.Controls.Add(this.buttonDeleteAssignedTruck);
            this.Controls.Add(this.buttonAddAssignedTruck);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelTruckWeight);
            this.Controls.Add(this.txtBoxWeightTruck);
            this.Controls.Add(this.dataGridViewAddTruck);
            this.Controls.Add(this.buttonRefreshTruck);
            this.Controls.Add(this.buttonDeleteTruck);
            this.Controls.Add(this.buttonAddTruck);
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
        private System.Windows.Forms.Button buttonAddTruck;
        private System.Windows.Forms.Button buttonRefreshTruck;
        private System.Windows.Forms.DataGridView dataGridViewAddTruck;
        private System.Windows.Forms.TextBox txtBoxWeightTruck;
        private System.Windows.Forms.Label labelTruckWeight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelIDTruck;
        private System.Windows.Forms.TextBox txtBoxIDAssignedTruck;
        private System.Windows.Forms.DataGridView dataGridViewAssignTruck;
        private System.Windows.Forms.Button buttonRefreshAssignTrucker;
        private System.Windows.Forms.Button buttonDeleteAssignedTruck;
        private System.Windows.Forms.Button buttonAddAssignedTruck;
        private System.Windows.Forms.Label labelIDTrucker;
        private System.Windows.Forms.TextBox txtBoxIDAssignedTrucker;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.TextBox txtBoxVolumeTruck;
        private System.Windows.Forms.Label labelTruckVolume;
        private System.Windows.Forms.TextBox txtBoxActiveTruck;
        private System.Windows.Forms.Label labelActived;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDeleteTruck;
        private System.Windows.Forms.Label labelIDTruck2;
        private System.Windows.Forms.TextBox txtBoxTruckID;
    }
}