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
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        }

        //Variables para controlar el slide de la ventana.
        public int m, x, y;
        

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        #region generalMenu
        private void customMenus()
        {
            managementPanel.Visible = false;
            productsAndLotsPanel.Visible = false;
        }

        private void hideMenus()
        {
            if (productsAndLotsPanel.Visible == true)
            {
                productsAndLotsPanel.Visible = false;
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
        #region leftButtonsAndPanel
        private void buttonProducts_Click(object sender, EventArgs e)
        {
            showMenus(productsAndLotsPanel);
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

        private void showAssignedProducts()
        {
            AssignProductsForm formAssignProductCtl = new AssignProductsForm();
            formAssignProductCtl.TopLevel = false;
            panelFormsLoader.Controls.Add(formAssignProductCtl);
            formAssignProductCtl.FormBorderStyle = FormBorderStyle.None;
            formAssignProductCtl.Dock = DockStyle.Fill;
            panelFormsLoader.Tag = formAssignProductCtl;
            formAssignProductCtl.BringToFront();
            formAssignProductCtl.Show();
        }

        private void showUsers()
        {
            UsersForms formUsersCtl = new UsersForms();
            formUsersCtl.TopLevel = false;
            panelFormsLoader.Controls.Add(formUsersCtl);
            formUsersCtl.FormBorderStyle = FormBorderStyle.None;
            formUsersCtl.Dock = DockStyle.Fill;
            panelFormsLoader.Tag = formUsersCtl;
            formUsersCtl.BringToFront();
            formUsersCtl.Show();
        }
        private void showTruckManager()
        {
            TruckManagerForm formTruckCtl = new TruckManagerForm();
            formTruckCtl.TopLevel = false;
            panelFormsLoader.Controls.Add(formTruckCtl);
            formTruckCtl.FormBorderStyle = FormBorderStyle.None;
            formTruckCtl.Dock = DockStyle.Fill;
            panelFormsLoader.Tag = formTruckCtl;
            formTruckCtl.BringToFront();
            formTruckCtl.Show();

        }

        private void showUserTypeAssign()
        {
            AssignTypeUser formTruckCtl = new AssignTypeUser();
            formTruckCtl.TopLevel = false;
            panelFormsLoader.Controls.Add(formTruckCtl);
            formTruckCtl.FormBorderStyle = FormBorderStyle.None;
            formTruckCtl.Dock = DockStyle.Fill;
            panelFormsLoader.Tag = formTruckCtl;
            formTruckCtl.BringToFront();
            formTruckCtl.Show();

        }

        private void buttonAssignProducts_Click(object sender, EventArgs e)
        {
            showAssignedProducts();
        }

        private void panelFormsLoader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonUsersManager_Click(object sender, EventArgs e)
        {
            showUsers();
        }

        private void buttonTrucksManager_Click(object sender, EventArgs e)
        {
            showTruckManager();
        }

        private void buttonUsersAssign_Click(object sender, EventArgs e)
        {
            showUserTypeAssign();
        }

        private void ButtonStoreHouseManagement_Click(object sender, EventArgs e)
        {
            showStoreHouseManagementForm();
        }

        private void showStoreHouseManagementForm()
        {
            StoreHouse formStoreHouseCtl = new StoreHouse();
            formStoreHouseCtl.TopLevel = false;
            panelFormsLoader.Controls.Add(formStoreHouseCtl);
            formStoreHouseCtl.FormBorderStyle = FormBorderStyle.None;
            formStoreHouseCtl.Dock = DockStyle.Fill;
            panelFormsLoader.Tag = formStoreHouseCtl;
            formStoreHouseCtl.BringToFront();
            formStoreHouseCtl.Show();
        }

        #endregion

        #region LotsButton
        private void buttonLotesManager_Click(object sender, EventArgs e)
        {
            showLotsForm();
        }

        private void showLotsForm()
        {
            LotsForm formLotsCtl = new LotsForm();
            formLotsCtl.TopLevel = false;
            panelFormsLoader.Controls.Add(formLotsCtl);
            formLotsCtl.FormBorderStyle = FormBorderStyle.None;
            formLotsCtl.Dock = DockStyle.Fill;
            panelFormsLoader.Tag = formLotsCtl;
            formLotsCtl.BringToFront();
            formLotsCtl.Show();
        }

        #endregion
    }
}
