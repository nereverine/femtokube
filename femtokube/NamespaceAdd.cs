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
    public partial class NamespaceAdd : Form
    {
        private String address;
        public NamespaceAdd(String address)
        {
            InitializeComponent();
            this.address = address;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text == "")
            {
                MessageBox.Show("Name required");
            }
            else {
                String url = address+"api/v1/namespaces/";
                var myWebClient = new WebClient();
                String json = "{\"kind\":\"Namespace\",\"apiVersion\":\"v1\",\"metadata\":{\"name\":" + "\"" + textBoxName.Text + "\"}}";

                try
                {
                    var response = myWebClient.UploadString(url, json);
                    dynamic convertObj = JObject.Parse(response);
                    MessageBox.Show("Namespace " + textBoxName.Text + " created successfully!");
                    this.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Namespace not created");
                }
            }
        }

        private void NamespaceAdd_Load(object sender, EventArgs e)
        {

        }
    }
}
