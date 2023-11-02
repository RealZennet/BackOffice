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

        public event Action LanguageChanged;

        public TruckManagerForm()
        {
            InitializeComponent();
            RefreshTableTruck();
            RefreshTableTrucker();
            QuickCarry mainForm = Application.OpenForms.OfType<QuickCarry>().FirstOrDefault();
            if (mainForm != null)
            {
                mainForm.LanguageChanged += updateLanguage;
            }
        }

        private void updateLanguage()
        {
            buttonAddAssignedTruck.Text = LanguageManager.GetString("Add");
            buttonAddTruck.Text = LanguageManager.GetString("Add");
            buttonDeleteAssignedTruck.Text = LanguageManager.GetString("Delete");
            buttonDeleteTruck.Text = LanguageManager.GetString("Delete");
            buttonRefreshAssignTrucker.Text = LanguageManager.GetString("Refresh");
            buttonRefreshTruck.Text = LanguageManager.GetString("Refresh");
            buttonEdit.Text = LanguageManager.GetString("Edit");
            buttonBack.Text = LanguageManager.GetString("Back");
            labelActived.Text = LanguageManager.GetString("Activated");
            labelIDTruck.Text = LanguageManager.GetString("IDTruck");
            labelIDTruck2.Text = LanguageManager.GetString("IDTruck");
            labelIDTrucker.Text = LanguageManager.GetString("IDTrucker");
            labelActived.Text = LanguageManager.GetString("Activated");
            labelTruckWeight.Text = LanguageManager.GetString("Weight");
            labelTruckVolume.Text = LanguageManager.GetString("Volume");

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

        public void RefreshTableTruck()
        {
            DataTable dataTableTruck = TruckController.GetAllTrucks();
            dataGridViewAddTruck.DataSource = dataTableTruck;
        }

        private void buttonRefreshTruck_Click(object sender, EventArgs e)
        {
            RefreshTableTruck();
        }

        private void buttonAddTruck_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBoxWeightTruck.Text) ||
                string.IsNullOrWhiteSpace(txtBoxVolumeTruck.Text) ||
                string.IsNullOrWhiteSpace(txtBoxActiveTruck.Text) ||
                !int.TryParse(txtBoxWeightTruck.Text, out int weight) ||
                !int.TryParse(txtBoxVolumeTruck.Text, out int volume) ||
                !bool.TryParse(txtBoxActiveTruck.Text, out bool isActive))
            {
                MessageBox.Show(Languages.Messages.CompleteAllBoxAndStatus);
                return;
            }

            TruckController.Create(weight, volume, isActive);
            MessageBox.Show(Languages.Messages.Successful);
            RefreshTableTruck();
            ClearTxtBoxesTruck();
        }

        private void buttonDeleteTruck_Click(object sender, EventArgs e)
        {
            if (dataGridViewAddTruck.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridViewAddTruck.SelectedRows[0].Index;
                int id = (int)dataGridViewAddTruck.Rows[selectedIndex].Cells["Camion ID"].Value;

                if (id > 0)
                {
                    DataTable dataTableTruckSelected = (DataTable)dataGridViewAddTruck.DataSource;
                    dataTableTruckSelected.Rows.RemoveAt(selectedIndex);
                    MessageBox.Show(Languages.Messages.Successful);
                    TruckController.DeleteTruck(id);
                    dataGridViewAddTruck.DataSource = dataTableTruckSelected;
                    RefreshTableTruck();
                }
                else
                {
                    MessageBox.Show(Languages.Messages.SelectAnIndex);
                }
            }
            else
            {
                MessageBox.Show(Languages.Messages.SelectAnIndex);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            TruckController.EditTruck(
                Int32.Parse(txtBoxTruckID.Text),
                Int32.Parse(txtBoxWeightTruck.Text),
                Int32.Parse(txtBoxVolumeTruck.Text),
                Convert.ToBoolean(txtBoxActiveTruck.Text)
            );
            RefreshTableTruck();
            MessageBox.Show(Languages.Messages.Successful);
        }

        #region trucker
        public void RefreshTableTrucker()
        {
            DataTable dataTableTrucker = TruckerController.GetAllTruckers();
            dataGridViewAssignTruck.DataSource = dataTableTrucker;
        }

        private void buttonRefreshAssignTrucker_Click(object sender, EventArgs e)
        {
            RefreshTableTrucker();
        }

        public void ClearTxtBoxesTrucker()
        {
            txtBoxIDAssignedTruck.Clear();
            txtBoxIDAssignedTrucker.Clear();
        }

        private void buttonAddAssignedTruck_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBoxIDAssignedTruck.Text) ||
                string.IsNullOrWhiteSpace(txtBoxIDAssignedTrucker.Text) ||
                !int.TryParse(txtBoxIDAssignedTruck.Text, out int truckId) ||
                !int.TryParse(txtBoxIDAssignedTrucker.Text, out int truckerId))
            {
                MessageBox.Show(Languages.Messages.CompleteAllBoxAndStatus);
                return;
            }

            try
            {
                TruckerController.Create(truckId, truckerId);
                MessageBox.Show(Languages.Messages.Successful);
                RefreshTableTrucker();
                ClearTxtBoxesTrucker();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void buttonDeleteAssignedTruck_Click(object sender, EventArgs e)
        {
            if (dataGridViewAssignTruck.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridViewAssignTruck.SelectedRows[0].Index;
                int id = (int)dataGridViewAssignTruck.Rows[selectedIndex].Cells["Conductor ID"].Value;

                if (id > 0)
                {
                    DataTable dataTableTruckerSelected = (DataTable)dataGridViewAssignTruck.DataSource;
                    dataTableTruckerSelected.Rows.RemoveAt(selectedIndex);
                    MessageBox.Show(Languages.Messages.Successful);
                    TruckerController.DeleteTrucker(id);
                    dataGridViewAssignTruck.DataSource = dataTableTruckerSelected;
                    RefreshTableTrucker();
                }
                else
                {
                    MessageBox.Show(Languages.Messages.SelectAnIndex);
                }
            }
            else
            {
                MessageBox.Show(Languages.Messages.SelectAnIndex);
            }
        }

        #endregion trucker
    }
}
