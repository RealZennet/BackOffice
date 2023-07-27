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
            RefreshTable();
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

        public void ClearTxtBoxes()
        {
            txtBoxName.Clear();
            txtBoxAmount.Clear();
            txtBoxDescription.Clear();
            txtBoxWeight.Clear();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            RefreshTable();
        }

        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            ProductosController.Crear(txtBoxName.Text, Int32.Parse(txtBoxAmount.Text), Int32.Parse(txtBoxAmount.Text), txtBoxDescription.Text);
            MessageBox.Show("Producto Agregado");
            RefreshTable();
            ClearTxtBoxes();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewProducts.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridViewProducts.SelectedRows[0].Index;
                int id = (int)dataGridViewProducts.Rows[selectedIndex].Cells["id"].Value;
                DataTable dataTableProducts = (DataTable)dataGridViewProducts.DataSource;
                dataTableProducts.Rows.RemoveAt(selectedIndex);
                MessageBox.Show("El producto fue eliminado!");

                ProductosController.EliminarProducto(id);
                dataGridViewProducts.DataSource = dataTableProducts;
                RefreshTable();

            }
        }

        private void dataGridViewProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
