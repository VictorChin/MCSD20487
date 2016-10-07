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
using System.ServiceModel.Channels;
using Firebrand;

namespace C2.ClientUsingChannelFactory
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var address = new EndpointAddress("http://localhost:801/Sample/custom");
            var binding = new CustomBinding(
                new BinaryMessageEncodingBindingElement(),
                new HttpTransportBindingElement());

            var factory = new ChannelFactory<ICombined>(binding, address);
            var proxy = factory.CreateChannel();

            MessageBox.Show("3 + 4 = " + proxy.AddNumbers(3, 4));

            proxy.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var factory = new ChannelFactory<ICombined>("custom");

            var proxy = factory.CreateChannel();

            MessageBox.Show("3 + 4 = " + proxy.AddNumbers(3, 4));

            proxy.Close();
        }
    }

    interface ICombined : ISampleService, ICommunicationObject { }
}
