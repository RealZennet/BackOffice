namespace BackOffice
{
    partial class AssignTypeUser
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonAddTrucker = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.labelUsernameTrucker = new System.Windows.Forms.Label();
            this.txtBoxUsernameTrucker = new System.Windows.Forms.TextBox();
            this.dataGridViewUsers = new System.Windows.Forms.DataGridView();
            this.dataGridViewOperators = new System.Windows.Forms.DataGridView();
            this.buttonAddOperator = new System.Windows.Forms.Button();
            this.buttonDeleteOperator = new System.Windows.Forms.Button();
            this.labelUsernameOperator = new System.Windows.Forms.Label();
            this.txtBoxUsernameOperator = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOperators)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(17, 12);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(89, 26);
            this.buttonBack.TabIndex = 36;
            this.buttonBack.Text = "Volver";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonAddTrucker
            // 
            this.buttonAddTrucker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAddTrucker.Location = new System.Drawing.Point(19, 510);
            this.buttonAddTrucker.Name = "buttonAddTrucker";
            this.buttonAddTrucker.Size = new System.Drawing.Size(71, 26);
            this.buttonAddTrucker.TabIndex = 35;
            this.buttonAddTrucker.Text = "Agregar";
            this.buttonAddTrucker.UseVisualStyleBackColor = true;
            this.buttonAddTrucker.Click += new System.EventHandler(this.buttonAddTrucker_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonDelete.Location = new System.Drawing.Point(114, 510);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(71, 26);
            this.buttonDelete.TabIndex = 34;
            this.buttonDelete.Text = "Eliminar";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(114, 12);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(77, 26);
            this.buttonRefresh.TabIndex = 33;
            this.buttonRefresh.Text = "Recargar";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // labelUsernameTrucker
            // 
            this.labelUsernameTrucker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelUsernameTrucker.AutoSize = true;
            this.labelUsernameTrucker.Location = new System.Drawing.Point(16, 448);
            this.labelUsernameTrucker.Name = "labelUsernameTrucker";
            this.labelUsernameTrucker.Size = new System.Drawing.Size(61, 13);
            this.labelUsernameTrucker.TabIndex = 32;
            this.labelUsernameTrucker.Text = "ID Trucker:";
            // 
            // txtBoxUsernameTrucker
            // 
            this.txtBoxUsernameTrucker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtBoxUsernameTrucker.Location = new System.Drawing.Point(17, 473);
            this.txtBoxUsernameTrucker.Name = "txtBoxUsernameTrucker";
            this.txtBoxUsernameTrucker.Size = new System.Drawing.Size(233, 20);
            this.txtBoxUsernameTrucker.TabIndex = 31;
            // 
            // dataGridViewUsers
            // 
            this.dataGridViewUsers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(47)))), ((int)(((byte)(68)))));
            this.dataGridViewUsers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(84)))), ((int)(((byte)(112)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(84)))), ((int)(((byte)(112)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewUsers.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewUsers.EnableHeadersVisualStyles = false;
            this.dataGridViewUsers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(47)))), ((int)(((byte)(68)))));
            this.dataGridViewUsers.Location = new System.Drawing.Point(17, 44);
            this.dataGridViewUsers.Name = "dataGridViewUsers";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewUsers.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewUsers.Size = new System.Drawing.Size(233, 381);
            this.dataGridViewUsers.TabIndex = 30;
            // 
            // dataGridViewOperators
            // 
            this.dataGridViewOperators.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewOperators.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(47)))), ((int)(((byte)(68)))));
            this.dataGridViewOperators.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(84)))), ((int)(((byte)(112)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewOperators.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridViewOperators.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(84)))), ((int)(((byte)(112)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewOperators.DefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridViewOperators.EnableHeadersVisualStyles = false;
            this.dataGridViewOperators.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(47)))), ((int)(((byte)(68)))));
            this.dataGridViewOperators.Location = new System.Drawing.Point(461, 44);
            this.dataGridViewOperators.Name = "dataGridViewOperators";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewOperators.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridViewOperators.Size = new System.Drawing.Size(241, 381);
            this.dataGridViewOperators.TabIndex = 37;
            // 
            // buttonAddOperator
            // 
            this.buttonAddOperator.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddOperator.Location = new System.Drawing.Point(461, 510);
            this.buttonAddOperator.Name = "buttonAddOperator";
            this.buttonAddOperator.Size = new System.Drawing.Size(71, 26);
            this.buttonAddOperator.TabIndex = 41;
            this.buttonAddOperator.Text = "Agregar";
            this.buttonAddOperator.UseVisualStyleBackColor = true;
            this.buttonAddOperator.Click += new System.EventHandler(this.buttonAddOperator_Click);
            // 
            // buttonDeleteOperator
            // 
            this.buttonDeleteOperator.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDeleteOperator.Location = new System.Drawing.Point(556, 510);
            this.buttonDeleteOperator.Name = "buttonDeleteOperator";
            this.buttonDeleteOperator.Size = new System.Drawing.Size(71, 26);
            this.buttonDeleteOperator.TabIndex = 40;
            this.buttonDeleteOperator.Text = "Eliminar";
            this.buttonDeleteOperator.UseVisualStyleBackColor = true;
            this.buttonDeleteOperator.Click += new System.EventHandler(this.buttonDeleteOperator_Click);
            // 
            // labelUsernameOperator
            // 
            this.labelUsernameOperator.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelUsernameOperator.AutoSize = true;
            this.labelUsernameOperator.Location = new System.Drawing.Point(458, 448);
            this.labelUsernameOperator.Name = "labelUsernameOperator";
            this.labelUsernameOperator.Size = new System.Drawing.Size(65, 13);
            this.labelUsernameOperator.TabIndex = 39;
            this.labelUsernameOperator.Text = "ID Operator:";
            // 
            // txtBoxUsernameOperator
            // 
            this.txtBoxUsernameOperator.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxUsernameOperator.Location = new System.Drawing.Point(459, 473);
            this.txtBoxUsernameOperator.Name = "txtBoxUsernameOperator";
            this.txtBoxUsernameOperator.Size = new System.Drawing.Size(243, 20);
            this.txtBoxUsernameOperator.TabIndex = 38;
            // 
            // AssignTypeUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(47)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(773, 559);
            this.Controls.Add(this.buttonAddOperator);
            this.Controls.Add(this.buttonDeleteOperator);
            this.Controls.Add(this.labelUsernameOperator);
            this.Controls.Add(this.txtBoxUsernameOperator);
            this.Controls.Add(this.dataGridViewOperators);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonAddTrucker);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.labelUsernameTrucker);
            this.Controls.Add(this.txtBoxUsernameTrucker);
            this.Controls.Add(this.dataGridViewUsers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AssignTypeUser";
            this.Text = "AssignTypeUser";
            this.Load += new System.EventHandler(this.AssignTypeUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOperators)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonAddTrucker;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Label labelUsernameTrucker;
        private System.Windows.Forms.TextBox txtBoxUsernameTrucker;
        private System.Windows.Forms.DataGridView dataGridViewUsers;
        private System.Windows.Forms.DataGridView dataGridViewOperators;
        private System.Windows.Forms.Button buttonAddOperator;
        private System.Windows.Forms.Button buttonDeleteOperator;
        private System.Windows.Forms.Label labelUsernameOperator;
        private System.Windows.Forms.TextBox txtBoxUsernameOperator;
    }
}