using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackOffice.crudForms
{
    public partial class EditCarrieForm : Form
    {
        public event Action LanguageChanged;
        private int x, y, m;

        public EditCarrieForm()
        {
            InitializeComponent();
            comboBoxStatus.Items.Add("Entregado");
            comboBoxStatus.Items.Add("EnCamino");
            comboBoxStatus.Items.Add("Retrasado");
            comboBoxStatus.Items.Add("NoEnviado");
            comboBoxStatus.DropDownStyle = ComboBoxStyle.DropDownList;

            comboBoxStatus.SelectedIndex = 3;
            QuickCarry mainForm = Application.OpenForms.OfType<QuickCarry>().FirstOrDefault();
            if (mainForm != null)
            {
                mainForm.LanguageChanged += updateLanguage;
            }
            LanguageManager.Initialize(typeof(BackOffice.Languages.Resource_language_spanish));
            LanguageManager.Initialize(typeof(BackOffice.Languages.Resource_language_english));
        }

        private void updateLanguage()
        {
            labelIDTruck2.Text = LanguageManager.GetString("IDTruck");
            labelIDLot2.Text = LanguageManager.GetString("LotID");
            labelIDestination.Text = LanguageManager.GetString("IDDestination");
        }

        private void panelSlide_MouseDown(object sender, MouseEventArgs e)
        {
            m = 1;
            x = e.X;
            y = e.Y;
        }

        private void panelSlide_MouseMove(object sender, MouseEventArgs e)
        {
            if (m == 1)
            {
                this.SetDesktopLocation(MousePosition.X - x, MousePosition.Y - y);
            }
        }

        private void panelSlide_MouseUp(object sender, MouseEventArgs e)
        {
            m = 0;
        }

        private void clearTxtBox()
        {
            txtBoxIDBatchCarrie.Clear();
            txtBoxIDDestinationCarrie.Clear();
            txtBoxIDTruckCarrie.Clear();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
