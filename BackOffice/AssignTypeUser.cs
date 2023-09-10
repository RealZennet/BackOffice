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

        private void addUserTracker()
        {
            AssignTypeOfUserTruckerController.Crear(Int32.Parse(txtBoxUsernameTrucker.Text));
            MessageBox.Show("Usuario asignado a camionero");
            RefreshTable();
            ClearTxtBoxes();
        }

        private void addUserOperator()
        {
            AssignTypeOfUserOperatorController.Crear(txtBoxUsernameOperator.Text);
            MessageBox.Show("Usuario asignado a operador");
            RefreshTable();
            ClearTxtBoxes();
        }

        private void buttonAddTrucker_Click(object sender, EventArgs e)
        {
            addUserTracker();

        }

        private void deleteUserTrucker()
        {
            if (dataGridViewUsers.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridViewUsers.SelectedRows[0].Index;
                int id = (int)dataGridViewUsers.Rows[selectedIndex].Cells["ID"].Value;
                DataTable dataTableUsers = (DataTable)dataGridViewUsers.DataSource;
                dataTableUsers.Rows.RemoveAt(selectedIndex);
                MessageBox.Show("El usuario fue eliminado!");
                AssignTypeOfUserTruckerController.DeleteUser(id);
                dataGridViewUsers.DataSource = dataTableUsers;
                RefreshTable();

            }
        }

        private void deleteUserOperator()
        {
            if (dataGridViewOperators.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridViewOperators.SelectedRows[0].Index;
                string username = (string)dataGridViewOperators.Rows[selectedIndex].Cells["Nombre de usuario"].Value;
                DataTable dataTableOperators = (DataTable)dataGridViewOperators.DataSource;
                dataTableOperators.Rows.RemoveAt(selectedIndex);
                MessageBox.Show("El usuario fue eliminado!");
                AssignTypeOfUserOperatorController.DeleteUser(username);
                dataGridViewOperators.DataSource = dataTableOperators;
                RefreshTable();

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
