using BackOffice.crudForms;
using BackOffice.Languages;
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
    public partial class AssignTypeUser : Form
    {

        public event Action LanguageChanged;

        public AssignTypeUser()
        {
            InitializeComponent();
            RefreshTable();
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
            buttonAddOperator.Text = LanguageManager.GetString("Add");
            buttonAddTrucker.Text = LanguageManager.GetString("Add");
            buttonDelete.Text = LanguageManager.GetString("Delete");
            buttonDeleteOperator.Text = LanguageManager.GetString("Delete");
            buttonRefresh.Text = LanguageManager.GetString("Refresh");
            buttonBack.Text = LanguageManager.GetString("Back");
            labelUsernameOperator.Text = LanguageManager.GetString("IDOperator");
            labelUsernameTrucker.Text = LanguageManager.GetString("TruckerID");
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

            DataTable dataTableUsersAssignOperator = AssignTypeOfUserOperatorController.Obtener();
            dataGridViewOperators.DataSource = dataTableUsersAssignOperator;
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

        private void addUserOperator()
        {
            try
            {

                if (int.TryParse(txtBoxUsernameOperator.Text, out int userId))
                {
                    AssignTypeOfUserOperatorController.Crear(userId);
                    MessageBox.Show(Languages.Messages.Successful);
                    RefreshTable();
                    ClearTxtBoxes();
                }
                else
                {
                    MessageBox.Show(Languages.Messages.ErrorSyntax);
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        private void buttonAddTrucker_Click(object sender, EventArgs e)
        {
            AddTruckerForm addtruckercomponente = new AddTruckerForm();
            addtruckercomponente.Show();
        }

        private void deleteUserTrucker()
        {
            try
            {
                if (dataGridViewUsers.SelectedRows.Count > 0)
                {
                    int selectedIndex = dataGridViewUsers.SelectedRows[0].Index;
                    int id = (int)dataGridViewUsers.Rows[selectedIndex].Cells["ID"].Value;
                    DataTable dataTableUsers = (DataTable)dataGridViewUsers.DataSource;
                    dataTableUsers.Rows.RemoveAt(selectedIndex);
                    MessageBox.Show(Languages.Messages.Successful);
                    AssignTypeOfUserTruckerController.DeleteUser(id);
                    dataGridViewUsers.DataSource = dataTableUsers;
                    RefreshTable();
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void deleteUserOperator()
        {
            try
            {
                if (dataGridViewOperators.SelectedRows.Count > 0)
                {
                    int selectedIndex = dataGridViewOperators.SelectedRows[0].Index;
                    int id = (int)dataGridViewOperators.Rows[selectedIndex].Cells["Nombre de usuario"].Value;
                    DataTable dataTableOperators = (DataTable)dataGridViewOperators.DataSource;
                    dataTableOperators.Rows.RemoveAt(selectedIndex);
                    AssignTypeOfUserOperatorController.DeleteUser(id);
                    MessageBox.Show(Languages.Messages.Successful);
                    dataGridViewOperators.DataSource = dataTableOperators;
                    RefreshTable();

                }
            }catch(Exception)
            {
                MessageBox.Show(Messages.TruckerHasTruckAssigned);
            }

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            deleteUserTrucker();
        }

        private void buttonAddOperator_Click(object sender, EventArgs e)
        {
            addUserOperator();
        }

        private void buttonDeleteOperator_Click(object sender, EventArgs e)
        {
            deleteUserOperator();
        }
    }
}
