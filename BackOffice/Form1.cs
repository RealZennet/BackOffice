using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackOffice
{
    public partial class QuickCarry : Form
    {


        public QuickCarry()
        {
            InitializeComponent();
            customMenus();
        }

        //Variables para controlar la posicion del slide
        public int m, x, y;
        

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        #region generalMenu
        private void customMenus()
        {
            managementPanel.Visible = false;
            productsAndLotsPanel.Visible = false;
            usersPanel.Visible = false;
        }

        private void hideMenus()
        {
            if (productsAndLotsPanel.Visible == true)
            {
                productsAndLotsPanel.Visible = false;
            }
            if (usersPanel.Visible == true)
            {
                usersPanel.Visible = false;
            }
            if (managementPanel.Visible == true)
            {
                managementPanel.Visible = false;
            }
        }

        private void showMenus(Panel subMenu)
        {
            if(subMenu.Visible == false)
            {
                hideMenus();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }
        #endregion
        #region topButtons
        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SlidePanel_MouseDown(object sender, MouseEventArgs e)
        {
            m = 1;
            x = e.X;
            y = e.Y;
        }

        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void buttonMaximize_Click(object sender, EventArgs e)
        {

            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }

        }
        #endregion
        #region leftButtonsAndPanel
        private void buttonProducts_Click(object sender, EventArgs e)
        {
            showMenus(productsAndLotsPanel);
        }

        private void buttonUsers_Click(object sender, EventArgs e)
        {
            showMenus(usersPanel);
        }

        private void buttonManagement_Click(object sender, EventArgs e)
        {
            showMenus(managementPanel);
        }

        private void SlidePanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (m == 1)
            {
                this.SetDesktopLocation(MousePosition.X - x, MousePosition.Y - y);
            }
        }
        private void SlidePanel_MouseUp(object sender, MouseEventArgs e)
        {
            m = 0;
        }

        #endregion
        private void buttonProductsManager_Click(object sender, EventArgs e)
        {
            showProductsForm();

        }
        #region loadFormsOnPanel
        private void showProductsForm()
        {
            ProductsForm formProductCtl = new ProductsForm();
            formProductCtl.TopLevel = false;
            panelFormsLoader.Controls.Add(formProductCtl);
            formProductCtl.FormBorderStyle = FormBorderStyle.None;
            formProductCtl.Dock = DockStyle.Fill;
            panelFormsLoader.Tag = formProductCtl;
            formProductCtl.BringToFront();
            formProductCtl.Show();
        }

        #endregion
    }
}
