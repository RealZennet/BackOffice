﻿using capa_logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackOffice.crudForms
{
    public partial class EditDestinationForm : Form
    {

        public event Action LanguageChanged;
        private int x, y, m;

        public EditDestinationForm()
        {
            InitializeComponent();
            QuickCarry mainForm = Application.OpenForms.OfType<QuickCarry>().FirstOrDefault();
            if (mainForm != null)
            {
                mainForm.LanguageChanged += updateLanguage;
            }
            LanguageManager.Initialize(typeof(BackOffice.Languages.Resource_language_spanish));
            LanguageManager.Initialize(typeof(BackOffice.Languages.Resource_language_english));
            comboBoxStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxStatus.Items.Add("true");
            comboBoxStatus.Items.Add("false");
            comboBoxStatus.SelectedItem = "true";
            roundedCircleForm();
        }

        private void roundedCircleForm()
        {
            int radiusBorder = 25;

            Rectangle rectangleBorder = new Rectangle(0, 0, this.Width, this.Height);

            GraphicsPath graphicBorder = new GraphicsPath();
            graphicBorder.AddArc(rectangleBorder.X, rectangleBorder.Y, radiusBorder, radiusBorder, 180, 90);
            graphicBorder.AddArc(rectangleBorder.Right - radiusBorder, rectangleBorder.Y, radiusBorder, radiusBorder, 270, 90);
            graphicBorder.AddArc(rectangleBorder.Right - radiusBorder, rectangleBorder.Bottom - radiusBorder, radiusBorder, radiusBorder, 0, 90);
            graphicBorder.AddArc(rectangleBorder.X, rectangleBorder.Bottom - radiusBorder, radiusBorder, radiusBorder, 90, 90);
            graphicBorder.CloseAllFigures();

            this.Region = new Region(graphicBorder);
        }

        private void updateLanguage()
        {
            labelActivated.Text = LanguageManager.GetString("Activated");
            labelShipDate.Text = LanguageManager.GetString("DateOfShipment");
            labelStreet.Text = LanguageManager.GetString("Street");
            labelCorner.Text = LanguageManager.GetString("Corner");
            labelNumber.Text = LanguageManager.GetString("Number");
            buttonSave.Text = LanguageManager.GetString("Save");
            buttonCancel.Text = LanguageManager.GetString("Cancel");
        }

        private bool ValidateInputsUser()
        {

            if (string.IsNullOrWhiteSpace(txtBoxDestinationStreet.Text))
            {
                return false;
            }

            return true;
        }

        private void clearTxtBoxs()
        {
            txtBoxDestinationStreet.Clear();
            txtBoxDestinationDoorNumber.Clear();
            txtBoxDestinationCorner.Clear();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime separateddate = dateTimePickerDestinationManagement.Value.Date;
                DateTime separatedtime = dateTimePickerDestinationManagementTime.Value;
                DateTime dateandtime = separateddate.Add(separatedtime.TimeOfDay);
                string selectedStatus = comboBoxStatus.SelectedItem as string;
                if (ValidateInputsUser() && !string.IsNullOrWhiteSpace(selectedStatus))
                {
                    int statusValue = selectedStatus == "true" ? 1 : 0;
                    DestinationController.EditDestination(Int32.Parse(txtBoxIDDestination.Text), txtBoxDestinationStreet.Text, txtBoxDestinationDoorNumber.Text, txtBoxDestinationCorner.Text, dateandtime, Convert.ToBoolean(statusValue));
                    MessageBox.Show(Languages.Messages.Successful);
                }
                else
                {
                    MessageBox.Show(Languages.Messages.CompleteAllBoxAndStatus);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

    }
}