namespace BackOffice
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
            this.SlidePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SlidePanel
            // 
            this.SlidePanel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.SlidePanel.Controls.Add(this.buttonMaximize);
            this.SlidePanel.Controls.Add(this.buttonMinimize);
            this.SlidePanel.Controls.Add(this.buttonClose);
            this.SlidePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.SlidePanel.Location = new System.Drawing.Point(0, 0);
            this.SlidePanel.Name = "SlidePanel";
            this.SlidePanel.Size = new System.Drawing.Size(881, 41);
            this.SlidePanel.TabIndex = 0;
            this.SlidePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SlidePanel_MouseDown);
            this.SlidePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SlidePanel_MouseMove);
            this.SlidePanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.SlidePanel_MouseUp);
            // 
            // buttonMaximize
            // 
            this.buttonMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMaximize.Location = new System.Drawing.Point(788, 3);
            this.buttonMaximize.Name = "buttonMaximize";
            this.buttonMaximize.Size = new System.Drawing.Size(42, 29);
            this.buttonMaximize.TabIndex = 2;
            this.buttonMaximize.Text = "▢";
            this.buttonMaximize.UseVisualStyleBackColor = true;
            this.buttonMaximize.Click += new System.EventHandler(this.buttonMaximize_Click);
            // 
            // buttonMinimize
            // 
            this.buttonMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinimize.Location = new System.Drawing.Point(737, 3);
            this.buttonMinimize.Name = "buttonMinimize";
            this.buttonMinimize.Size = new System.Drawing.Size(42, 29);
            this.buttonMinimize.TabIndex = 1;
            this.buttonMinimize.Text = "_";
            this.buttonMinimize.UseVisualStyleBackColor = true;
            this.buttonMinimize.Click += new System.EventHandler(this.buttonMinimize_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Location = new System.Drawing.Point(836, 3);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(42, 29);
            this.buttonClose.TabIndex = 0;
            this.buttonClose.Text = "X";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // QuickCarry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(881, 484);
            this.ControlBox = false;
            this.Controls.Add(this.SlidePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "QuickCarry";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SlidePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SlidePanel;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonMinimize;
        private System.Windows.Forms.Button buttonMaximize;
    }
}

