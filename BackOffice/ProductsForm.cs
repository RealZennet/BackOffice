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

        public event Action LanguageChanged;

        public ProductsForm()
        {
            InitializeComponent();
            RefreshTable();
            QuickCarry mainForm = Application.OpenForms.OfType<QuickCarry>().FirstOrDefault();
            if (mainForm != null)
            {
                mainForm.LanguageChanged += updateLanguage;
            }
        }

        private void updateLanguage()
        {
            buttonAddProduct.Text = LanguageManager.GetString("Add");
            buttonDelete.Text = LanguageManager.GetString("Delete");
            buttonRefresh.Text = LanguageManager.GetString("Refresh");
            buttonBack.Text = LanguageManager.GetString("Back");
            labelActived.Text = LanguageManager.GetString("Activated");
            labelProductCorner.Text = LanguageManager.GetString("Corner");
            labelCustomer.Text = LanguageManager.GetString("Customer");
            labelDoorNumber.Text = LanguageManager.GetString("Number");
            labelProductStreet.Text = LanguageManager.GetString("Street");
            labelProductVolume.Text = LanguageManager.GetString("Volume");
            labelProductWeight.Text = LanguageManager.GetString("Weight");

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
            DataTable dataTableProducts = ProductController.Obtener();
            dataGridViewProducts.DataSource = dataTableProducts;
        }

        public void ClearTxtBoxes()
        {
            txtBoxActive.Clear();
            txtBoxCustomer.Clear();
            txtBoxWeight.Clear();
            txtBoxCorner.Clear();
            txtBoxStreet.Clear();
            txtBoxVolume.Clear();

        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            RefreshTable();
        }

        private bool ValidateInputsUser()
        {

            if (string.IsNullOrWhiteSpace(txtBoxCustomer.Text) ||
                string.IsNullOrWhiteSpace(txtBoxWeight.Text) ||
                string.IsNullOrWhiteSpace(txtBoxCustomer.Text) ||
                string.IsNullOrWhiteSpace(txtBoxActive.Text) ||
                string.IsNullOrWhiteSpace(txtBoxCorner.Text) ||
                string.IsNullOrWhiteSpace(txtBoxStreet.Text) ||
                string.IsNullOrWhiteSpace(txtBoxVolume.Text))
            {
                return false;
            }

            return true;
        }


        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            if (!ValidateInputsUser())
            {
                MessageBox.Show(Languages.Messages.CompleteAllBoxAndStatus);
                return;
            }
            addProduct();
        }

        private void addProduct()
        {
            try
            {
            ProductController.Crear(Int32.Parse(txtBoxWeight.Text), Int32.Parse(txtBoxVolume.Text), txtBoxStreet.Text, Int32.Parse(txtBoxDoorNumber.Text), txtBoxCorner.Text,txtBoxCustomer.Text, Convert.ToBoolean(Int32.Parse(txtBoxActive.Text)));
            MessageBox.Show(Languages.Messages.Successful);
            RefreshTable();
            ClearTxtBoxes();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            deleteProduct();
        }

        private void deleteProduct()
        {
            if (dataGridViewProducts.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridViewProducts.SelectedRows[0].Index;
                int id = (int)dataGridViewProducts.Rows[selectedIndex].Cells["id"].Value;
                DataTable dataTableProducts = (DataTable)dataGridViewProducts.DataSource;
                dataTableProducts.Rows.RemoveAt(selectedIndex);
                MessageBox.Show(Languages.Messages.Successful);

                ProductController.EliminarProducto(id);
                dataGridViewProducts.DataSource = dataTableProducts;
                RefreshTable();

            }
        }

        private void dataGridViewProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
