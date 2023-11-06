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

        public event Action LanguageChanged;

        public AssignProductsForm()
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

        private void updateLanguage()
        {
            buttonAdd.Text = LanguageManager.GetString("Add");
            buttonDelete.Text = LanguageManager.GetString("Delete");
            buttonRefresh.Text = LanguageManager.GetString("Refresh");
            buttonBack.Text = LanguageManager.GetString("Back");
            labelProductID.Text = LanguageManager.GetString("ProductID");
            labelBatchID.Text = LanguageManager.GetString("LotID");

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
       
        private bool validateInputsUsers()
        {
            if(!string.IsNullOrEmpty(txtBoxIDProduct.Text) ||
                !string.IsNullOrEmpty(txtBoxIDLote.Text))
            {
                return true;
            }
            return false;
        }
        
        private void assignProduct()
        {
            try
            {
                if (validateInputsUsers())
                {
                    AssignProductsController.Crear(Int32.Parse(txtBoxIDProduct.Text), Int32.Parse(txtBoxIDLote.Text));
                    MessageBox.Show(Languages.Messages.Successful);
                    RefreshTable();
                    ClearTxtBoxes();
                }
                else
                {
                    MessageBox.Show(Languages.Messages.CompleteAllBoxAndStatus);
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Error!" + ex.Message);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            assignProduct();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewAssignedProducts.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridViewAssignedProducts.SelectedRows[0].Index;
                int id = (int)dataGridViewAssignedProducts.Rows[selectedIndex].Cells["Lote ID"].Value;
                DataTable dataTableAssignedProduct = (DataTable)dataGridViewAssignedProducts.DataSource;
                dataTableAssignedProduct.Rows.RemoveAt(selectedIndex);
                MessageBox.Show(Languages.Messages.Successful);
                AssignProductsController.DeleteAssignedProduct(id);
                dataGridViewAssignedProducts.DataSource = dataTableAssignedProduct;
                RefreshTable();

            }
        }

    }
}
