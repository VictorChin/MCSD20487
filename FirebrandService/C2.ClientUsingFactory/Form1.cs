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
using Firebrand;

namespace C2.ClientUsingFactory
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //var address = new EndpointAddress(
            //    "net.tcp://localhost:802/Calc/");

            //var binding = new NetTcpBinding();

            //var factory = new ChannelFactory<ICalculator>(
            //    binding, address);

            var factory = new ChannelFactory<ICombo>("intranet");

            ICombo proxy = factory.CreateChannel();

            label1.Text = "Answer is " + proxy.Add(
                double.Parse(textBox1.Text), double.Parse(textBox2.Text));

            proxy.Close();
        }
    }
    interface ICombo : ICalculator, ICommunicationObject { }
}
