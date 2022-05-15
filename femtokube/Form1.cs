namespace femtokube
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonNodes_Click(object sender, EventArgs e)
        {
            var nodes = new Nodes();
            nodes.Show();
        }
    }
}