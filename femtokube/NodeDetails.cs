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
            List<Conditions> conditions = new List<Conditions>();
            foreach (JObject item in convertObj.status.conditions)
            {
                conditions.Add(item.ToObject<Conditions>());
            }
            switch (conditions[0].status)
            {
                case "False":
                    pictureBoxNetworkStatus.Image = Properties.Resources.check;
                    break;
            }

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