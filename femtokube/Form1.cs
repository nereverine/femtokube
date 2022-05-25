using Newtonsoft.Json.Linq;
using System.Net;

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
            getUsages();
        }

        private void getUsages()
        {
            try
            {
                int counter = 0;
                String url = "http://192.168.50.128:8001/apis/metrics.k8s.io/v1beta1/nodes/";
                var myWebClient = new WebClient();
                var json = myWebClient.DownloadString(url);
                dynamic convertObj = JObject.Parse(json); 
                
                foreach (var item in convertObj.items)
                {
                    counter++;
                    if(counter == 1)
                    {
                        groupBox2.Text = item.metadata.name;
                        groupBox2.Visible = true; 
                        labelCPU1.Text = cpuPercentage(item.usage.cpu.ToString());
                        labelCPU1.ForeColor = cpuPercentageColor(labelCPU1.Text);
                        labelMemory1.Text = memoryUsage(item.usage.memory.ToString());
                    }
                    else if(counter == 2)
                    {
                        groupBox3.Text = item.metadata.name;
                        groupBox3.Visible = true;
                        labelCPU2.Text = cpuPercentage(item.usage.cpu.ToString());
                        labelCPU2.ForeColor = cpuPercentageColor(labelCPU1.Text);
                        labelMemory2.Text = memoryUsage(item.usage.memory.ToString());
                    }
                    else if (counter == 3)
                    {
                        groupBox4.Text = item.metadata.name;
                        groupBox4.Visible = true;
                        labelCPU3.Text = cpuPercentage(item.usage.cpu.ToString());
                        labelCPU3.ForeColor = cpuPercentageColor(labelCPU1.Text);
                        labelMemory3.Text = memoryUsage(item.usage.memory.ToString());
                    }
                }
            }
            catch (Exception e)
            {

                labelError.Visible = true;
            }



        }

        private String memoryUsage(String memory)
        {
            String formatedMemory = memory.Remove(memory.Length - 2);
            int rounded = Convert.ToInt32(float.Parse(formatedMemory) * 0.001024);
            return rounded.ToString() + "MB";

        }

        private String cpuPercentage(String cpu)
        {
            cpu = cpu.Remove(cpu.Length - 1);
            int rounded = Convert.ToInt32(float.Parse(cpu) / 1000000000 * 100);        
            return rounded + "%";
        }

        private Color cpuPercentageColor(String cpuString)
        {
            String cpu = cpuString.Remove(cpuString.Length-1);
            int value = Convert.ToInt32(cpu);
            if(value <= 49)
            {
                return Color.Green;
            }
            else if (value > 49 && value <= 75)
            {
                return Color.Yellow;
            }
            else
            {
                return Color.Red;
            }
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