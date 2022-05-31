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
        private String address;
        public NamespaceDetails(String namespaceName, String address)
        {
            InitializeComponent();
            this.namespaceName = namespaceName;
            this.address = address;
        }

        private void NamespaceDetails_Load(object sender, EventArgs e)
        {
            labelNamespaceName.Text = namespaceName;
            String url = address + "api/v1/namespaces/" + namespaceName;
            var myWebClient = new WebClient();
            var json = myWebClient.DownloadString(url);
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
