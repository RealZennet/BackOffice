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
            txtBoxFirstLastName.Clear();
            txtBoxPhoneNumber.Clear();
            txtBoxPassword.Clear();
            txtBoxUsername.Clear();
        }
        private bool ValidateInputsUser()
        {
            
            if (
                string.IsNullOrWhiteSpace(txtBoxFirstName.Text) ||
                string.IsNullOrWhiteSpace(txtBoxFirstLastName.Text) ||
                string.IsNullOrWhiteSpace(txtBoxPhoneNumber.Text) ||
                string.IsNullOrWhiteSpace(txtBoxUsername.Text) ||
                string.IsNullOrWhiteSpace(txtBoxPassword.Text)
                )
            {
                return false; 
            }

            return true; 
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            RefreshTable();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInputsUser())
            {
                MessageBox.Show("Porfavor complete los campos correspondientes");
                return;
            }
            createUser();
        }

        private void createUser()
        {
            UserController.Crear(
                txtBoxFirstName.Text,
                txtBoxFirstLastName.Text,
                Int32.Parse(txtBoxPhoneNumber.Text),
                txtBoxUsername.Text,
                txtBoxPassword.Text
            );
            MessageBox.Show("Usuario agregado");
            RefreshTable();
            ClearTxtBoxes();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            deleteUser();
        }

        private void deleteUser()
        {
            if (dataGridViewUsers.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridViewUsers.SelectedRows[0].Index;
                string username = (string)dataGridViewUsers.Rows[selectedIndex].Cells["username"].Value;
                DataTable dataTableUsers = (DataTable)dataGridViewUsers.DataSource;
                dataTableUsers.Rows.RemoveAt(selectedIndex);
                MessageBox.Show("El usuario fue eliminado!");
                UserController.DeleteUser(username);
                dataGridViewUsers.DataSource = dataTableUsers;
                RefreshTable();

            }
        }

        private void buttonBack_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtBoxFirstName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
