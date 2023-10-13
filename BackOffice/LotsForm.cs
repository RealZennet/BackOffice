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

        private bool validateUsersInputs()
        {
            if (string.IsNullOrWhiteSpace(txtBoxActivedBatch.Text) ||
                string.IsNullOrWhiteSpace(txtBoxIDShipp.Text))
            {
                return false;
            }
            return true;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
            if (validateUsersInputs()) {
                DateTime separateddate = dateTimePickerShippingDate.Value.Date;
                DateTime separatedtime = dateTimePickerBatchManagementTime.Value;
                DateTime dateandtime = separateddate.Add(separatedtime.TimeOfDay);
                BatchController.Crear(dateandtime, Int32.Parse(txtBoxIDShipp.Text), Convert.ToBoolean(txtBoxActivedBatch.Text));
                MessageBox.Show("Lote Agregado");
                RefreshTable();
                }
                else
                {
                    MessageBox.Show("Completa los campos");
                }
            
            }catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

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
