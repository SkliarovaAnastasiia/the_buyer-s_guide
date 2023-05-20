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
        }
        private void AddShopForm_Load(object sender, EventArgs e)
        {
           
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void addShopButton_Click(object sender, EventArgs e)
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
            if (addNameTextBox.Text.Length < 2)
            {
                MessageBox.Show("Поле 'Name' має містити не менше 2 символів.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (addAddressTextBox.Text.Length < 2)
            {
                MessageBox.Show("Поле 'Address' має містити не менше 2 символів.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (addPhoneTextBox.Text.Length < 2)
            {
                MessageBox.Show("Поле 'Telephone' має містити не менше 2 символів.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!int.TryParse(addPhoneTextBox.Text, out _))
            {
                MessageBox.Show("Поле 'Telephone' має містити цифрові значення.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (addSpecializationTextBox.Text.Length < 2)
            {
                MessageBox.Show("Поле 'Specialization' має містити не менше 2 символів.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (addOwnershipTextBox.Text.Length < 2)
            {
                MessageBox.Show("Поле 'Ownership' має містити не менше 2 символів.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (addWorkingHoursTextBox.Text.Length < 2)
            {
                MessageBox.Show("Поле 'Working Hours' має містити не менше 2 символів.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!IsValidWorkingHours(addWorkingHoursTextBox.Text))
            {
                MessageBox.Show("Неприпустимий формат поля 'Working Hours'.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
