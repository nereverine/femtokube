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
        public NamespaceAdd()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            String address = "http://192.168.50.128:8001/api/v1/namespaces/";
            var myWebClient = new WebClient();
            String json = "{\"kind\":\"Namespace\",\"apiVersion\":\"v1\",\"metadata\":{\"name\":" + "\"" + textBoxName.Text + "\"}}";
            
            try
            {
                var response = myWebClient.UploadString(address, json);
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
}
