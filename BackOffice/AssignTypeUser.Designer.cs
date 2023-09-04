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
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonAddTrucker = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxUsernameTrucker = new System.Windows.Forms.TextBox();
            this.dataGridViewUsers = new System.Windows.Forms.DataGridView();
            this.dataGridViewOperators = new System.Windows.Forms.DataGridView();
            this.buttonAddOperator = new System.Windows.Forms.Button();
            this.buttonDeleteOperator = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 373);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Username:";
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
            this.dataGridViewUsers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(75)))), ((int)(((byte)(96)))));
            this.dataGridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsers.Location = new System.Drawing.Point(17, 44);
            this.dataGridViewUsers.Name = "dataGridViewUsers";
            this.dataGridViewUsers.Size = new System.Drawing.Size(233, 322);
            this.dataGridViewUsers.TabIndex = 30;
            // 
            // dataGridViewOperators
            // 
            this.dataGridViewOperators.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(75)))), ((int)(((byte)(96)))));
            this.dataGridViewOperators.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOperators.Location = new System.Drawing.Point(461, 44);
            this.dataGridViewOperators.Name = "dataGridViewOperators";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(458, 373);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "Username:";
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
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(75)))), ((int)(((byte)(96)))));
            this.ClientSize = new System.Drawing.Size(773, 559);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonAddOperator);
            this.Controls.Add(this.buttonDeleteOperator);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxUsernameOperator);
            this.Controls.Add(this.dataGridViewOperators);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonAddTrucker);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxUsernameTrucker;
        private System.Windows.Forms.DataGridView dataGridViewUsers;
        private System.Windows.Forms.DataGridView dataGridViewOperators;
        private System.Windows.Forms.Button buttonAddOperator;
        private System.Windows.Forms.Button buttonDeleteOperator;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxUsernameOperator;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}