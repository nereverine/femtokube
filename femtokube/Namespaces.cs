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
    public partial class Namespaces : Form
    {
        private String address;
        public Namespaces(String address)
        {
            InitializeComponent();
            this.address = address;
        }

        private void Namespaces_Load(object sender, EventArgs e)
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (listBoxNamespaces.SelectedItem == null)
            {
                MessageBox.Show("Select a namespace to view first");
            }
            else
            {
                var namespaceDetails = new NamespaceDetails(listBoxNamespaces.SelectedItem.ToString());
                namespaceDetails.Show();
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            var namespaceAdd = new NamespaceAdd();
            namespaceAdd.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (listBoxNamespaces.SelectedItem == null)
            {
                MessageBox.Show("Select a namespace to delete first");
            }
            else
            {
                deleteNamespace();
            }
        }

        private void deleteNamespace()
        {
            var progressBarForm = new ProgressBarForm();
            String url = address+"api/v1/namespaces/" + listBoxNamespaces.SelectedItem;
            WebRequest request = WebRequest.Create(url);
            request.Method = "DELETE";
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete the namespace: " + listBoxNamespaces.SelectedItem , "Delete Namespace", MessageBoxButtons.YesNo);
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
