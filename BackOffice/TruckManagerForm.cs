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
    public partial class TruckManagerForm : Form
    {
        public TruckManagerForm()
        {
            InitializeComponent();
            RefreshTableTruck();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TruckManagerForm_Load(object sender, EventArgs e)
        {

        }

        public void ClearTxtBoxesTruck()
        {
            txtBoxActiveTruck.Clear();
            txtBoxVolumeTruck.Clear();
            txtBoxWeightTruck.Clear();
        }

        public void ClearTxtBoxesTrucker()
        {
            txtBoxIDAssignedTruck.Clear();
            txtBoxIDAssignedTrucker.Clear();
        }

        public void RefreshTableTruck()
        {
            DataTable dataTableTruck = TruckController.GetAllTrucks();
            dataGridViewAddTruck.DataSource = dataTableTruck;
        }

        public void RefreshTableTrucker()
        {
            //Logica para asignacion de camioneros
        }

        private void buttonRefreshAssignTrucker_Click(object sender, EventArgs e)
        {

        }

        private void buttonRefreshTruck_Click(object sender, EventArgs e)
        {
            RefreshTableTruck();
        }

        private void buttonAddTruck_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBoxWeightTruck.Text) && 
                !string.IsNullOrEmpty(txtBoxVolumeTruck.Text) && 
                !string.IsNullOrEmpty(txtBoxActiveTruck.Text))
            {
                TruckController.Create(Int32.Parse(txtBoxWeightTruck.Text), Int32.Parse(txtBoxVolumeTruck.Text), Int32.Parse(txtBoxActiveTruck.Text));
                MessageBox.Show("Camion Agregado");
                RefreshTableTruck();
                ClearTxtBoxesTruck();
            }
            else
            {
                MessageBox.Show("No pueden existir parametros vacios!");
            }
        }

        private void buttonDeleteTruck_Click(object sender, EventArgs e)
        {
            if (dataGridViewAddTruck.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridViewAddTruck.SelectedRows[0].Index;
                int id = (int)dataGridViewAddTruck.Rows[selectedIndex].Cells["Lote ID"].Value;
                DataTable dataTableTruckSelected = (DataTable)dataGridViewAddTruck.DataSource;
                dataTableTruckSelected.Rows.RemoveAt(selectedIndex);
                MessageBox.Show("El camion fue eliminado!");
                AssignProductsController.DeleteAssignedProduct(id);
                dataGridViewAddTruck.DataSource = dataTableTruckSelected;
                RefreshTableTruck();

            }
        }
    }
}
