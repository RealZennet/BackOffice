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
        public event Action LanguageChanged;

        public ShippingManagementForm()
        {
            InitializeComponent();
            RefreshTableShippManagement();
            RefreshTableCarrieManagement();
            QuickCarry mainForm = Application.OpenForms.OfType<QuickCarry>().FirstOrDefault();
            if (mainForm != null)
            {
                mainForm.LanguageChanged += updateLanguage;
            }
            LanguageManager.Initialize(typeof(BackOffice.Languages.Resource_language_spanish));
            LanguageManager.Initialize(typeof(BackOffice.Languages.Resource_language_english));
        }

        private void updateLanguage()
        {
            buttonAddCarry.Text = LanguageManager.GetString("Add");
            buttonAddShipp.Text = LanguageManager.GetString("Add");
            buttonDeleteCarry.Text = LanguageManager.GetString("Delete");
            buttonDeleteShipp.Text = LanguageManager.GetString("Delete");
            buttonRefreshCarry.Text = LanguageManager.GetString("Refresh");
            buttonRefreshShipps.Text = LanguageManager.GetString("Refresh");
            buttonEditCarry.Text = LanguageManager.GetString("Edit");
            buttonBack.Text = LanguageManager.GetString("Back");
            labelIDLot.Text = LanguageManager.GetString("LotID");
            labelIDLot2.Text = LanguageManager.GetString("LotID");
            labelShipDate.Text = LanguageManager.GetString("EstimatedDate");
            labelIDestination.Text = LanguageManager.GetString("IDDestination");
            

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
            DateTime separateddate = dateTimePickerShippManagement.Value.Date;
            DateTime separatedtime = dateTimePickerShippManagementTime.Value;
            DateTime dateandtime = separateddate.Add(separatedtime.TimeOfDay);
            ShippingManagementController.Create(Int32.Parse(txtBoxIDTruckShippManagement.Text), Int32.Parse(txtBoxIDBatchShippManagement.Text), dateandtime);
            MessageBox.Show(Languages.Messages.Successful);
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
                MessageBox.Show(Languages.Messages.Successful);
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
                MessageBox.Show(Languages.Messages.Successful);
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
                MessageBox.Show(Languages.Messages.Successful);
                RefreshTableCarrieManagement();
                ClearTxtBoxesCarrieManagement();
            }
            else if (string.IsNullOrWhiteSpace(selectedStatus))
            {
                MessageBox.Show(Languages.Messages.CompleteAllBoxAndStatus);
            }
            else
            {
                MessageBox.Show(Languages.Messages.CompleteAllBoxAndStatus);
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
                MessageBox.Show(Languages.Messages.Successful);
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
