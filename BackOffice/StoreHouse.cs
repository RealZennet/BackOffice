using capa_logica;
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
    public partial class StoreHouse : Form
    {
        public StoreHouse()
        {
            InitializeComponent();
            RefreshTableAddStoreHouse();
        }

        private void buttonDeleteOperatorFromStoreHouse_Click(object sender, EventArgs e)
        {

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void RefreshTableAddStoreHouse()
        {
            DataTable dataTableStoreHouse = StoreHouseController.Obtener();
            dataGridViewStoreHouses.DataSource = dataTableStoreHouse;
        }

        public void ClearTxtBoxesAddStoreHouse()
        {
            txtBoxStoreHouseStreet.Clear();
            txtBoxStoreHouseDoorNumber.Clear();
            txtBoxStoreHouseCorner.Clear();
            txtBoxStoreHouseActived.Clear();
        }

        private bool ValidateInputsUser()
        {

            if (string.IsNullOrWhiteSpace(txtBoxStoreHouseActived.Text) ||
                string.IsNullOrWhiteSpace(txtBoxStoreHouseCorner.Text) ||
                string.IsNullOrWhiteSpace(txtBoxStoreHouseDoorNumber.Text) ||
                string.IsNullOrWhiteSpace(txtBoxStoreHouseStreet.Text))
            {
                return false;
            }

            return true;
        }

        private void addProduct()
        {
            if (bool.TryParse(txtBoxStoreHouseActived.Text, out bool isActivated))
            {
                StoreHouseController.Create(txtBoxStoreHouseStreet.Text, Int32.Parse(txtBoxStoreHouseDoorNumber.Text), txtBoxStoreHouseCorner.Text, isActivated);
                MessageBox.Show("Almacén agregado");
                RefreshTableAddStoreHouse();
                ClearTxtBoxesAddStoreHouse();
            }
            else
            {
                MessageBox.Show("El valor de activación no es válido. Debe ser 'True' o 'False'.");
            }
        }

        private void buttonAddStoreHouse_Click(object sender, EventArgs e)
        {
            addProduct();
        }

        private void deleteStoreHouse()
        {
            if (dataGridViewStoreHouses.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridViewStoreHouses.SelectedRows[0].Index;
                int id = (int)dataGridViewStoreHouses.Rows[selectedIndex].Cells["id"].Value;
                DataTable dataTableProducts = (DataTable)dataGridViewStoreHouses.DataSource;
                dataTableProducts.Rows.RemoveAt(selectedIndex);
                MessageBox.Show("El almacen fue eliminado!");
                StoreHouseController.DeleteStoreHouse(id);
                dataGridViewStoreHouses.DataSource = dataTableProducts;
                RefreshTableAddStoreHouse();

            }
        }

        private void buttonRefreshStoreHouse_Click(object sender, EventArgs e)
        {
            RefreshTableAddStoreHouse();
        }
    }
}
