﻿namespace BackOffice
{
    partial class QuickCarry
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.SlidePanel = new System.Windows.Forms.Panel();
            this.buttonMaximize = new System.Windows.Forms.Button();
            this.buttonMinimize = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.leftPanelContainer = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.buttonProducts = new System.Windows.Forms.Button();
            this.productsPanel = new System.Windows.Forms.Panel();
            this.buttonProductsManager = new System.Windows.Forms.Button();
            this.buttonUsers = new System.Windows.Forms.Button();
            this.buttonLotesManager = new System.Windows.Forms.Button();
            this.usersPanel = new System.Windows.Forms.Panel();
            this.buttonUsersManager = new System.Windows.Forms.Button();
            this.buttonManagement = new System.Windows.Forms.Button();
            this.managementPanel = new System.Windows.Forms.Panel();
            this.buttonShippingManager = new System.Windows.Forms.Button();
            this.buttonTrucksManager = new System.Windows.Forms.Button();
            this.wareHouseButton = new System.Windows.Forms.Button();
            this.SlidePanel.SuspendLayout();
            this.leftPanelContainer.SuspendLayout();
            this.productsPanel.SuspendLayout();
            this.usersPanel.SuspendLayout();
            this.managementPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SlidePanel
            // 
            this.SlidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(192)))), ((int)(((byte)(208)))));
            this.SlidePanel.Controls.Add(this.buttonMaximize);
            this.SlidePanel.Controls.Add(this.buttonMinimize);
            this.SlidePanel.Controls.Add(this.buttonClose);
            this.SlidePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.SlidePanel.Location = new System.Drawing.Point(0, 0);
            this.SlidePanel.Name = "SlidePanel";
            this.SlidePanel.Size = new System.Drawing.Size(1037, 41);
            this.SlidePanel.TabIndex = 0;
            this.SlidePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SlidePanel_MouseDown);
            this.SlidePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SlidePanel_MouseMove);
            this.SlidePanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.SlidePanel_MouseUp);
            // 
            // buttonMaximize
            // 
            this.buttonMaximize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(107)))), ((int)(((byte)(147)))));
            this.buttonMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMaximize.Location = new System.Drawing.Point(939, 3);
            this.buttonMaximize.Name = "buttonMaximize";
            this.buttonMaximize.Size = new System.Drawing.Size(42, 29);
            this.buttonMaximize.TabIndex = 2;
            this.buttonMaximize.Text = "▢";
            this.buttonMaximize.UseVisualStyleBackColor = false;
            this.buttonMaximize.Click += new System.EventHandler(this.buttonMaximize_Click);
            // 
            // buttonMinimize
            // 
            this.buttonMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(107)))), ((int)(((byte)(147)))));
            this.buttonMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinimize.Location = new System.Drawing.Point(888, 3);
            this.buttonMinimize.Name = "buttonMinimize";
            this.buttonMinimize.Size = new System.Drawing.Size(42, 29);
            this.buttonMinimize.TabIndex = 1;
            this.buttonMinimize.Text = "_";
            this.buttonMinimize.UseVisualStyleBackColor = false;
            this.buttonMinimize.Click += new System.EventHandler(this.buttonMinimize_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(107)))), ((int)(((byte)(147)))));
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Location = new System.Drawing.Point(987, 3);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(42, 29);
            this.buttonClose.TabIndex = 0;
            this.buttonClose.Text = "X";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // leftPanelContainer
            // 
            this.leftPanelContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(80)))), ((int)(((byte)(96)))));
            this.leftPanelContainer.Controls.Add(this.managementPanel);
            this.leftPanelContainer.Controls.Add(this.buttonManagement);
            this.leftPanelContainer.Controls.Add(this.usersPanel);
            this.leftPanelContainer.Controls.Add(this.buttonUsers);
            this.leftPanelContainer.Controls.Add(this.productsPanel);
            this.leftPanelContainer.Controls.Add(this.buttonProducts);
            this.leftPanelContainer.Controls.Add(this.panelLogo);
            this.leftPanelContainer.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanelContainer.Location = new System.Drawing.Point(0, 41);
            this.leftPanelContainer.Name = "leftPanelContainer";
            this.leftPanelContainer.Size = new System.Drawing.Size(250, 640);
            this.leftPanelContainer.TabIndex = 1;
            // 
            // panelLogo
            // 
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(250, 100);
            this.panelLogo.TabIndex = 0;
            // 
            // buttonProducts
            // 
            this.buttonProducts.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonProducts.FlatAppearance.BorderSize = 0;
            this.buttonProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProducts.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonProducts.Location = new System.Drawing.Point(0, 100);
            this.buttonProducts.Name = "buttonProducts";
            this.buttonProducts.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonProducts.Size = new System.Drawing.Size(250, 45);
            this.buttonProducts.TabIndex = 1;
            this.buttonProducts.Text = "Distribucion de productos y lotes";
            this.buttonProducts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonProducts.UseVisualStyleBackColor = true;
            // 
            // productsPanel
            // 
            this.productsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(96)))));
            this.productsPanel.Controls.Add(this.buttonLotesManager);
            this.productsPanel.Controls.Add(this.buttonProductsManager);
            this.productsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.productsPanel.Location = new System.Drawing.Point(0, 145);
            this.productsPanel.Name = "productsPanel";
            this.productsPanel.Size = new System.Drawing.Size(250, 102);
            this.productsPanel.TabIndex = 2;
            // 
            // buttonProductsManager
            // 
            this.buttonProductsManager.FlatAppearance.BorderSize = 0;
            this.buttonProductsManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProductsManager.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonProductsManager.Location = new System.Drawing.Point(0, 7);
            this.buttonProductsManager.Name = "buttonProductsManager";
            this.buttonProductsManager.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.buttonProductsManager.Size = new System.Drawing.Size(250, 40);
            this.buttonProductsManager.TabIndex = 0;
            this.buttonProductsManager.Text = "Gestionar Productos";
            this.buttonProductsManager.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonProductsManager.UseVisualStyleBackColor = true;
            // 
            // buttonUsers
            // 
            this.buttonUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonUsers.FlatAppearance.BorderSize = 0;
            this.buttonUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUsers.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonUsers.Location = new System.Drawing.Point(0, 247);
            this.buttonUsers.Name = "buttonUsers";
            this.buttonUsers.Size = new System.Drawing.Size(250, 45);
            this.buttonUsers.TabIndex = 3;
            this.buttonUsers.Text = "Usuarios";
            this.buttonUsers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonUsers.UseVisualStyleBackColor = true;
            // 
            // buttonLotesManager
            // 
            this.buttonLotesManager.FlatAppearance.BorderSize = 0;
            this.buttonLotesManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLotesManager.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonLotesManager.Location = new System.Drawing.Point(0, 53);
            this.buttonLotesManager.Name = "buttonLotesManager";
            this.buttonLotesManager.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.buttonLotesManager.Size = new System.Drawing.Size(250, 40);
            this.buttonLotesManager.TabIndex = 1;
            this.buttonLotesManager.Text = "Gestionar Lotes";
            this.buttonLotesManager.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLotesManager.UseVisualStyleBackColor = true;
            // 
            // usersPanel
            // 
            this.usersPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(96)))));
            this.usersPanel.Controls.Add(this.buttonUsersManager);
            this.usersPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.usersPanel.Location = new System.Drawing.Point(0, 292);
            this.usersPanel.Name = "usersPanel";
            this.usersPanel.Size = new System.Drawing.Size(250, 70);
            this.usersPanel.TabIndex = 4;
            // 
            // buttonUsersManager
            // 
            this.buttonUsersManager.FlatAppearance.BorderSize = 0;
            this.buttonUsersManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUsersManager.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonUsersManager.Location = new System.Drawing.Point(0, 7);
            this.buttonUsersManager.Name = "buttonUsersManager";
            this.buttonUsersManager.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.buttonUsersManager.Size = new System.Drawing.Size(250, 40);
            this.buttonUsersManager.TabIndex = 0;
            this.buttonUsersManager.Text = "Gestionar Usuarios";
            this.buttonUsersManager.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonUsersManager.UseVisualStyleBackColor = true;
            // 
            // buttonManagement
            // 
            this.buttonManagement.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonManagement.FlatAppearance.BorderSize = 0;
            this.buttonManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonManagement.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonManagement.Location = new System.Drawing.Point(0, 362);
            this.buttonManagement.Name = "buttonManagement";
            this.buttonManagement.Size = new System.Drawing.Size(250, 45);
            this.buttonManagement.TabIndex = 5;
            this.buttonManagement.Text = "Gerencia";
            this.buttonManagement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonManagement.UseVisualStyleBackColor = true;
            // 
            // managementPanel
            // 
            this.managementPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(96)))));
            this.managementPanel.Controls.Add(this.wareHouseButton);
            this.managementPanel.Controls.Add(this.buttonTrucksManager);
            this.managementPanel.Controls.Add(this.buttonShippingManager);
            this.managementPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.managementPanel.Location = new System.Drawing.Point(0, 407);
            this.managementPanel.Name = "managementPanel";
            this.managementPanel.Size = new System.Drawing.Size(250, 152);
            this.managementPanel.TabIndex = 6;
            // 
            // buttonShippingManager
            // 
            this.buttonShippingManager.FlatAppearance.BorderSize = 0;
            this.buttonShippingManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonShippingManager.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonShippingManager.Location = new System.Drawing.Point(0, 7);
            this.buttonShippingManager.Name = "buttonShippingManager";
            this.buttonShippingManager.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.buttonShippingManager.Size = new System.Drawing.Size(250, 40);
            this.buttonShippingManager.TabIndex = 0;
            this.buttonShippingManager.Text = "Gestionar Envios";
            this.buttonShippingManager.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonShippingManager.UseVisualStyleBackColor = true;
            // 
            // buttonTrucksManager
            // 
            this.buttonTrucksManager.FlatAppearance.BorderSize = 0;
            this.buttonTrucksManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTrucksManager.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonTrucksManager.Location = new System.Drawing.Point(0, 53);
            this.buttonTrucksManager.Name = "buttonTrucksManager";
            this.buttonTrucksManager.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.buttonTrucksManager.Size = new System.Drawing.Size(250, 40);
            this.buttonTrucksManager.TabIndex = 0;
            this.buttonTrucksManager.Text = "Gestionar Camiones";
            this.buttonTrucksManager.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTrucksManager.UseVisualStyleBackColor = true;
            // 
            // wareHouseButton
            // 
            this.wareHouseButton.FlatAppearance.BorderSize = 0;
            this.wareHouseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.wareHouseButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.wareHouseButton.Location = new System.Drawing.Point(0, 99);
            this.wareHouseButton.Name = "wareHouseButton";
            this.wareHouseButton.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.wareHouseButton.Size = new System.Drawing.Size(250, 40);
            this.wareHouseButton.TabIndex = 2;
            this.wareHouseButton.Text = "Gestionar Almacenes";
            this.wareHouseButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.wareHouseButton.UseVisualStyleBackColor = true;
            // 
            // QuickCarry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(75)))), ((int)(((byte)(96)))));
            this.ClientSize = new System.Drawing.Size(1037, 681);
            this.ControlBox = false;
            this.Controls.Add(this.leftPanelContainer);
            this.Controls.Add(this.SlidePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "QuickCarry";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SlidePanel.ResumeLayout(false);
            this.leftPanelContainer.ResumeLayout(false);
            this.productsPanel.ResumeLayout(false);
            this.usersPanel.ResumeLayout(false);
            this.managementPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SlidePanel;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonMinimize;
        private System.Windows.Forms.Button buttonMaximize;
        private System.Windows.Forms.Panel leftPanelContainer;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button buttonProducts;
        private System.Windows.Forms.Panel productsPanel;
        private System.Windows.Forms.Button buttonProductsManager;
        private System.Windows.Forms.Button buttonUsers;
        private System.Windows.Forms.Button buttonLotesManager;
        private System.Windows.Forms.Panel usersPanel;
        private System.Windows.Forms.Button buttonUsersManager;
        private System.Windows.Forms.Panel managementPanel;
        private System.Windows.Forms.Button buttonShippingManager;
        private System.Windows.Forms.Button buttonManagement;
        private System.Windows.Forms.Button buttonTrucksManager;
        private System.Windows.Forms.Button wareHouseButton;
    }
}

