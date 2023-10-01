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
            RefreshTableCarrieManagement();
        }

        private void ShippingManagementForm_Load(object sender, EventArgs e)
        {
            comboBoxStatus.Items.Add("Entregado");
            comboBoxStatus.Items.Add("En Camino");
            comboBoxStatus.Items.Add("Retrasado");
            comboBoxStatus.Items.Add("No Enviado");

            
            comboBoxStatus.SelectedIndex = 3;
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
            try
            {
            ShippingManagementController.Create(Int32.Parse(txtBoxIDTruckShippManagement.Text), Int32.Parse(txtBoxIDBatchShippManagement.Text), Convert.ToDateTime(dateTimePickerShippManagement.Text));
            MessageBox.Show("Envio programado");
            RefreshTableShippManagement();
            ClearTxtBoxesShippingManagement();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void deleteShippment()
        {
            if (dataGridViewShippingManagement.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridViewShippingManagement.SelectedRows[0].Index;
                int id = (int)dataGridViewShippingManagement.Rows[selectedIndex].Cells["ID Camion"].Value;
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

        #region Carries
        public void RefreshTableCarrieManagement()
        {
            DataTable dataTableCarrieManagement = CarryShippmentController.GetAllCarrys();
            dataGridViewCarry.DataSource = dataTableCarrieManagement;
        }

        public void ClearTxtBoxesCarrieManagement()
        {
            txtBoxIDBatchShippManagement.Clear();
            txtBoxIDTruckShippManagement.Clear();
        }

        private bool ValidateCarrieManagementInputsUser()
        {
            if (string.IsNullOrWhiteSpace(txtBoxIDBatchCarrie.Text) ||
                string.IsNullOrWhiteSpace(txtBoxIDTruckCarrie.Text) ||
                string.IsNullOrWhiteSpace(txtBoxIDDestinationCarrie.Text))
            {
                return false;
            }
            return true;
        }

        private void addCarrie()
        {
            try
            {
            string selectedStatus = comboBoxStatus.SelectedItem as string;
            if (ValidateCarrieManagementInputsUser() && !string.IsNullOrWhiteSpace(selectedStatus))
            {
                CarryShippmentController.Create(
                    Int32.Parse(txtBoxIDTruckCarrie.Text),
                    Int32.Parse(txtBoxIDBatchCarrie.Text),
                    Int32.Parse(txtBoxIDDestinationCarrie.Text),
                    selectedStatus.ToString()
                );
                MessageBox.Show("Cargamento programado");
                RefreshTableCarrieManagement();
                ClearTxtBoxesCarrieManagement();
            }
            else if (string.IsNullOrWhiteSpace(selectedStatus))
            {
                MessageBox.Show("Selecciona un estado.");
            }
            else
            {
                MessageBox.Show("Completa todos los campos.");
            }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void deleteCarrie()
        {
            if (dataGridViewCarry.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridViewCarry.SelectedRows[0].Index;
                int id = (int)dataGridViewCarry.Rows[selectedIndex].Cells["ID Camion"].Value;
                DataTable dataTableCarries = (DataTable)dataGridViewCarry.DataSource;
                dataTableCarries.Rows.RemoveAt(selectedIndex);
                MessageBox.Show("El cargamento fue eliminado!");
                CarryShippmentController.DeleteCarry(id);
                dataGridViewCarry.DataSource = dataTableCarries;
                RefreshTableCarrieManagement();

            }
        }

        private void buttonAddCarry_Click(object sender, EventArgs e)
        {
            addCarrie();
        }

        private void buttonDeleteCarry_Click(object sender, EventArgs e)
        {
            deleteCarrie();
        }

        private void buttonRefreshCarry_Click(object sender, EventArgs e)
        {
            RefreshTableCarrieManagement();
        }
        #endregion Carries


    }
}
