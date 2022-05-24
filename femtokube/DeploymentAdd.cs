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
    public partial class DeploymentAdd : Form
    {
        private String namespaceName;
        public DeploymentAdd(String namespaceName)
        {
            InitializeComponent();
            this.namespaceName = namespaceName;
        }

        private void DeploymentAdd_Load(object sender, EventArgs e)
        {
            labelNamespace.Text = namespaceName;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if(textBoxName.Text == "")
            {
                MessageBox.Show("Deployment needs a name");
            }else if(textBoxContainerName.Text == "")
            {
                MessageBox.Show("Containers need a name");
            }
            else if (listBoxImages.SelectedItem == null)
            {
                MessageBox.Show("Select an image");
            }
            else
            {
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

                String json = "{\"apiVersion\":\"apps/v1\",\"kind\":\"Deployment\",\"metadata\":{\"name\":\""+ textBoxName.Text +"\",\"labels\":{\"app\":\"" + textBoxContainerName.Text + "\"}},\"spec\":{\"replicas\":"+ numericUpDown1.Value +",\"selector\":{\"matchLabels\":{\"app\":\"" + textBoxContainerName.Text + "\"}},\"template\":{\"metadata\":{\"labels\":{\"app\":\"" + textBoxContainerName.Text +"\"}},\"spec\":{\"containers\":[{\"name\":\"" + textBoxContainerName.Text + "\",\"image\":\"" + imageName + "\",\"ports\":[{\"containerPort\":" + numericUpDownPort.Value+ "}]}]}}}}";
                String address = "http://192.168.50.128:8001/apis/apps/v1/namespaces/" + namespaceName + "/deployments/";
                var myWebClient = new WebClient();

                try
                {
                    var response = myWebClient.UploadString(address, json);
                    dynamic convertObj = JObject.Parse(response);
                    MessageBox.Show("Deployment: " + textBoxName.Text + " created successfully");
                    this.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Deployment wasnt created successfully");
                    this.Close();
                }
            }
        }
    }
}
