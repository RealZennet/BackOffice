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
    public partial class LotsForm : Form
    {
        public LotsForm()
        {
            InitializeComponent();
        }
        // [¡Un lote debe tener productos y se deben poder visualizar?!]
        private void LotsForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void RefreshTable()
        {
            DataTable dataTableLots = LotesController.Obtener();
            dataGridViewLots.DataSource = dataTableLots;
        }

        public void ClearTxtBoxes()
        {
            txtBoxLotsAmount.Clear();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            LotesController.Crear(Int32.Parse(txtBoxLotsAmount.Text));
            MessageBox.Show("Lote Agregado");
            RefreshTable();
            ClearTxtBoxes();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewLots.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridViewLots.SelectedRows[0].Index;
                int id = (int)dataGridViewLots.Rows[selectedIndex].Cells["id"].Value;
                DataTable dataTableLots = (DataTable)dataGridViewLots.DataSource;
                dataTableLots.Rows.RemoveAt(selectedIndex);
                MessageBox.Show("El lote fue eliminado!");

                ProductosController.EliminarProducto(id);
                dataGridViewLots.DataSource = dataTableLots;
                RefreshTable();

            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            RefreshTable();
        }
    }
}
