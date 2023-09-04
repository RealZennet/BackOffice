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
    }
}
