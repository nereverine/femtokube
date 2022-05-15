using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace femtokube
{
    public partial class Nodes : Form
    {
        ArrayList nodeNames = new ArrayList();
        private int counter;

        public Nodes()
        {
            InitializeComponent();
        }

        private void Nodes_Load(object sender, EventArgs e)
        {
            getNodes();
        }

        private void getNodes()
        {
            String url = "http://192.168.50.128:8001/api/v1/nodes/";
            var myWebClient = new WebClient();
            var json = myWebClient.DownloadString(url);
            dynamic convertObj = JObject.Parse(json);
            foreach (var item in convertObj.items)
            {
                listBoxNodes.Items.Add(item.metadata.name);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (counter == 0)
            {
                this.Show();
                timer1.Stop();
                getNodes();
            }
            else
            {
                this.Hide();
            }
            counter--;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (listBoxNodes.SelectedItem == null)
            {
                MessageBox.Show("Select a node to view first");
            }
            else
            {
                var nodeDetails = new NodeDetails(listBoxNodes.SelectedItem.ToString());
                nodeDetails.Show();
            }
        }
    }
}
