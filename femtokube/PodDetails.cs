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
    public partial class PodDetails : Form
    {
        private String namespaceName;
        private String podName;
        List<Conditions> conditions = new List<Conditions>();
        List<Containers> containers = new List<Containers>();
        public PodDetails(String namespaceName, String podName)
        {
            InitializeComponent();
            this.namespaceName = namespaceName;
            this.podName = podName;
        }

        private void PodAdd_Load(object sender, EventArgs e)
        {
            labelPodName.Text = podName;
            loadDetails();
        }

        private void loadDetails()
        {
            String url = "http://192.168.50.128:8001/api/v1/namespaces/" + namespaceName + "/pods/" + podName;
            var myWebClient = new WebClient();
            var json = myWebClient.DownloadString(url);
            dynamic convertObj = JObject.Parse(json);

            //uid
            labeluid.Text = convertObj.metadata.uid;
            //created at
            labelCreatedAt.Text = convertObj.metadata.creationTimestamp;

            //conditions
            foreach (JObject item in convertObj.status.conditions)
            {
                conditions.Add(item.ToObject<Conditions>());
            }
            switch (conditions[0].status)
            {
                case "True":
                    pictureBoxInitialized.Image = Properties.Resources.check;
                    break;

                default:
                    pictureBoxInitialized.Image = Properties.Resources.wrong;
                    break;
            }

            switch (conditions[1].status)
            {
                case "True":
                    pictureBoxReady.Image = Properties.Resources.check;
                    break;

                default:
                    pictureBoxReady.Image = Properties.Resources.wrong;
                    break;
            }

            switch (conditions[2].status)
            {
                case "True":
                    pictureBoxContainers.Image = Properties.Resources.check;
                    break;

                default:
                    pictureBoxContainers.Image = Properties.Resources.wrong;
                    break;
            }

            switch (conditions[3].status)
            {
                case "True":
                    pictureBoxPod.Image = Properties.Resources.check;
                    break;

                default:
                    pictureBoxPod.Image = Properties.Resources.wrong;
                    break;
            }


            //ips
            labelHostIP.Text = convertObj.status.hostIP;
            labelPodIP.Text = convertObj.status.podIP;
            foreach (var ip in convertObj.status.podIPs)
            {
                listBoxIPs.Items.Add(ip.ip);
            }

            //containers
            foreach (JObject container in convertObj.spec.containers)
            {
                containers.Add(container.ToObject<Containers>());
            }
            foreach (var item in containers)
            {
                listBoxContainers.Items.Add(item.name);
            }
        }
    }
}

public class Containers
{
    public String name;
    public String image;
}