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
    public partial class UsersForms : Form
    {
        public UsersForms()
        {
            InitializeComponent();
            RefreshTable();
        }

        private void UsersForms_Load(object sender, EventArgs e)
        {

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void RefreshTable()
        {
            DataTable dataTableUsers = UserController.Obtener();
            dataGridViewUsers.DataSource = dataTableUsers;
        }

        public void ClearTxtBoxes()
        {
            txtBoxFirstName.Clear();
            txtBoxSecondName.Clear();
            txtBoxFirstLastName.Clear();
            txtBoxSecondLastName.Clear();
            txtBoxPhoneNumber.Clear();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            RefreshTable();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            UserController.Crear(Int32.Parse(txtBoxCI.Text), txtBoxFirstName.Text, txtBoxSecondName.Text, txtBoxFirstLastName.Text, txtBoxSecondLastName.Text, Int32.Parse(txtBoxPhoneNumber.Text));
            MessageBox.Show("Usuario agregado Agregado");
            RefreshTable();
            ClearTxtBoxes();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewUsers.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridViewUsers.SelectedRows[0].Index;
                int ci = (int)dataGridViewUsers.Rows[selectedIndex].Cells["ci"].Value;
                DataTable dataTableUsers = (DataTable)dataGridViewUsers.DataSource;
                dataTableUsers.Rows.RemoveAt(selectedIndex);
                MessageBox.Show("El usuario fue eliminado!");
                UserController.DeleteUser(ci);
                dataGridViewUsers.DataSource = dataTableUsers;
                RefreshTable();

            }
        }
    }
}
