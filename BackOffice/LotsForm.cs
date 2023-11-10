﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BackOffice.crudForms;
using capa_logica;

namespace BackOffice
{
    public partial class LotsForm : Form
    {

        public event Action LanguageChanged;

        public LotsForm()
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

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddBatchForm addbatchcomponent = new AddBatchForm();
            addbatchcomponent.Show();

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
                MessageBox.Show(Languages.Messages.Successful);
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
