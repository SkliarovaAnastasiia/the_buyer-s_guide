using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TradingPoints.Models;

namespace TradingPoints
{
    public partial class MainForm : Form
    {
        Points points;
        public MainForm()
        {
            InitializeComponent();
            points = new Points();
            points.GenTestData(15);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
