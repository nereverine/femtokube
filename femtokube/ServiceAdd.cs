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
    public partial class ServiceAdd : Form
    {
        private String namespaceName;
        private String address;
        public ServiceAdd(String namespaceName, String address)
        {
            InitializeComponent();
            this.namespaceName = namespaceName;
            this.address = address;
        }

        private void ServiceAdd_Load(object sender, EventArgs e)
        {
            labelNamespace.Text = namespaceName;
        }

        private void pictureBoxAdd_Click(object sender, EventArgs e)
        {
            if(textBoxName.Text == "")
            {
                MessageBox.Show("Service name required");
            }
            else if (textBoxLabel.Text == "")
            {
                MessageBox.Show("Label required");
            }
            else if(comboBoxProtocol.SelectedItem == null)
            {
                MessageBox.Show("Protocol required");
            }
            else
            {
                String json = "{\"apiVersion\":\"v1\",\"kind\":\"Service\",\"metadata\":{\"name\":\""+ textBoxName.Text + "\"},\"spec\":{\"selector\":{\"app\":\""+ textBoxLabel.Text+ "\"},\"ports\":[{\"protocol\":\""+ comboBoxProtocol.Text +"\",\"port\":"+ numericUpDownPort.Value +",\"targetPort\":"+ numericUpDownTarPort.Value + "}]}}";
                String url = address+"api/v1/namespaces/" + namespaceName + "/services";
                var myWebClient = new WebClient();

                try
                {
                    var response = myWebClient.UploadString(url, json);
                    dynamic convertObj = JObject.Parse(response);
                    MessageBox.Show("Service: " + textBoxName.Text + " created successfully");
                    this.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Service wasnt created successfully");
                    this.Close();
                }
            }
        }
    }
}
