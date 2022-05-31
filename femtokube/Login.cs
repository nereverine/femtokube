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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String address = "http://" + textBoxIP.Text + ":" + numericUpDownPort.Value + "/";
            try
            {
                var myWebClient = new WebClient();
                var json = myWebClient.DownloadString(address);
                this.Hide();
                var dashboard = new Dashboard(address);
                dashboard.Closed += (s, args) => this.Close();
                dashboard.Show();
            }
            catch (Exception)
            {

                MessageBox.Show("Couldnt connect to cluster");
                return;
            }
            
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
