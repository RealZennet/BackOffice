﻿using capa_logica;
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

        public event Action LanguageChanged;

        public StoreHouse()
        {
            InitializeComponent();
            RefreshTableAddStoreHouse();
            RefreshTableAssignOperatorToStoreHouse();
            QuickCarry mainForm = Application.OpenForms.OfType<QuickCarry>().FirstOrDefault();
            if (mainForm != null)
            {
                mainForm.LanguageChanged += updateLanguage;
            }
        }

        private void updateLanguage()
        {
            buttonAddStoreHouse.Text = LanguageManager.GetString("Add");
            buttonAddOperatorToStoreHouse.Text = LanguageManager.GetString("Add");
            buttonDeleteStoreHouse.Text = LanguageManager.GetString("Delete");
            buttonDeleteOperatorFromStoreHouse.Text = LanguageManager.GetString("Delete");
            buttonRefreshStoreHouse.Text = LanguageManager.GetString("Refresh");
            buttonRefreshAddOperatorStoreHouses.Text = LanguageManager.GetString("Refresh");
            buttonEditStoreHouse.Text = LanguageManager.GetString("Edit");
            buttonBack.Text = LanguageManager.GetString("Back");
            labelStreet.Text = LanguageManager.GetString("Street");
            labelCorner.Text = LanguageManager.GetString("Corner");
            labelNumber.Text = LanguageManager.GetString("Number");
            labelActived.Text = LanguageManager.GetString("Activated");
            labelIDOperator.Text = LanguageManager.GetString("IDOperator");
            labelIDStoreHouse.Text = LanguageManager.GetString("StoreHouseID");

        }

        private void StoreHouse_Load(object sender, EventArgs e)
        {

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region AddStoreHouse

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

        private void addStoreHouse()
        {
            if (bool.TryParse(txtBoxStoreHouseActived.Text, out bool isActivated))
            {
                StoreHouseController.Create(txtBoxStoreHouseStreet.Text, txtBoxStoreHouseDoorNumber.Text, txtBoxStoreHouseCorner.Text, isActivated);
                MessageBox.Show(Languages.Messages.Successful);
                RefreshTableAddStoreHouse();
                ClearTxtBoxesAddStoreHouse();
            }
            else
            {
                MessageBox.Show(Languages.Messages.CompleteAllBoxAndStatus);
            }
        }

        private void buttonAddStoreHouse_Click(object sender, EventArgs e)
        {
            addStoreHouse();
        }

        private void deleteStoreHouse()
        {
            if (dataGridViewStoreHouses.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridViewStoreHouses.SelectedRows[0].Index;
                int id = (int)dataGridViewStoreHouses.Rows[selectedIndex].Cells["id"].Value;
                DataTable dataTableProducts = (DataTable)dataGridViewStoreHouses.DataSource;
                dataTableProducts.Rows.RemoveAt(selectedIndex);
                MessageBox.Show(Languages.Messages.Successful);
                StoreHouseController.DeleteStoreHouse(id);
                dataGridViewStoreHouses.DataSource = dataTableProducts;
                RefreshTableAddStoreHouse();

            }
        }

        private void buttonRefreshStoreHouse_Click(object sender, EventArgs e)
        {
            RefreshTableAddStoreHouse();
        }
        #endregion AddStoreHouse

        #region AssignOperatorToStoreHouse

        public void RefreshTableAssignOperatorToStoreHouse()
        {
            DataTable dataTableAddOperatorToStoreHouse = AssignOperatorToStoreHouseController.GetAllOperatorsAssignedToStoreHouses();
            dataGridViewAddOperatorStoreHouse.DataSource = dataTableAddOperatorToStoreHouse;
        }

        public void ClearTxtBoxesAssignOperatorToStoreHouse()
        {
            txtBoxIDOperator.Clear();
            txtBoxIDAddOperatorToStoreHouse.Clear();
        }

        private bool ValidateAssignOperatorToStoreHouseInputsUser()
        {

            if (string.IsNullOrWhiteSpace(txtBoxIDAddOperatorToStoreHouse.Text) ||
                string.IsNullOrWhiteSpace(txtBoxIDOperator.Text))
            {
                return false;
            }

            return true;
        }

        private void assignOperatorToStoreHouse()
        {
            AssignOperatorToStoreHouseController.Create(Int32.Parse(txtBoxIDOperator.Text), Int32.Parse(txtBoxIDAddOperatorToStoreHouse.Text));
            MessageBox.Show(Languages.Messages.Successful);
            RefreshTableAssignOperatorToStoreHouse();
            ClearTxtBoxesAssignOperatorToStoreHouse();
        }

        private void deleteAssignedOperatorToStoreHouse()
        {
            if (dataGridViewAddOperatorStoreHouse.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridViewAddOperatorStoreHouse.SelectedRows[0].Index;
                int id = (int)dataGridViewAddOperatorStoreHouse.Rows[selectedIndex].Cells["ID Operario"].Value;
                DataTable dataTableAssignedOperators = (DataTable)dataGridViewAddOperatorStoreHouse.DataSource;
                dataTableAssignedOperators.Rows.RemoveAt(selectedIndex);
                MessageBox.Show(Languages.Messages.Successful);
                AssignOperatorToStoreHouseController.DeleteAssignedOperator(id);
                dataGridViewAddOperatorStoreHouse.DataSource = dataTableAssignedOperators;
                RefreshTableAddStoreHouse();

            }
        }

        private void buttonAddOperatorToStoreHouse_Click(object sender, EventArgs e)
        {
            assignOperatorToStoreHouse();
        }

        private void buttonDeleteOperatorFromStoreHouse_Click(object sender, EventArgs e)
        {
            deleteAssignedOperatorToStoreHouse();
        }

        private void buttonRefreshAddOperatorStoreHouses_Click(object sender, EventArgs e)
        {
            RefreshTableAssignOperatorToStoreHouse();
        }
        #endregion AssignOperatorToStoreHouse


    }
}
