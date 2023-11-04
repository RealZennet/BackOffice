﻿namespace BackOffice
{
    partial class LotsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewLots = new System.Windows.Forms.DataGridView();
            this.buttonBack = new System.Windows.Forms.Button();
            this.labelEstimatedDate = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.dateTimePickerShippingDate = new System.Windows.Forms.DateTimePicker();
            this.txtBoxIDShipp = new System.Windows.Forms.TextBox();
            this.labelIDShippment = new System.Windows.Forms.Label();
            this.labelActivated = new System.Windows.Forms.Label();
            this.txtBoxActivedBatch = new System.Windows.Forms.TextBox();
            this.dateTimePickerBatchManagementTime = new System.Windows.Forms.DateTimePicker();
            this.txtBoxEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLots)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewLots
            // 
            this.dataGridViewLots.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(47)))), ((int)(((byte)(68)))));
            this.dataGridViewLots.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewLots.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(84)))), ((int)(((byte)(112)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewLots.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewLots.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(84)))), ((int)(((byte)(112)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewLots.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewLots.EnableHeadersVisualStyles = false;
            this.dataGridViewLots.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(47)))), ((int)(((byte)(68)))));
            this.dataGridViewLots.Location = new System.Drawing.Point(12, 44);
            this.dataGridViewLots.Name = "dataGridViewLots";
            this.dataGridViewLots.Size = new System.Drawing.Size(480, 503);
            this.dataGridViewLots.TabIndex = 0;
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(12, 12);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(96, 26);
            this.buttonBack.TabIndex = 1;
            this.buttonBack.Text = "Volver";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // labelEstimatedDate
            // 
            this.labelEstimatedDate.AutoSize = true;
            this.labelEstimatedDate.BackColor = System.Drawing.Color.Transparent;
            this.labelEstimatedDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.labelEstimatedDate.Location = new System.Drawing.Point(527, 101);
            this.labelEstimatedDate.Name = "labelEstimatedDate";
            this.labelEstimatedDate.Size = new System.Drawing.Size(181, 17);
            this.labelEstimatedDate.TabIndex = 3;
            this.labelEstimatedDate.Text = "Fecha estimada de entrega";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(530, 261);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(68, 26);
            this.buttonAdd.TabIndex = 5;
            this.buttonAdd.Text = "Agregar";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(604, 261);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(68, 26);
            this.buttonDelete.TabIndex = 6;
            this.buttonDelete.Text = "Eliminar";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(678, 261);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(68, 26);
            this.buttonRefresh.TabIndex = 7;
            this.buttonRefresh.Text = "Recargar";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // dateTimePickerShippingDate
            // 
            this.dateTimePickerShippingDate.Location = new System.Drawing.Point(530, 130);
            this.dateTimePickerShippingDate.Name = "dateTimePickerShippingDate";
            this.dateTimePickerShippingDate.Size = new System.Drawing.Size(216, 20);
            this.dateTimePickerShippingDate.TabIndex = 8;
            // 
            // txtBoxIDShipp
            // 
            this.txtBoxIDShipp.Location = new System.Drawing.Point(530, 196);
            this.txtBoxIDShipp.Name = "txtBoxIDShipp";
            this.txtBoxIDShipp.Size = new System.Drawing.Size(50, 20);
            this.txtBoxIDShipp.TabIndex = 9;
            // 
            // labelIDShippment
            // 
            this.labelIDShippment.AutoSize = true;
            this.labelIDShippment.BackColor = System.Drawing.Color.Transparent;
            this.labelIDShippment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.labelIDShippment.Location = new System.Drawing.Point(527, 176);
            this.labelIDShippment.Name = "labelIDShippment";
            this.labelIDShippment.Size = new System.Drawing.Size(60, 17);
            this.labelIDShippment.TabIndex = 10;
            this.labelIDShippment.Text = "ID Envio";
            // 
            // labelActivated
            // 
            this.labelActivated.AutoSize = true;
            this.labelActivated.BackColor = System.Drawing.Color.Transparent;
            this.labelActivated.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.labelActivated.Location = new System.Drawing.Point(617, 176);
            this.labelActivated.Name = "labelActivated";
            this.labelActivated.Size = new System.Drawing.Size(144, 17);
            this.labelActivated.TabIndex = 12;
            this.labelActivated.Text = "Activado (true - false)";
            // 
            // txtBoxActivedBatch
            // 
            this.txtBoxActivedBatch.Location = new System.Drawing.Point(658, 196);
            this.txtBoxActivedBatch.Name = "txtBoxActivedBatch";
            this.txtBoxActivedBatch.Size = new System.Drawing.Size(50, 20);
            this.txtBoxActivedBatch.TabIndex = 11;
            // 
            // dateTimePickerBatchManagementTime
            // 
            this.dateTimePickerBatchManagementTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerBatchManagementTime.Location = new System.Drawing.Point(530, 153);
            this.dateTimePickerBatchManagementTime.Name = "dateTimePickerBatchManagementTime";
            this.dateTimePickerBatchManagementTime.Size = new System.Drawing.Size(196, 20);
            this.dateTimePickerBatchManagementTime.TabIndex = 84;
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.Location = new System.Drawing.Point(530, 64);
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.Size = new System.Drawing.Size(216, 20);
            this.txtBoxEmail.TabIndex = 85;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label5.Location = new System.Drawing.Point(527, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 17);
            this.label5.TabIndex = 86;
            this.label5.Text = "Email";
            // 
            // LotsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(47)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(773, 559);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBoxEmail);
            this.Controls.Add(this.dateTimePickerBatchManagementTime);
            this.Controls.Add(this.labelActivated);
            this.Controls.Add(this.txtBoxActivedBatch);
            this.Controls.Add(this.labelIDShippment);
            this.Controls.Add(this.txtBoxIDShipp);
            this.Controls.Add(this.dateTimePickerShippingDate);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelEstimatedDate);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.dataGridViewLots);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LotsForm";
            this.Text = "LotsForm";
            this.Load += new System.EventHandler(this.LotsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLots)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewLots;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label labelEstimatedDate;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.DateTimePicker dateTimePickerShippingDate;
        private System.Windows.Forms.TextBox txtBoxIDShipp;
        private System.Windows.Forms.Label labelIDShippment;
        private System.Windows.Forms.Label labelActivated;
        private System.Windows.Forms.TextBox txtBoxActivedBatch;
        private System.Windows.Forms.DateTimePicker dateTimePickerBatchManagementTime;
        private System.Windows.Forms.TextBox txtBoxEmail;
        private System.Windows.Forms.Label label5;
    }
}