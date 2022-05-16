using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace femtokube
{
    public partial class NodeDetails : Form
    {
        private String nodeName;
        List<Conditions> conditions = new List<Conditions>();
        List<Addresses> addresses = new List<Addresses>();
        List<Images> images = new List<Images>();
        public NodeDetails(String nodeName)
        {
            this.nodeName = nodeName;
            InitializeComponent();
        }

        private void NodeDetails_Load(object sender, EventArgs e)
        {
            labelNodeName.Text = nodeName;
            String address = "http://192.168.50.128:8001/api/v1/nodes/" + nodeName;
            var myWebClient = new WebClient();
            var json = myWebClient.DownloadString(address);
            dynamic convertObj = JObject.Parse(json);
            //uid
            labeluid.Text = convertObj.metadata.uid;
            
            //creation time
            String creationTime = convertObj.metadata.creationTimestamp.ToString().Split('T')[0];
            labelCreatedAt.Text = creationTime;

            //memories
            labelCPU.Text = convertObj.status.capacity.cpu;
            ArrayList capacity = new ArrayList();
            foreach (var item in convertObj.status.capacity)
            {
                capacity.Add(item);
            }
            String ephemeral = capacity[1].ToString().Split(':')[1];
            ephemeral = Regex.Match(ephemeral, @"\d+").Value;
            int ephemeralNr;
            ephemeralNr = Int32.Parse(ephemeral) / 977;
            labelStorage.Text = ephemeralNr.ToString() + "MB";
            String memory = Regex.Match(convertObj.status.capacity.memory.ToString(), @"\d+").Value;
            int memoryNr = Int32.Parse(memory) / 977;
            labelMemory.Text = memoryNr.ToString() + "MB";

            //pods
            labelPods.Text = convertObj.status.capacity.pods.ToString();

            //conditions
            
            foreach (JObject item in convertObj.status.conditions)
            {
                conditions.Add(item.ToObject<Conditions>());
            }
            switch (conditions[0].status)
            {
                case "False":
                    pictureBoxNetworkStatus.Image = Properties.Resources.check;
                    break;

                default:
                    pictureBoxNetworkStatus.Image = Properties.Resources.wrong;
                    break;
            }
            labelNetworkStatus.Text = conditions[0].message;

            switch (conditions[1].status)
            {
                case "False":
                    pictureBoxMemoryStatus.Image = Properties.Resources.check;
                    break;

                default:
                    pictureBoxMemoryStatus.Image = Properties.Resources.wrong;
                    break;
            }
            labelMemoryStatus.Text = conditions[1].message;

            switch (conditions[2].status)
            {
                case "False":
                    pictureBoxDiskStatus.Image = Properties.Resources.check;
                    break;

                default:
                    pictureBoxDiskStatus.Image = Properties.Resources.wrong;
                    break;
            }
            labelDiskStatus.Text = conditions[2].message;

            switch (conditions[3].status)
            {
                case "False":
                    pictureBoxPIDStatus.Image = Properties.Resources.check;
                    break;

                default:
                    pictureBoxPIDStatus.Image = Properties.Resources.wrong;
                    break;
            }
            labelPIDStatus.Text = conditions[3].message;

            switch (conditions[4].status)
            {
                case "True":
                    pictureBoxReadyStatus.Image = Properties.Resources.check;
                    break;

                default:
                    pictureBoxReadyStatus.Image = Properties.Resources.wrong;
                    break;
            }

            labelReadyStatus.Text = conditions[4].message;

            //addresses
            foreach (JObject item in convertObj.status.addresses)
            {
                addresses.Add(item.ToObject<Addresses>());
            }
            foreach (var item in addresses)
            {
                if (item.type == "Hostname")
                {
                    labelHostname.Text = item.address;
                }
                if (item.type == "InternalIP")
                {
                    labelAddress.Text = item.address;
                }
            }

            labelKernelVersion.Text = convertObj.status.nodeInfo.kernelVersion;
            labelOS.Text = convertObj.status.nodeInfo.operatingSystem;
            labelOSImage.Text = convertObj.status.nodeInfo.osImage;
            labelArch.Text = convertObj.status.nodeInfo.architecture;

            //images
            foreach (var item in convertObj.status.images)
            {
                images.Add(item.ToObject<Images>());
            }
            foreach (var image in images)
            {
                listBoxImages.Items.Add(image.names[1] +"  Tamanho: " + image.sizeBytes * 0.000001+"MB");
            }
        }

        private void pictureBoxNetworkStatus_MouseMove(object sender, MouseEventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxNetworkStatus, conditions[0].message);
        }

        private void pictureBoxMemoryStatus_MouseMove(object sender, MouseEventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxMemoryStatus, conditions[1].message);
        }

        private void pictureBoxDiskStatus_MouseMove(object sender, MouseEventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxDiskStatus, conditions[2].message);
        }

        private void pictureBoxPIDStatus_MouseMove(object sender, MouseEventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxPIDStatus, conditions[3].message);
        }

        private void pictureBox5_MouseMove(object sender, MouseEventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxReadyStatus, conditions[4].message);
        }

        private void listBoxImages_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(listBoxImages.SelectedItem.ToString());
        }
    }
}


public class Conditions
{
    public String type;
    public String status;
    public String lastHeartbeatTime;
    public String lastTransitionTime;
    public String reason;
    public String message;
}
public class Addresses
{
    public String type;
    public String address;
}
public class Images
{
    public String[] names;
    public int sizeBytes;
}