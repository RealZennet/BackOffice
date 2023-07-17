using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using capa_logica;

namespace BackOffice
{
    public partial class AssignProductsForm : Form
    {
        public AssignProductsForm()
        {
            InitializeComponent();
        }

        private void AssignProductsForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            DataTable dataTableAssignedProducts = AssignProductsController.Obtener();
            dataGridViewAssignedProducts.DataSource = dataTableAssignedProducts;
        }
    }
}
