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
    public partial class ProductsForm : Form
    {
        public ProductsForm()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ProductsForm_Load(object sender, EventArgs e)
        {

        }
        public void RefreshTable()
        {
            DataTable dataTableProducts = ProductosController.Obtener();


            dataGridViewProducts.DataSource = dataTableProducts;
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            RefreshTable();
        }
    }
}
