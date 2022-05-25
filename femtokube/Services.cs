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
   
    public partial class Services : Form
    {
        public Services()
        {
            InitializeComponent();
        }

        private void Services_Load(object sender, EventArgs e)
        {
            getNamespaces();
        }

        private void getNamespaces()
        {
            String url = "http://192.168.50.128:8001/api/v1/namespaces";
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
                listBoxServices.Items.Clear();
                getServicesByNamespaceName();
                pictureBox1.Visible = true;
                pictureBox2.Visible = true;
                pictureBox3.Visible = true;
            }
        }

        private void getServicesByNamespaceName()
        {
            String url = "http://192.168.50.128:8001/api/v1/namespaces/" + listBoxNamespaces.SelectedItem + "/services";
            var myWebClient = new WebClient();
            var json = myWebClient.DownloadString(url);
            dynamic convertObj = JObject.Parse(json);
            foreach (var item in convertObj.items)
            {
                listBoxServices.Items.Add(item.metadata.name);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (listBoxServices.SelectedItem == null)
            {
                MessageBox.Show("Select a service first");
            }
            else
            {
                var serviceDetails = new ServiceDetails(listBoxNamespaces.SelectedItem.ToString(), listBoxServices.SelectedItem.ToString());
                serviceDetails.Show();
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            var serviceAdd = new ServiceAdd(listBoxNamespaces.SelectedItem.ToString());
            serviceAdd.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if(listBoxServices.SelectedItem == null)
            {
                MessageBox.Show("Select a service to delete");
            }
            else
            {
                deleteService();
            }
        }

        private void deleteService()
        {
            var progressBarForm = new ProgressBarForm();
            String address = "http://192.168.50.128:8001/api/v1/namespaces/" + listBoxNamespaces.SelectedItem + "/services/" + listBoxServices.SelectedItem;
            WebRequest request = WebRequest.Create(address);
            request.Method = "DELETE";
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete the service: " + listBoxServices.SelectedItem, "Delete Service", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                progressBarForm.Show();
                this.Close();
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }
    }
}
