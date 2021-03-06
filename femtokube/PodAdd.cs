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
        private String address;
        public PodAdd(String namespaceName, String address)
        {
            InitializeComponent();
            this.namespaceName = namespaceName;
            this.address = address;
        }

       

        private void PodAdd_Load(object sender, EventArgs e)
        {

        }

        private void pictureBoxAdd_Click(object sender, EventArgs e)
        {
            if (listBoxImages.SelectedItem == null)
            {
                MessageBox.Show("Select an image for the container first");
                return;
            }
            else if(textBoxName.Text == "")
            {
                MessageBox.Show("Name required");
            }
            else
            {



                String url = address+"api/v1/namespaces/" + namespaceName + "/pods";
                var myWebClient = new WebClient();
                String imageName = "";              
                switch (listBoxImages.SelectedIndex)
                {
                    case 0:
                            imageName = "docker.io/ubuntu:latest";
                        break;
                    case 1:
                        imageName = "docker.io/redis:latest";
                        break;

                    case 2:
                        imageName = "docker.io/alpine:latest";
                        break;
                    case 3:
                        imageName = "docker.io/node:latest";
                        break;
                    case 4:
                        imageName = "docker.io/mysql:latest";
                        break;
                    case 5:
                        imageName = "docker.io/python:latest";
                        break;
                    case 6:
                        imageName = "docker.io/nginx:latest";
                        break;
                }


                String json = "{\"kind\":\"Pod\",\"apiVersion\":\"v1\",\"metadata\":{\"name\":"  + "\"" + textBoxName.Text + "\"},\"spec\":{\"containers\":[{\"name\":" + "\""+ textBoxName.Text+ "\"" +",\"image\":" + "\"" + imageName + "\"}]}}";

                try
                {
                    var response = myWebClient.UploadString(url, json);
                dynamic convertObj = JObject.Parse(response);
                MessageBox.Show("Pod: "+textBoxName.Text + " created successfully");
                    this.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Pod wasnt created successfully");
                    this.Close();
                }
            }
        }
    }
}
