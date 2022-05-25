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

        private void buttonNamespaces_Click(object sender, EventArgs e)
        {
            var namespaces = new Namespaces();
            namespaces.Show();
        }

        private void buttonPods_Click(object sender, EventArgs e)
        {
            var pods = new Pods();
            pods.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var deployments = new Deployments();
            deployments.Show();
        }

        private void buttonServices_Click(object sender, EventArgs e)
        {
            var services = new Services();
            services.Show();
        }
    }
}