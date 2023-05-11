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

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void AddShopButton_Click(object sender, EventArgs e)
        {
            if (ValidateFields()) 
            {
                Shop = new Shop
                {
                    Name = AddNameTextBox.Text,
                    Address = AddAddressTextBox.Text,
                    Telephone = AddPhoneTextBox.Text,
                    Specialization = AddSpecializationTextBox.Text,
                    Ownership = AddOwnershipTextBox.Text,
                    WorkingHours = AddWorkingHoursTextBox.Text
                };
                this.DialogResult = DialogResult.OK;
            }
        }
        private bool ValidateFields()
        {
            if (AddNameTextBox.Text.Length < 2)
            {
                MessageBox.Show("Поле 'Name' має містити не менше 2 символів.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (AddAddressTextBox.Text.Length < 2)
            {
                MessageBox.Show("Поле 'Address' має містити не менше 2 символів.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (AddPhoneTextBox.Text.Length < 2)
            {
                MessageBox.Show("Поле 'Telephone' має містити не менше 2 символів.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (AddSpecializationTextBox.Text.Length < 2)
            {
                MessageBox.Show("Поле 'Specialization' має містити не менше 2 символів.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (AddOwnershipTextBox.Text.Length < 2)
            {
                MessageBox.Show("Поле 'Ownership' має містити не менше 2 символів.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (AddWorkingHoursTextBox.Text.Length < 2)
            {
                MessageBox.Show("Поле 'Working Hours' має містити не менше 2 символів.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!int.TryParse(AddPhoneTextBox.Text, out _))
            {
                MessageBox.Show("Поле 'Telephone' має містити цифрові значення.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            //if (!int.TryParse(AddWorkingHoursTextBox.Text, out _))
            //{
            //MessageBox.Show("Поле 'Working Hours' має містити цифрові значення.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //return false;
            //}
            if (!IsValidWorkingHours(AddWorkingHoursTextBox.Text))
            {
                MessageBox.Show("Неприпустимий формат поля 'Working Hours'.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;

        }
        private bool IsValidWorkingHours(string input)
        {
            string pattern = @"^\d{1,2}([-:]?\d{1,2})?([-:]?\d{1,2})?$";

            return Regex.IsMatch(input, pattern);
        }
    }
}
