﻿using capa_logica;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BackOffice
{
    public partial class DestinationForm : Form
    {

        public event Action LanguageChanged;

        public DestinationForm()
        {
            InitializeComponent();
            RefreshTable();
            QuickCarry mainForm = Application.OpenForms.OfType<QuickCarry>().FirstOrDefault();
            if (mainForm != null)
            {
                mainForm.LanguageChanged += updateLanguage;
            }
        }

        private void updateLanguage()
        {
            buttonAddDestination.Text = LanguageManager.GetString("Add");
            buttonDeleteDestination.Text = LanguageManager.GetString("Delete");
            buttonRefreshDestination.Text = LanguageManager.GetString("Refresh");
            buttonBack.Text = LanguageManager.GetString("Back");
            labelActivated.Text = LanguageManager.GetString("Activated");
            labelShipDate.Text = LanguageManager.GetString("DateOfShipment");
            labelStreet.Text = LanguageManager.GetString("Street");
            labelCorner.Text = LanguageManager.GetString("Corner");
            labelNumber.Text = LanguageManager.GetString("Number");
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DestinationForm_Load(object sender, EventArgs e)
        {
            comboBoxStatus.Items.Add("true");
            comboBoxStatus.Items.Add("false");
        }

        #region Destination

        public void RefreshTable()
        {
            DataTable dataTableDestination = DestinationController.GetAllDestinations();
            dataGridViewDestinations.DataSource = dataTableDestination;
        }

        public void AddStoreHouse()
        {
            txtBoxDestinationStreet.Clear();
            txtBoxIDDestination.Clear();
        }

        private bool ValidateInputsUser()
        {

            if (string.IsNullOrWhiteSpace(txtBoxDestinationStreet.Text))
            {
                return false;
            }

            return true;
        }

        private void addDestination()
        {
            DateTime separateddate = dateTimePickerDestinationManagement.Value.Date;
            DateTime separatedtime = dateTimePickerDestinationManagementTime.Value;
            DateTime dateandtime = separateddate.Add(separatedtime.TimeOfDay);
            string selectedStatus = comboBoxStatus.SelectedItem as string;
            if (ValidateInputsUser() && !string.IsNullOrWhiteSpace(selectedStatus))
            {
                int statusValue = selectedStatus == "true" ? 1 : 0;
                DestinationController.Create(txtBoxDestinationStreet.Text, txtBoxDestinationDoorNumber.Text, txtBoxDestinationCorner.Text, dateandtime, Convert.ToBoolean(statusValue));
                MessageBox.Show(Languages.Messages.Successful);
                RefreshTable();
            }
            else if (string.IsNullOrWhiteSpace(selectedStatus))
            {
                MessageBox.Show(Languages.Messages.CompleteAllBoxAndStatus);
            }
            else
            {
                MessageBox.Show(Languages.Messages.CompleteAllBoxAndStatus);
            }
        }

        private void deleteDestination()
        {
            if (dataGridViewDestinations.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridViewDestinations.SelectedRows[0].Index;
                int id = (int)dataGridViewDestinations.Rows[selectedIndex].Cells["ID"].Value;
                DataTable dataTableDestinations = (DataTable)dataGridViewDestinations.DataSource;
                dataTableDestinations.Rows.RemoveAt(selectedIndex);
                MessageBox.Show("El destino fue eliminado!");
                DestinationController.DeleteDestination(id);
                dataGridViewDestinations.DataSource = dataTableDestinations;
                RefreshTable();

            }
        }

        private void buttonAddDestination_Click(object sender, EventArgs e)
        {
            addDestination();
        }


        private void buttonRefreshDestination_Click(object sender, EventArgs e)
        {
            RefreshTable();
        }


        private void buttonDeleteDestination_Click(object sender, EventArgs e)
        {
            deleteDestination();
        }

        private void edit()
        {
            try
            {
                DateTime separateddate = dateTimePickerDestinationManagement.Value.Date;
                DateTime separatedtime = dateTimePickerDestinationManagementTime.Value;
                DateTime dateandtime = separateddate.Add(separatedtime.TimeOfDay);
                string selectedStatus = comboBoxStatus.SelectedItem as string;
                if (ValidateInputsUser() && !string.IsNullOrWhiteSpace(selectedStatus))
                {
                    int statusValue = selectedStatus == "true" ? 1 : 0;
                    DestinationController.EditDestination(Int32.Parse(txtBoxIDDestination.Text), txtBoxDestinationStreet.Text, txtBoxDestinationDoorNumber.Text, txtBoxDestinationCorner.Text, dateandtime, Convert.ToBoolean(statusValue));
                    MessageBox.Show(Languages.Messages.Successful);
                }
                else
                {
                    MessageBox.Show(Languages.Messages.CompleteAllBoxAndStatus);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        #endregion Destination

        private void buttonEditDestination_Click(object sender, EventArgs e)
        {
            edit();
        }

        private void dataGridViewDestinations_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewDestinations_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void buttonShowMap_Click(object sender, EventArgs e)
        {
            MapForm viewMap = new MapForm();
            viewMap.Show();
        }
    }
}
