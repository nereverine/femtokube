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
    public partial class NamespaceDetails : Form
    {
        private String namespaceName;
        public NamespaceDetails(String namespaceName)
        {
            InitializeComponent();
            this.namespaceName = namespaceName;
        }

        private void NamespaceDetails_Load(object sender, EventArgs e)
        {
            labelNamespaceName.Text = namespaceName;
            String address = "http://192.168.50.128:8001/api/v1/namespaces/" + namespaceName;
            var myWebClient = new WebClient();
            var json = myWebClient.DownloadString(address);
            dynamic convertObj = JObject.Parse(json);

            labeluuid.Text = convertObj.metadata.uid;
            labelCreatedAt.Text = convertObj.metadata.creationTimestamp;

            String status = convertObj.status.phase;
            if(status == "Active")
            {
                pictureBox1.Image = Properties.Resources.check;
            }
            else
            {
                pictureBox1.Image = Properties.Resources.wrong;
            }
            labelStatus.Text = status;
        }
    }
}
