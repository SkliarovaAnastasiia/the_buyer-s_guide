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
            traidingPoints.GenTestData(15);
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
    }
}
