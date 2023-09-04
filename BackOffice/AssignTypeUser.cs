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
    public partial class AssignTypeUser : Form
    {
        public AssignTypeUser()
        {
            InitializeComponent();
            RefreshTable();
        }

        private void AssignTypeUser_Load(object sender, EventArgs e)
        {

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void RefreshTable()
        {
            DataTable dataTableUsersAssign = AssignTypeOfUserTruckerController.Obtener();
            dataGridViewUsers.DataSource = dataTableUsersAssign;
        }

        public void ClearTxtBoxes()
        {
            txtBoxUsernameTrucker.Clear();
            txtBoxUsernameOperator.Clear();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            RefreshTable();
        }

        private void addUserTracker()
        {
            AssignTypeOfUserTruckerController.Crear(txtBoxUsernameTrucker.Text);
            MessageBox.Show("Usuario asignado a camionero");
            RefreshTable();
            ClearTxtBoxes();
        }

        private void buttonAddTrucker_Click(object sender, EventArgs e)
        {
            addUserTracker();

        }

        private void deleteUser()
        {
            if (dataGridViewUsers.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridViewUsers.SelectedRows[0].Index;
                string username = (string)dataGridViewUsers.Rows[selectedIndex].Cells["Nombre de usuario"].Value;
                DataTable dataTableUsers = (DataTable)dataGridViewUsers.DataSource;
                dataTableUsers.Rows.RemoveAt(selectedIndex);
                MessageBox.Show("El usuario fue eliminado!");
                AssignTypeOfUserTruckerController.DeleteUser(username);
                dataGridViewUsers.DataSource = dataTableUsers;
                RefreshTable();

            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            deleteUser();
        }
    }
}