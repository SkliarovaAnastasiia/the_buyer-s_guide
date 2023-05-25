using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using TraidingPointsApp.Models;

namespace TraidingPointsApp
{
    public partial class AddShopForm : Form
    {
        public Shop Shop;
      
        public AddShopForm()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += AddShopForm_KeyDown;
        }
        private void AddShopForm_Load(object sender, EventArgs e)
        {
           
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void addWorkingHoursTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                AddShop();
            }
        }

        private void AddShopForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AddShop();
            }
        }

        private void addShopButton_Click(object sender, EventArgs e)
        {
            AddShop();
        }

        private void AddShop()
        {
            if (ValidateFields())
            {
                Shop = new Shop
                {
                    Name = addNameTextBox.Text,
                    Address = addAddressTextBox.Text,
                    Telephone = addPhoneTextBox.Text,
                    Specialization = addSpecializationTextBox.Text,
                    Ownership = addOwnershipTextBox.Text,
                    WorkingHours = addWorkingHoursTextBox.Text
                };
                this.DialogResult = DialogResult.OK;
            }
        }

        private bool ValidateFields()
        {
            if (addNameTextBox.Text.Length < 2 && addNameTextBox.Text.Length < 100)
            {
                MessageBox.Show("The 'Name' field must contain from 2 to 100 symbols!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (addAddressTextBox.Text.Length < 2 && addAddressTextBox.Text.Length < 100)
            {
                MessageBox.Show("The 'Address' field must contain from 2 to 100 symbols!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (addPhoneTextBox.Text.Length < 2 && addPhoneTextBox.Text.Length < 100)
            {
                MessageBox.Show("The 'Telephone' field must contain from 2 to 100 symbols!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!int.TryParse(addPhoneTextBox.Text, out _))
            {
                MessageBox.Show("The 'Telephone' field must contain only digital symbols!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (addSpecializationTextBox.Text.Length < 2 && addSpecializationTextBox.Text.Length < 100)
            {
                MessageBox.Show("The 'Specialization' field must contain from 2 to 100 symbols!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (addOwnershipTextBox.Text.Length < 2 && addOwnershipTextBox.Text.Length < 100)
            {
                MessageBox.Show("The 'Ownership' field must contain from 2 to 100 symbols!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (addWorkingHoursTextBox.Text.Length < 2 && addWorkingHoursTextBox.Text.Length < 100)
            {
                MessageBox.Show("The 'Working hours' field must contain from 2 to 100 symbols!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!IsValidWorkingHours(addWorkingHoursTextBox.Text))
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
