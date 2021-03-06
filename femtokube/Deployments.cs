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
    public partial class Deployments : Form
    {

        private String address;
        public Deployments(String address)
        {
            InitializeComponent();
            this.address = address;

        }

        private void getNamespaces()
        {
            String url = address+"api/v1/namespaces";
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
            if (listBoxNamespaces.SelectedIndex == -1)
            {
                return;
            }
            else
            {
                Size = new Size(323, 400);
                listBoxDeployments.Items.Clear();
                getDeploymentsByNamespaceName();
                pictureBox1.Visible = true;
                pictureBox2.Visible = true;
                pictureBox3.Visible = true;
            }
        }

        private void getDeploymentsByNamespaceName()
        {
            String url = address+"apis/apps/v1/namespaces/"+listBoxNamespaces.SelectedItem+"/deployments";
            var myWebClient = new WebClient();
            var json = myWebClient.DownloadString(url);
            dynamic convertObj = JObject.Parse(json);
            foreach (var item in convertObj.items)
            {
                listBoxDeployments.Items.Add(item.metadata.name);
            }
        }

        private void Deployments_Load(object sender, EventArgs e)
        {
            getNamespaces();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (listBoxDeployments.SelectedItem != null)
            {
                var deploymentAdd = new DeploymentDetails(listBoxNamespaces.SelectedItem.ToString(), listBoxDeployments.SelectedItem.ToString(), address);
                deploymentAdd.Show();
            }
            else
            {
                MessageBox.Show("Select a deployment to view first");
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            var deploymentAdd = new DeploymentAdd(listBoxNamespaces.SelectedItem.ToString(), address);
            deploymentAdd.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (listBoxDeployments.SelectedItem == null)
            {
                MessageBox.Show("Select a Namespace to delete first");
                return;
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Delete the Deployment: " + listBoxDeployments.SelectedItem, "Delete Deployment", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        String url = address + "apis/apps/v1/namespaces/" + listBoxNamespaces.SelectedItem + "/deployments/" + listBoxDeployments.SelectedItem;
                        WebRequest request = WebRequest.Create(url);
                        request.Method = "DELETE";
                        HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                        MessageBox.Show("Deployment deleted successfully");

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());

                    }
                }
            }
        }
    }
}
