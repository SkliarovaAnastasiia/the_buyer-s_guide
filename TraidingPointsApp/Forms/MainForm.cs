using System;
using System.Windows.Forms;
using TraidingPointsApp.Data;
using TraidingPointsApp.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TraidingPointsApp
{
    public partial class MainForm : Form
    {
        TraidingPoints traidingPoints;
        List<Shop> favorites = new List<Shop>();

        public MainForm()
        {
            InitializeComponent();
            traidingPoints = new TraidingPoints();
            shopBindingSource.DataSource = traidingPoints.Shops;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            dataGridView1.ReadOnly = true;
            DataAccess.Load(traidingPoints);
            shopBindingSource.ResetBindings(true);
            shopBindingSource.DataSource = traidingPoints.Shops;
            favorites = DataAccess.LoadFavorites();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (traidingPoints.IsFavoritesDisplayed)
            {
                return;
            }
            DataAccess.Save(traidingPoints);
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
           
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataAccess.Load(traidingPoints);
            shopBindingSource.ResetBindings(true);
            shopBindingSource.DataSource = traidingPoints.Shops;
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (traidingPoints.IsFavoritesDisplayed)
            {
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure that you want to clear the list of shops?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

             if (result == DialogResult.Yes)
             {
                    traidingPoints.Shops.Clear();
                    shopBindingSource.Clear();
                    shopBindingSource.ResetBindings(true);
                    DataAccess.Save(traidingPoints);
             }
        }

        private bool ShopExists(Shop shop)
        {
            return traidingPoints.Shops.Exists(existingShop =>
                existingShop.Name == shop.Name &&
                existingShop.Address == shop.Address &&
                existingShop.Telephone == shop.Telephone &&
                existingShop.Specialization == shop.Specialization &&
                existingShop.Ownership == shop.Ownership &&
                existingShop.WorkingHours == shop.WorkingHours);
        }

        private void addShopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (traidingPoints.IsFavoritesDisplayed)
            {
                return;
            }

            var addShopForm = new AddShopForm();
            var dialogRes = addShopForm.ShowDialog();

            if (dialogRes == DialogResult.OK)
            {
                if (addShopForm.Shop != null) 
                {
                    if (ShopExists(addShopForm.Shop))
                    {
                        MessageBox.Show("Shop with the same fields already exists!", "Duplicate Shop", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    traidingPoints.Shops.Insert(0, addShopForm.Shop);
                    shopBindingSource.ResetBindings(true);
                    traidingPoints.IsDirty = true;
                    //DataAccess.Save(traidingPoints);
                }
            }
        }

        private void removeShopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (traidingPoints.IsFavoritesDisplayed)
            {
                return;
            }

            var currentShop = shopBindingSource.Current as Shop;

            if (currentShop != null )
            {
                DialogResult result = MessageBox.Show("Are you sure that you want to delete the current shop?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    shopBindingSource.RemoveCurrent();
                    traidingPoints.Shops.Remove(currentShop);
                    favorites.Remove(currentShop);
                    traidingPoints.IsDirty = true;
                    //DataAccess.Save(traidingPoints);
                    //DataAccess.SaveFavorites(favorites);
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void editShopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (traidingPoints.IsFavoritesDisplayed)
            {
                return;
            }

            var selectedRow = dataGridView1.CurrentRow;

            if (selectedRow == null)
            {
                return;
            }

            var selectedShop = selectedRow.DataBoundItem as Shop;

            if (selectedShop == null)
            {
                return;
            }

            EditShopForm editShopForm = new EditShopForm(selectedShop);

            if (editShopForm.ShowDialog() == DialogResult.OK)
            {
                shopBindingSource.ResetBindings(true);
                traidingPoints.IsDirty = true;
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!traidingPoints.IsDirty && !traidingPoints.IsFavoritesDirty)
                return;

            var res = MessageBox.Show("Do you want to save changes?", "", MessageBoxButtons.YesNoCancel);

            switch (res)
            {
                case DialogResult.Yes:
                    DataAccess.Save(traidingPoints);
                    DataAccess.SaveFavorites(favorites);
                    break;
                case DialogResult.No:
                    break;
                case DialogResult.Cancel:
                    e.Cancel = true;
                    break;
            }
        }

        private void Search()
        {
            List<Shop> result;

            if (traidingPoints.IsFavoritesDisplayed)
            {
                result = traidingPoints.SearchFavoriteShops(searchBox.Text.ToLower());
            }

            else
            {
                result = traidingPoints.SearchShops(searchBox.Text.ToLower());
            }
             
            shopBindingSource.DataSource = result;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void searchBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                Search();
            }
        }

        private void toFavouriteToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void showFavoritesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (traidingPoints.IsDirty)
            {
                var res = MessageBox.Show("Do you want to save changes in trading points list?", "", MessageBoxButtons.YesNo);

                switch (res)
                {
                    case DialogResult.Yes:
                        DataAccess.Save(traidingPoints);
                        break;
                    case DialogResult.No:
                        break;
                }
            }

            favorites = DataAccess.LoadFavorites();

            if (favorites != null)
            {
                shopBindingSource.DataSource = favorites;
                traidingPoints.IsFavoritesDisplayed = true;
            }
        }

        private void addToFavoriteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var currentShop = shopBindingSource.Current as Shop;

            if (currentShop != null && currentShop.Name != null &&
                !favorites.Any(shop =>
                    shop.Name == currentShop.Name &&
                    shop.Address == currentShop.Address &&
                    shop.Telephone == currentShop.Telephone &&
                    shop.Specialization == currentShop.Specialization &&
                    shop.Ownership == currentShop.Ownership &&
                    shop.WorkingHours == currentShop.WorkingHours))
            {
                favorites.Insert(0, currentShop);
                DataAccess.SaveFavorites(favorites);
            }
        }

        private void saveToFavoritesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!traidingPoints.IsFavoritesDisplayed)
            {
                return;
            }

            List<Shop> favoriteShops = new List<Shop>();

            foreach (var item in shopBindingSource)
            {
                var shop = item as Shop;

                if (favorites.Contains(shop) && !favoriteShops.Contains(shop))
                {
                    favoriteShops.Add(shop);
                }
            }

            StringBuilder sb = new StringBuilder();

            foreach (var shop in favoriteShops)
            {
                sb.AppendLine($"{shop.Name}\r\n{shop.Address}\r\n{shop.Telephone}\r\n{shop.Specialization}\n");
            }

            string shopText = sb.ToString();
            DataAccess.SaveTextToFile(shopText, "FavoriteShops.txt");
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            searchBox.KeyDown += searchBox_KeyDown;
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (traidingPoints.IsFavoritesDirty == true)
            {
                var res = MessageBox.Show("Do you want to save changes in favorite trading points list?", "", MessageBoxButtons.YesNo);

                switch (res)
                {
                    case DialogResult.Yes:
                        DataAccess.SaveFavorites(favorites);
                        break;
                    case DialogResult.No:
                        break;
                }
            }

            traidingPoints.IsFavoritesDisplayed = false;
            DataAccess.Load(traidingPoints);
            shopBindingSource.ResetBindings(true);
            shopBindingSource.DataSource = traidingPoints.Shops;
        }

        private void removeFromFavoriteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!traidingPoints.IsFavoritesDisplayed)
            {
                return;
            }

            var currentShop = shopBindingSource.Current as Shop;

            if (currentShop != null)
            {
                DialogResult result = MessageBox.Show("Are you sure that you want to delete the current shop?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    shopBindingSource.RemoveCurrent();
                    favorites.Remove(currentShop);
                    traidingPoints.IsFavoritesDirty = true;
                }
            }
        }

        private void removeAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!traidingPoints.IsFavoritesDisplayed)
            {
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure that you want to delete all favorite shops?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                traidingPoints.Favorites.Clear();
                shopBindingSource.Clear();
                shopBindingSource.ResetBindings(true);
                traidingPoints.IsFavoritesDirty = true;
                //DataAccess.SaveFavorites(favorites);
            }
        }
    }
}
