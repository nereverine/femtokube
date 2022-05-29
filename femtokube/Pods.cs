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
        private String address;
        public Pods(String address)
        {
            InitializeComponent();
            this.address = address;
        }

        private void Pods_Load(object sender, EventArgs e)
        {
            getNamespaces();
        }

        private void getNamespaces()
        {
            String url = address+"api/v1/namespaces/";
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
                listBoxPods.Items.Clear();
                getPodsByNamespaceName();
                pictureBox1.Visible = true;
                pictureBox2.Visible = true;
                pictureBox3.Visible = true;
            }

        }

        private void getPodsByNamespaceName()
        {
            listBoxPods.Items.Clear();
            String url =  address+"api/v1/namespaces/" + this.listBoxNamespaces.SelectedItem + "/pods";
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
                var podDetails = new PodDetails(listBoxNamespaces.SelectedItem.ToString(), listBoxPods.SelectedItem.ToString(), address);
                podDetails.Show();
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            var podAdd = new PodAdd(listBoxNamespaces.SelectedItem.ToString(), address);
            podAdd.Show();
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if(listBoxPods.SelectedItem == null)
            {
                MessageBox.Show("Select a Pod to delete first");
                return;
            }
            else
            {

                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete the Pod: " + listBoxNamespaces.SelectedItem, "Delete Pod", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        String url = address + "api/v1/namespaces/" + listBoxNamespaces.SelectedItem + "/pods/" + listBoxPods.SelectedItem;
                    WebRequest request = WebRequest.Create(url);
                    request.Method = "DELETE";
                    HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                    MessageBox.Show("Pod deleted successfully");
                    getPodsByNamespaceName();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());

                    }
                }
                else if (dialogResult == DialogResult.No)
                {
                    return;
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
