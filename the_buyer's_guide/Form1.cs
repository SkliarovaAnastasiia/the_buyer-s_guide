namespace the_buyer_s_guide
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            SearchForm searchForm = new SearchForm();
            searchForm.Show();
        }
    }
}