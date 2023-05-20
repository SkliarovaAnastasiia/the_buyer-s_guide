using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using TraidingPointsApp.Models;

namespace TraidingPointsApp
{

    public partial class EditShopForm : Form
    {
        public Shop Shop;
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
                DialogResult confirmResult = MessageBox.Show("Do you want to save changes?", "Edit confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
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
                else if (confirmResult == DialogResult.No)
                {
                    this.DialogResult = DialogResult.Cancel;
                }
            }
        }

        private void editShopButton_Click(object sender, EventArgs e)
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
            if (editNameTextBox.Text.Length < 2)
            {
                MessageBox.Show("Поле 'Name' має містити не менше 2 символів.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (editAddressTextBox.Text.Length < 2)
            {
                MessageBox.Show("Поле 'Address' має містити не менше 2 символів.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (editPhoneTextBox.Text.Length < 2)
            {
                MessageBox.Show("Поле 'Telephone' має містити не менше 2 символів.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!int.TryParse(editPhoneTextBox.Text, out _))
            {
                MessageBox.Show("Поле 'Telephone' має містити цифрові значення.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (editSpecializationTextBox.Text.Length < 2)
            {
                MessageBox.Show("Поле 'Specialization' має містити не менше 2 символів.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (editOwnershipTextBox.Text.Length < 2)
            {
                MessageBox.Show("Поле 'Ownership' має містити не менше 2 символів.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (editWorkingHoursTextBox.Text.Length < 2)
            {
                MessageBox.Show("Поле 'Working Hours' має містити не менше 2 символів.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!IsValidWorkingHours(editWorkingHoursTextBox.Text))
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
