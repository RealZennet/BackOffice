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
            RefreshTable();
        }

        private void AssignProductsForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void ClearTxtBoxes()
        {
            txtBoxIDLote.Clear();
            txtBoxIDProduct.Clear();
        }
        
        public void RefreshTable()
        {
            DataTable dataTableAssignedProducts = AssignProductsController.Obtener();
            dataGridViewAssignedProducts.DataSource = dataTableAssignedProducts;
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            RefreshTable();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtBoxIDProduct.Text) && !string.IsNullOrEmpty(txtBoxIDLote.Text))
            { 
            AssignProductsController.Crear(Int32.Parse(txtBoxIDProduct.Text), Int32.Parse(txtBoxIDLote.Text));
            MessageBox.Show("Lote Agregado");
            RefreshTable();
            ClearTxtBoxes();
            }
            else
            {
                MessageBox.Show("No pueden existir parametros vacios!");
            }

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewAssignedProducts.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridViewAssignedProducts.SelectedRows[0].Index;
                int id = (int)dataGridViewAssignedProducts.Rows[selectedIndex].Cells["Lote ID"].Value;
                DataTable dataTableAssignedProduct = (DataTable)dataGridViewAssignedProducts.DataSource;
                dataTableAssignedProduct.Rows.RemoveAt(selectedIndex);
                MessageBox.Show("El producto fue eliminado del lote especificado!");
                AssignProductsController.DeleteAssignedProduct(id);
                dataGridViewAssignedProducts.DataSource = dataTableAssignedProduct;
                RefreshTable();

            }
        }

    }
}
