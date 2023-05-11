using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using the_buyer_s_guide.Data;
using the_buyer_s_guide.Models;
using System.Text.Json;

namespace the_buyer_s_guide
{
    public partial class AllPoints : Form
    {
        TraidingDataModel traidingDataModel;

        public AllPoints()
        {
            InitializeComponent();
            traidingDataModel = new TraidingDataModel();
            traidingDataModel.GenTestData(15);
        }

        private void AllPoints_Load(object sender, EventArgs e)
        {
            
        }

        private void SaveOption_Click(object sender, EventArgs e)
        {
            DataAccess.Save(traidingDataModel);
        }

        private void LoadOption_Click(object sender, EventArgs e)
        {
            DataAccess.Load(traidingDataModel);
        }

        private void GridForPoints_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pointsList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
