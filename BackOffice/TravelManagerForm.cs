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
    public partial class TravelManagerForm : Form
    {

        public event Action LanguageChanged;

        public TravelManagerForm()
        {
            InitializeComponent();
            RefreshTable();
            QuickCarry mainForm = Application.OpenForms.OfType<QuickCarry>().FirstOrDefault();
            if (mainForm != null)
            {
                mainForm.LanguageChanged += updateLanguage;
            }
            LanguageManager.Initialize(typeof(BackOffice.Languages.Resource_language_spanish));
            LanguageManager.Initialize(typeof(BackOffice.Languages.Resource_language_english));
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void updateLanguage()
        {
            buttonAdd.Text = LanguageManager.GetString("Add");
            buttonDelete.Text = LanguageManager.GetString("Delete");
            buttonRefresh.Text = LanguageManager.GetString("Refresh");
            buttonBack.Text = LanguageManager.GetString("Back");
            labelIDDestination.Text = LanguageManager.GetString("DestinationID");
            labelIDStoreHouse.Text = LanguageManager.GetString("StoreHouseID");
            labelTypeTravel.Text = LanguageManager.GetString("IDOperator");
            labelDateTravel.Text = LanguageManager.GetString("TruckerID");
        }

        public void ClearTxtBoxes()
        {
            txtBoxIDDestination.Clear();
            txtBoxIDStoreHouse.Clear();
        }

        public void RefreshTable()
        {
            DataTable dataTableTravel = TravelController.GetAllTravels();
            dataGridViewTravels.DataSource = dataTableTravel;
        }

        private bool ValidateInputsUser()
        {

            if (string.IsNullOrWhiteSpace(txtBoxIDStoreHouse.Text) ||
                string.IsNullOrWhiteSpace(txtBoxIDDestination.Text))
            {
                return false;
            }

            return true;
        }

        private void addShippment()
        {
            try
            {
                string selectedStatus = comboBoxTypeTravel.SelectedItem as string;
                DateTime fechaSeleccionada = dateTimePickerShippmentDate.Value.Date;
                DateTime horaSeleccionada = dateTimePickerShippmentDateTime.Value;
                DateTime fechaHoraSeleccionada = fechaSeleccionada.Add(horaSeleccionada.TimeOfDay);
                if (ValidateInputsUser() && !string.IsNullOrEmpty(selectedStatus))
                {
                    TravelController.Create(Int32.Parse(txtBoxIDStoreHouse.Text), Int32.Parse(txtBoxIDDestination.Text), selectedStatus, fechaHoraSeleccionada);
                    MessageBox.Show("Envío programado");
                    Refresh();
                    ClearTxtBoxes();
                }
                else if (string.IsNullOrWhiteSpace(selectedStatus))
                {
                    MessageBox.Show("Selecciona un estado.");
                }
                else
                {
                    MessageBox.Show("Completa todos los campos.");
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Error " + ex.Message);
            }

        }


        private void TravelManagerForm_Load(object sender, EventArgs e)
        {
            comboBoxTypeTravel.Items.Add("Inicio");
            comboBoxTypeTravel.Items.Add("Parada");
            comboBoxTypeTravel.Items.Add("Fin");
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            addShippment();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewTravels.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridViewTravels.SelectedRows[0].Index;
                int id = (int)dataGridViewTravels.Rows[selectedIndex].Cells["ID Almacen"].Value;
                DataTable dataTableCarries = (DataTable)dataGridViewTravels.DataSource;
                dataTableCarries.Rows.RemoveAt(selectedIndex);
                MessageBox.Show("El recorrido fue eliminado!");
                TravelController.DeleteTravel(id);
                dataGridViewTravels.DataSource = dataTableCarries;
                RefreshTable();

            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            RefreshTable();
        }
    }
}
