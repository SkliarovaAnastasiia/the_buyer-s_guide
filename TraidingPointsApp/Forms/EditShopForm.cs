using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using TraidingPointsApp.Data;
using TraidingPointsApp.Models;

namespace TraidingPointsApp
{

    public partial class EditShopForm : Form
    {
        public Shop Shop;
        TraidingPoints traidingPoints;

        public EditShopForm(Shop shop)
        {
            InitializeComponent();
            Shop = shop;
            editNameTextBox.Text = shop.Name;
            editAddressTextBox.Text = shop.Address;
            editPhoneTextBox.Text = shop.Telephone;
            editSpecializationTextBox.Text = shop.Specialization;
            editOwnershipTextBox.Text = shop.Ownership;
            editWorkingHoursTextBox.Text = shop.WorkingHours;
            this.KeyDown += EditShopForm_KeyDown;
            this.KeyPreview = true;
        }

        private void EditShopForm_Load(object sender, EventArgs e)
        {

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void EditShopForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DialogResult result = MessageBox.Show("Do you want to save changes?", "Edit confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    EditShop();
                }

                else if (result == DialogResult.No)
                {
                    this.DialogResult = DialogResult.Cancel;
                }
            }
        }

        private void editShopButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to save changes?", "Edit confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                EditShop();
            }
        }

        private void EditShop()
        {
            if (ValidateFields())
            {
                Shop.Name = editNameTextBox.Text;
                Shop.Address = editAddressTextBox.Text;
                Shop.Telephone = editPhoneTextBox.Text;
                Shop.Specialization = editSpecializationTextBox.Text;
                Shop.Ownership = editOwnershipTextBox.Text;
                Shop.WorkingHours = editWorkingHoursTextBox.Text;
                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidateFields()
        {
            if (editNameTextBox.Text.Length < 2 && editNameTextBox.Text.Length < 100)
            {
                MessageBox.Show("The 'Name' field must contain from 2 to 100 symbols!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (editAddressTextBox.Text.Length < 2 && editAddressTextBox.Text.Length < 100)
            {
                MessageBox.Show("The 'Address' field must contain from 2 to 100 symbols!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (editPhoneTextBox.Text.Length < 2 && editPhoneTextBox.Text.Length < 100)
            {
                MessageBox.Show("The 'Telephone' field must contain from 2 to 100 symbols!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!int.TryParse(editPhoneTextBox.Text, out _))
            {
                MessageBox.Show("The 'Telephone' field must contain only digital symbols!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (editSpecializationTextBox.Text.Length < 2 && editSpecializationTextBox.Text.Length < 100)
            {
                MessageBox.Show("The 'Specialization' field must contain from 2 to 100 symbols!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (editOwnershipTextBox.Text.Length < 2 && editOwnershipTextBox.Text.Length < 100)
            {
                MessageBox.Show("The 'Ownership' field must contain from 2 to 100 symbols!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (editWorkingHoursTextBox.Text.Length < 2 && editWorkingHoursTextBox.Text.Length < 100)
            {
                MessageBox.Show("The 'Working hours' field must contain from 2 to 100 symbols!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!IsValidWorkingHours(editWorkingHoursTextBox.Text))
            {
                MessageBox.Show("The 'Working hours' field should be in the following format: opening hours:minutes-closing hours:minutes!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
        private bool IsValidWorkingHours(string input)
        {
            string pattern = @"^(\d{1,2}):(\d{2})\s*-\s*(\d{1,2}):(\d{2})$";

            return Regex.IsMatch(input, pattern);
        }
    }
}
