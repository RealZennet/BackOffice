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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle36 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
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
            this.buttonAddTrucker.Location = new System.Drawing.Point(19, 435);
            this.buttonAddTrucker.Name = "buttonAddTrucker";
            this.buttonAddTrucker.Size = new System.Drawing.Size(71, 26);
            this.buttonAddTrucker.TabIndex = 35;
            this.buttonAddTrucker.Text = "Agregar";
            this.buttonAddTrucker.UseVisualStyleBackColor = true;
            this.buttonAddTrucker.Click += new System.EventHandler(this.buttonAddTrucker_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(114, 435);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(71, 26);
            this.buttonDelete.TabIndex = 34;
            this.buttonDelete.Text = "Eliminar";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(236, 435);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(166, 26);
            this.buttonRefresh.TabIndex = 33;
            this.buttonRefresh.Text = "Recargar";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // labelUsernameTrucker
            // 
            this.labelUsernameTrucker.AutoSize = true;
            this.labelUsernameTrucker.Location = new System.Drawing.Point(16, 373);
            this.labelUsernameTrucker.Name = "labelUsernameTrucker";
            this.labelUsernameTrucker.Size = new System.Drawing.Size(61, 13);
            this.labelUsernameTrucker.TabIndex = 32;
            this.labelUsernameTrucker.Text = "ID Trucker:";
            // 
            // txtBoxUsernameTrucker
            // 
            this.txtBoxUsernameTrucker.Location = new System.Drawing.Point(17, 398);
            this.txtBoxUsernameTrucker.Name = "txtBoxUsernameTrucker";
            this.txtBoxUsernameTrucker.Size = new System.Drawing.Size(233, 20);
            this.txtBoxUsernameTrucker.TabIndex = 31;
            // 
            // dataGridViewUsers
            // 
            this.dataGridViewUsers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(47)))), ((int)(((byte)(68)))));
            this.dataGridViewUsers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle31.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(84)))), ((int)(((byte)(112)))));
            dataGridViewCellStyle31.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle31.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle31.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle31.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle31.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle31;
            this.dataGridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle32.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(84)))), ((int)(((byte)(112)))));
            dataGridViewCellStyle32.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle32.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle32.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle32.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle32.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewUsers.DefaultCellStyle = dataGridViewCellStyle32;
            this.dataGridViewUsers.EnableHeadersVisualStyles = false;
            this.dataGridViewUsers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(47)))), ((int)(((byte)(68)))));
            this.dataGridViewUsers.Location = new System.Drawing.Point(17, 44);
            this.dataGridViewUsers.Name = "dataGridViewUsers";
            dataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle33.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle33.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle33.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle33.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle33.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle33.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewUsers.RowHeadersDefaultCellStyle = dataGridViewCellStyle33;
            this.dataGridViewUsers.Size = new System.Drawing.Size(233, 322);
            this.dataGridViewUsers.TabIndex = 30;
            // 
            // dataGridViewOperators
            // 
            this.dataGridViewOperators.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(47)))), ((int)(((byte)(68)))));
            this.dataGridViewOperators.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle34.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(84)))), ((int)(((byte)(112)))));
            dataGridViewCellStyle34.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle34.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle34.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle34.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle34.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewOperators.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle34;
            this.dataGridViewOperators.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle35.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle35.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(84)))), ((int)(((byte)(112)))));
            dataGridViewCellStyle35.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle35.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle35.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle35.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle35.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewOperators.DefaultCellStyle = dataGridViewCellStyle35;
            this.dataGridViewOperators.EnableHeadersVisualStyles = false;
            this.dataGridViewOperators.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(47)))), ((int)(((byte)(68)))));
            this.dataGridViewOperators.Location = new System.Drawing.Point(461, 44);
            this.dataGridViewOperators.Name = "dataGridViewOperators";
            dataGridViewCellStyle36.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle36.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle36.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle36.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle36.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle36.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle36.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewOperators.RowHeadersDefaultCellStyle = dataGridViewCellStyle36;
            this.dataGridViewOperators.Size = new System.Drawing.Size(241, 322);
            this.dataGridViewOperators.TabIndex = 37;
            // 
            // buttonAddOperator
            // 
            this.buttonAddOperator.Location = new System.Drawing.Point(461, 435);
            this.buttonAddOperator.Name = "buttonAddOperator";
            this.buttonAddOperator.Size = new System.Drawing.Size(71, 26);
            this.buttonAddOperator.TabIndex = 41;
            this.buttonAddOperator.Text = "Agregar";
            this.buttonAddOperator.UseVisualStyleBackColor = true;
            this.buttonAddOperator.Click += new System.EventHandler(this.buttonAddOperator_Click);
            // 
            // buttonDeleteOperator
            // 
            this.buttonDeleteOperator.Location = new System.Drawing.Point(556, 435);
            this.buttonDeleteOperator.Name = "buttonDeleteOperator";
            this.buttonDeleteOperator.Size = new System.Drawing.Size(71, 26);
            this.buttonDeleteOperator.TabIndex = 40;
            this.buttonDeleteOperator.Text = "Eliminar";
            this.buttonDeleteOperator.UseVisualStyleBackColor = true;
            this.buttonDeleteOperator.Click += new System.EventHandler(this.buttonDeleteOperator_Click);
            // 
            // labelUsernameOperator
            // 
            this.labelUsernameOperator.AutoSize = true;
            this.labelUsernameOperator.Location = new System.Drawing.Point(458, 373);
            this.labelUsernameOperator.Name = "labelUsernameOperator";
            this.labelUsernameOperator.Size = new System.Drawing.Size(65, 13);
            this.labelUsernameOperator.TabIndex = 39;
            this.labelUsernameOperator.Text = "ID Operator:";
            // 
            // txtBoxUsernameOperator
            // 
            this.txtBoxUsernameOperator.Location = new System.Drawing.Point(459, 398);
            this.txtBoxUsernameOperator.Name = "txtBoxUsernameOperator";
            this.txtBoxUsernameOperator.Size = new System.Drawing.Size(243, 20);
            this.txtBoxUsernameOperator.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label3.Location = new System.Drawing.Point(112, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 42;
            this.label3.Text = "Camionero";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label4.Location = new System.Drawing.Point(552, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 43;
            this.label4.Text = "Operador";
            // 
            // AssignTypeUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(47)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(773, 559);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}