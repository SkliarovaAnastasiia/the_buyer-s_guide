using System;
using System.Windows.Forms;
using TraidingPointsApp.Data;
using TraidingPointsApp.Models;

namespace TraidingPointsApp
{
    public partial class MainForm : Form
    {
        TraidingPoints traidingPoints;
        public MainForm()
        {
            InitializeComponent();
            traidingPoints = new TraidingPoints();
            //traidingPoints.GenTestData(1);
            shopBindingSource.DataSource = traidingPoints.Shops;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataAccess.Save(traidingPoints);
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
           
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataAccess.Load(traidingPoints);
            //shopBindingSource.ResetBindings(true);
            shopBindingSource.DataSource = traidingPoints.Shops;
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            traidingPoints.Shops.Clear();
            shopBindingSource. Clear();
            //shopBindingSource.ResetBindings(true);
        }

        private void AddShopButton_Click(object sender, EventArgs e)
        {
            AddShopForm addShopForm = new AddShopForm();
            var dialogRes = addShopForm.ShowDialog();
            if(dialogRes == DialogResult.OK)
            {
                traidingPoints.Shops.Add(addShopForm.Shop);
                shopBindingSource.ResetBindings(true);
            }
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete the current record?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                shopBindingSource.RemoveCurrent();
            }

        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
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
            }
        }
    }
}
