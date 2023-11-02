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

        public event Action LanguageChanged;

        public UsersForms()
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
            buttonAdd.Text = LanguageManager.GetString("Add");
            buttonDelete.Text = LanguageManager.GetString("Delete");
            buttonRefresh.Text = LanguageManager.GetString("Refresh");
            buttonEditUser.Text = LanguageManager.GetString("Edit");
            buttonBack.Text = LanguageManager.GetString("Back");
            labelFirstName.Text = LanguageManager.GetString("FirstName");
            labelFirstLastName.Text = LanguageManager.GetString("FirstLastName");
            labelPhoneNumber.Text = LanguageManager.GetString("PhoneNumber");
            labelUsername.Text = LanguageManager.GetString("Username");
            labelPassword.Text = LanguageManager.GetString("Password");

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
                MessageBox.Show(Languages.Messages.CompleteAllBoxAndStatus);
                return;
            }
            createUser();
        }

        private void createUser()
        {
            UserController.Crear(
                txtBoxFirstName.Text,
                txtBoxFirstLastName.Text,
                txtBoxPhoneNumber.Text,
                txtBoxUsername.Text,
                txtBoxPassword.Text
            );
            MessageBox.Show(Languages.Messages.Successful);
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
                int id = (int)dataGridViewUsers.Rows[selectedIndex].Cells["id"].Value;
                DataTable dataTableUsers = (DataTable)dataGridViewUsers.DataSource;
                dataTableUsers.Rows.RemoveAt(selectedIndex);
                MessageBox.Show(Languages.Messages.Successful);
                UserController.DeleteUser(id);
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

        private void editUser()
        {
            try
            {
                if (ValidateInputsUser())
                {
                    UserController.Edit(Int32.Parse(txtBoxUserID.Text), txtBoxFirstName.Text, txtBoxFirstLastName.Text, txtBoxPhoneNumber.Text,txtBoxUsername.Text, txtBoxPassword.Text);
                    MessageBox.Show(Languages.Messages.Successful);
                    ClearTxtBoxes();
                    RefreshTable();
                }
                else
                {
                    MessageBox.Show(Languages.Messages.CompleteAllBoxAndStatus);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void buttonEditUser_Click(object sender, EventArgs e)
        {
            editUser();
        }
    }
}
