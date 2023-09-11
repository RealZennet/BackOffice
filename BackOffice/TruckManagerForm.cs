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
    }
}
