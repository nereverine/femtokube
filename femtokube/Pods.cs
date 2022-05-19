using Newtonsoft.Json.Linq;
using System;
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
    public partial class Pods : Form
    {
        public Pods()
        {
            InitializeComponent();
        }

        private void Pods_Load(object sender, EventArgs e)
        {
            getNamespaces();
        }

        private void getNamespaces()
        {
            String url = "http://192.168.50.128:8001/api/v1/namespaces/";
            var myWebClient = new WebClient();
            var json = myWebClient.DownloadString(url);
            dynamic convertObj = JObject.Parse(json);
            foreach (var item in convertObj.items)
            {
                listBoxNamespaces.Items.Add(item.metadata.name);
            }
        }

        private void listBoxNamespaces_SelectedIndexChanged(object sender, EventArgs e)
        {
            Size = new Size(323, 400);
            listBoxPods.Items.Clear();
            getPodsByNamespaceName();
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;

        }

        private void getPodsByNamespaceName()
        {
            String url = "http://192.168.50.128:8001/api/v1/namespaces/" + this.listBoxNamespaces.SelectedItem + "/pods";
            var myWebClient = new WebClient();
            var json = myWebClient.DownloadString(url);
            dynamic convertObj = JObject.Parse(json);
            foreach (var item in convertObj.items)
            {
                listBoxPods.Items.Add(item.metadata.name);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if(listBoxPods.SelectedItem == null)
            {
                MessageBox.Show("Select a pod first");
            }
            else
            {
                var podAdd = new PodDetails(listBoxNamespaces.SelectedItem.ToString(), listBoxPods.SelectedItem.ToString());
                podAdd.Show();
            }
        }
    }
}
