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
using Exercise06;

namespace Exercise06_WinHost
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private ServiceHost host;

        private void OpenButton_Click(object sender, EventArgs e)
        {
            host = new ServiceHost(typeof(Exercise));
            host.Open();
            HostStateLabel.Text = string.Format("{0} is {1}.", host.Description.Name, host.State);
            OpenButton.Enabled = false;
            CloseButton.Enabled = true;

            foreach (var ep in host.Description.Endpoints)
            {
                EndpointsListBox.Items.Add(string.Format("{0}: {1}", ep.Name, ep.Address));
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            host.Close();
            HostStateLabel.Text = string.Format("{0} is {1}.", host.Description.Name, host.State);
            OpenButton.Enabled = true;
            CloseButton.Enabled = false;
            EndpointsListBox.Items.Clear();
        }

        private void EndpointsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var ep = host.Description.Endpoints[EndpointsListBox.SelectedIndex];
            AddressTextBox.Text = ep.Address.ToString();
            BindingTextBox.Text = ep.Binding.ToString();
            ContractTextBox.Text = ep.Contract.ContractType.ToString();
        }
    }
}
