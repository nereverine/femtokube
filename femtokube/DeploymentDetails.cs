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
    public partial class DeploymentDetails : Form
    {
        private String namespaceName;
        private String deploymentName;
        private List<Containers> containers = new List<Containers>();
        private List<Conditions> conditions = new List<Conditions>();
        private String address;
        public DeploymentDetails(String namespaceName, String deploymentName, String address)
        {
            InitializeComponent();
            this.namespaceName = namespaceName;
            this.deploymentName = deploymentName;
            this.address = address;
        }

        private void DeploymentDetails_Load(object sender, EventArgs e)
        {
            labelDeploymentName.Text = deploymentName;
            String url = address+"apis/apps/v1/namespaces/"+namespaceName+"/deployments/"+deploymentName;
            var myWebClient = new WebClient();
            var json = myWebClient.DownloadString(url);
            dynamic convertObj = JObject.Parse(json);
            
            //uid
            labeluid.Text = convertObj.metadata.uid;
            //created at
            labelCreatedAt.Text = convertObj.metadata.creationTimestamp;

            //containers
            foreach (JObject container in convertObj.spec.template.spec.containers)
            {
                containers.Add(container.ToObject<Containers>());
            }
            foreach (var item in containers)
            {
                listBoxContainers.Items.Add(item.name);
            }

            //conditions
            foreach (JObject item in convertObj.status.conditions)
            {
                conditions.Add(item.ToObject<Conditions>());
            }
            switch (conditions[0].status)
            {
                case "True":
                    pictureBoxProgressing.Image = Properties.Resources.check;
                    break;
                case "False":
                    pictureBoxProgressing.Image = Properties.Resources.wrong;
                    break;
            }
            switch (conditions[1].status)
            {
                case "True":
                    pictureBoxAvailable.Image = Properties.Resources.check;
                    break;
                case "False":
                    pictureBoxAvailable.Image = Properties.Resources.wrong;
                    break;
            }
        }

        private void pictureBoxProgressing_MouseMove(object sender, MouseEventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxProgressing, conditions[0].message);
        }

        private void pictureBoxAvailable_MouseMove(object sender, MouseEventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxProgressing, conditions[1].message);
        }
    }
}
