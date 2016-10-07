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

namespace C4.ClientUsingDiscovery
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private AnnouncementService service;
        private ServiceHost host;

        private void Form1_Load(object sender, EventArgs e)
        {
            service = new AnnouncementService();
            service.OnlineAnnouncementReceived += service_OnlineAnnouncementReceived;

            service.OfflineAnnouncementReceived += service_OfflineAnnouncementReceived;

            host = new ServiceHost(service);
            host.AddServiceEndpoint(new UdpAnnouncementEndpoint());
            host.Open();
        }

        void service_OfflineAnnouncementReceived(object sender, AnnouncementEventArgs e)
        {
            listBox1.Items.Add("Bye from " + e.EndpointDiscoveryMetadata.Address);
        }

        void service_OnlineAnnouncementReceived(object sender, AnnouncementEventArgs e)
        {
            listBox1.Items.Add("Hello from " + e.EndpointDiscoveryMetadata.Address);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var client = new DiscoveryClient(new UdpDiscoveryEndpoint());

            var criteria = new FindCriteria(typeof(Firebrand.ICalculator));

            criteria.Duration = TimeSpan.FromSeconds(int.Parse(textBox1.Text));

            criteria.MaxResults = int.Parse(textBox2.Text);

            var response = client.Find(criteria);
            listBox1.Items.Clear();
            listBox1.Items.Add("Found " + response.Endpoints.Count + " endpoints");
            foreach (var item in response.Endpoints)
            {
                listBox1.Items.Add(item.Address);
            }
        }
    }
}
