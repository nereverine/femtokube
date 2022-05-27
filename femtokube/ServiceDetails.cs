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
    public partial class ServiceDetails : Form
    {
        private String namespaceName;
        private String serviceName;
        private String address;
        public ServiceDetails(String namespaceName, String serviceName, String address)
        {
            InitializeComponent();
            this.namespaceName = namespaceName;
            this.serviceName = serviceName;
            this.address = address;
        }

        private void ServiceDetails_Load(object sender, EventArgs e)
        {
            loadDetails();
        }

        private void loadDetails()
        {
            //namespace
            labelNamespace.Text = namespaceName;
            //service
            labelServiceName.Text = serviceName;
            //created at
            String url = address + "api/v1/namespaces/" + namespaceName + "/services/" + serviceName;
            var myWebClient = new WebClient();
            var json = myWebClient.DownloadString(url);
            dynamic convertObj = JObject.Parse(json);
            labelCreatedAt.Text = convertObj.metadata.creationTimestamp;
            labeluid.Text = convertObj.metadata.uid;

            //clusterip
            labelClusterIp.Text = convertObj.spec.clusterIP;

            //ports
            foreach (var item in convertObj.spec.ports)
            {
                if (item.name == null)
                {
                    labelPortName.Text = "No name";
                }
                else
                {
                    labelPortName.Text = item.name;
                }
                labelProtocol.Text = item.protocol;
                labelPort.Text = item.port;
                labelTargetedPort.Text = item.targetPort;
            }
            

        }
    }
}
