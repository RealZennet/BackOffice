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
    public partial class ShippingManagementForm : Form
    {
        public ShippingManagementForm()
        {
            InitializeComponent();
            RefreshTableShippManagement();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region shippmanagement
        public void RefreshTableShippManagement()
        {
            DataTable dataTableShippManagement = ShippingManagementController.GetAllShippings();
            dataGridViewShippingManagement.DataSource = dataTableShippManagement;
        }

        public void ClearTxtBoxesShippingManagement()
        {
            txtBoxIDBatchShippManagement.Clear();
            txtBoxIDTruckShippManagement.Clear();
        }

        private bool ValidateShippingManagerInputsUser()
        {

            if (string.IsNullOrWhiteSpace(txtBoxIDBatchShippManagement.Text) ||
                string.IsNullOrWhiteSpace(txtBoxIDTruckShippManagement.Text))
            {
                return false;
            }

            return true;
        }

        private void addShippment()
        {
            ShippingManagementController.Create(Int32.Parse(txtBoxIDTruckShippManagement.Text), Int32.Parse(txtBoxIDBatchShippManagement.Text), Convert.ToDateTime(dateTimePickerShippManagement.Text));
            MessageBox.Show("Envio programado");
            RefreshTableShippManagement();
            ClearTxtBoxesShippingManagement();
        }

        private void deleteShippment()
        {
            if (dataGridViewShippingManagement.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridViewShippingManagement.SelectedRows[0].Index;
                int id = (int)dataGridViewShippingManagement.Rows[selectedIndex].Cells["id_lote"].Value;
                DataTable dataTableShippings = (DataTable)dataGridViewShippingManagement.DataSource;
                dataTableShippings.Rows.RemoveAt(selectedIndex);
                MessageBox.Show("El envio fue eliminado!");
                ShippingManagementController.DeleteShipp(id);
                dataGridViewShippingManagement.DataSource = dataTableShippings;
                RefreshTableShippManagement();

            }
        }

        private void buttonAddShipp_Click(object sender, EventArgs e)
        {
            if (ValidateShippingManagerInputsUser())
            {
                addShippment();
            }
            else
            {
                MessageBox.Show("Por favor, complete todos los campos.");
            }
        }

        private void buttonDeleteShipp_Click(object sender, EventArgs e)
        {
            deleteShippment();
        }

        private void buttonRefreshShipps_Click(object sender, EventArgs e)
        {
            RefreshTableShippManagement();
        }
        #endregion shippmanagement


    }
}
