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
        public ServiceDetails(String namespaceName, String serviceName)
        {
            InitializeComponent();
            this.namespaceName = namespaceName;
            this.serviceName = serviceName;
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
            String url = "http://192.168.50.128:8001/api/v1/namespaces/" + namespaceName + "/services/" + serviceName;
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
                labelPortName.Text = item.name;
                labelProtocol.Text = item.protocol;
                labelPort.Text = item.port;
                labelTargetedPort.Text = item.targetPort;
            }
            

        }
    }
}
