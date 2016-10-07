using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceModel;
using System.ServiceModel.Discovery;
using Firebrand;

namespace C4.ClientUsingDiscovery
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        AnnouncementService ann = new AnnouncementService();
        ServiceHost host;

        private void Form1_Load(object sender, EventArgs e)
        {
            host = new ServiceHost(ann);
            host.AddServiceEndpoint(new UdpAnnouncementEndpoint());
            ann.OnlineAnnouncementReceived += ann_OnlineAnnouncementReceived;
            ann.OfflineAnnouncementReceived += ann_OfflineAnnouncementReceived;
            host.Open(); // start listening
        }

        void ann_OfflineAnnouncementReceived(object sender, AnnouncementEventArgs e)
        {
            listBox1.Items.Add("Bye from " + e.EndpointDiscoveryMetadata.Address);
        }

        void ann_OnlineAnnouncementReceived(object sender, AnnouncementEventArgs e)
        {
            listBox1.Items.Add("Hello from " + e.EndpointDiscoveryMetadata.Address);
        }

        private void DiscoverButton_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Refresh();
            var client = new DiscoveryClient(new UdpDiscoveryEndpoint());
            var seconds = int.Parse(SecondsTextBox.Text);
            var endpoints = int.Parse(EndpointsTextBox.Text);
            var request = new FindCriteria(typeof(ISampleService));
            request.Duration = TimeSpan.FromSeconds(seconds);
            request.MaxResults = endpoints;
            var response = client.Find(request);
            listBox1.Items.Add(response.Endpoints.Count + " endpoints found.");
            foreach (var ep in response.Endpoints)
            {
                listBox1.Items.Add("  " + ep.Address);
            }
        }
    }
}
