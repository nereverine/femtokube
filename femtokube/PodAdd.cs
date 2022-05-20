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
    
    public partial class PodAdd : Form
    {
        private String namespaceName;
        public PodAdd(String namespaceName)
        {
            InitializeComponent();
            this.namespaceName = namespaceName;
        }

       

        private void PodAdd_Load(object sender, EventArgs e)
        {

        }

        private void pictureBoxAdd_Click(object sender, EventArgs e)
        {
            String address = "http://192.168.50.128:8001/api/v1/namespaces/" + namespaceName + "/pods";
            var myWebClient = new WebClient();
            String json = "{\"kind\":\"Pod\",\"apiVersion\":\"v1\",\"metadata\":{\"name\":" + "\"" + textBoxName.Text + "\"},{\"spec\":{ \"containers\": {\"name\": \"nginx\", \"image\": \"docker.io/nginx:latest\" }} } }";

            //try
            //{
                var response = myWebClient.UploadString(address, json);
                dynamic convertObj = JObject.Parse(response);
                MessageBox.Show(convertObj.ToString());
            //}
            //catch (Exception)
            //{
              //  MessageBox.Show(Exception);
            //}
        }
    }
}
