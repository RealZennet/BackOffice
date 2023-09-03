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
            RefreshTable();
        }
        
        private void LotsForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void RefreshTable()
        {
            DataTable dataTableLots = BatchController.Obtener();
            dataGridViewLots.DataSource = dataTableLots;
        }

        public void ClearTxtBoxes()
        {
            txtBoxLotsAmount.Clear();
        }

        private bool ValidateInputsUser()
        {

            if (string.IsNullOrWhiteSpace(txtBoxLotsAmount.Text))
            {
                return false;
            }

            return true;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInputsUser())
            {
                MessageBox.Show("Porfavor complete los datos correspondientes");
                return;
            }
            BatchController.Crear(Convert.ToDateTime(dateTimePickerShippingDate.Text));
            MessageBox.Show("Lote Agregado");
            RefreshTable();
            ClearTxtBoxes();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            deleteBatch();
            RefreshTable();
        }

        private void deleteBatch()
        {
            if (dataGridViewLots.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridViewLots.SelectedRows[0].Index;
                int id = (int)dataGridViewLots.Rows[selectedIndex].Cells["id"].Value;
                DataTable dataTableLots = (DataTable)dataGridViewLots.DataSource;
                dataTableLots.Rows.RemoveAt(selectedIndex);
                MessageBox.Show("El lote fue eliminado!");
                BatchController.EliminarLote(id);
                dataGridViewLots.DataSource = dataTableLots;
                

            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            RefreshTable();
        }
    }
}
