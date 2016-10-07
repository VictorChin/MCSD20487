using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using C1.ClientUsingServiceReference.SampleServiceReference;
using System.ServiceModel;
using System.ServiceModel.Configuration;
using System.Configuration;
using Firebrand; // add reference to System.Configuration assembly

namespace C1.ClientUsingServiceReference
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SampleServiceClient proxy;

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                var a = double.Parse(ATextBox.Text);
                var b = double.Parse(BTextBox.Text);
                AnswerLabel.Text = "Answer: " + proxy.AddNumbers(a, b);
            }
            catch (FaultException<AddNumbersFault> anf)
            {
                MessageBox.Show("Colour: " + anf.Detail.FavouriteColour +
                    ", Number: " + anf.Detail.FavouriteNumbers.A +
                    ", Reason: " + anf.Message,
                    "Custom Fault Detail");
            }
            catch (FaultException<ExceptionDetail> fed)
            {
                MessageBox.Show(fed.Detail.Message +
                    fed.Detail.StackTrace, "Server Exception");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message +
                    ex.StackTrace, "Client Exception");
            }
            finally
            {
                if (proxy.State == CommunicationState.Faulted)
                {
                    proxy.Abort();
                    StateLabel.Text = "State: " + proxy.State.ToString();
                }
            }
        }

        private async void MultiplyButton_Click(object sender, EventArgs e)
        {
            try
            {
                var a = double.Parse(ATextBox.Text);
                var b = double.Parse(BTextBox.Text);
                AnswerLabel.Text = "Answer: " + await proxy.MultiplyAsync(
                    new Numbers { A = a, B = b });
            }
            catch (FaultException<ExceptionDetail> fed)
            {
                MessageBox.Show(fed.Detail.Message +
                    fed.Detail.StackTrace, "Server Exception");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message +
                    ex.StackTrace, "Client Exception");
            }
            finally
            {
                if (proxy.State == CommunicationState.Faulted)
                {
                    proxy.Abort();
                    StateLabel.Text = "State: " + proxy.State.ToString();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ClientSection client = (ClientSection)
                ConfigurationManager.GetSection(
                "system.serviceModel/client");

            EndpointsComboBox.Items.Clear();

            foreach (ChannelEndpointElement item in client.Endpoints)
            {
                EndpointsComboBox.Items.Add(item.Name);
            }

            if (EndpointsComboBox.Items.Count > 0)
                EndpointsComboBox.SelectedIndex = 0;
        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            Cursor lastCursor = this.Cursor;

            try
            {
                this.Cursor = Cursors.WaitCursor;

                proxy = new SampleServiceClient(EndpointsComboBox.Text);

                //proxy.ClientCredentials.UserName.UserName = "Bob";
                //proxy.ClientCredentials.UserName.Password = "123456";

                //proxy.ClientCredentials.Windows.ClientCredential 
                //    = CredentialCache.DefaultNetworkCredentials;

                //proxy.ClientCredentials.Windows.ClientCredential
                //    = new NetworkCredential("Mary", "123456");

                //proxy.ClientCredentials.ClientCertificate.SetCertificate(

                proxy.Open();

                StateLabel.Text = "State: " + proxy.State.ToString();
            }
            catch (FaultException<ExceptionDetail> fed)
            {
                MessageBox.Show(fed.Detail.Message +
                    fed.Detail.StackTrace, "Server Exception");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Open");
            }
            finally
            {
                if (proxy.State == CommunicationState.Faulted)
                {
                    proxy.Abort();
                    StateLabel.Text = "State: " + proxy.State.ToString();
                }
                this.Cursor = lastCursor;
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Cursor lastCursor = this.Cursor;
            this.Cursor = Cursors.WaitCursor;

            proxy.Close();
            StateLabel.Text = "State: " + proxy.State.ToString();

            this.Cursor = lastCursor;
        }

        private void EndpointsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClientSection client = (ClientSection)
                ConfigurationManager.GetSection(
                "system.serviceModel/client");

            EndpointTextBox.Text = client.Endpoints[EndpointsComboBox.SelectedIndex].Address.ToString();
        }

        private async void SayHelloButton_Click(object sender, EventArgs e)
        {
            try
            {
                SayHelloTextBox.Text = await proxy.SayHelloAsync();
            }
            catch (FaultException<ExceptionDetail> fed)
            {
                MessageBox.Show(fed.Detail.Message +
                    fed.Detail.StackTrace, "Server Exception");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Open");
            }
            finally
            {
                if (proxy.State == CommunicationState.Faulted)
                {
                    proxy.Abort();
                    StateLabel.Text = "State: " + proxy.State.ToString();
                }
            }
        }
    }
}
