using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using C1.ClientUsingWsdl.CalcServiceReference;
using System.ServiceModel;
using Firebrand;
using System.Net;

namespace C1.ClientUsingWsdl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        async private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var proxy = new CalculatorClient("intranet");

                //proxy.ClientCredentials.UserName.UserName = "Alice";
                //proxy.ClientCredentials.UserName.Password = "secret";

                //proxy.ClientCredentials.ClientCertificate.SetCertificate()

                //proxy.ClientCredentials.Windows.ClientCredential = new System.Net.NetworkCredential("Bob", "screct");

                //proxy.ClientCredentials.Windows.ClientCredential = 
                //    CredentialCache.DefaultNetworkCredentials;

                label1.Text = "Answer is " + await proxy.AddAsync(
                    double.Parse(textBox1.Text), double.Parse(textBox2.Text));
            }
            catch (FaultException<AddFault> ex)
            {
                MessageBox.Show(ex.Detail.Description + ex.Detail.BankAccountNumber,
                    "Add Fault");
            }
            catch (FaultException<ExceptionDetail> ex)
            {
                MessageBox.Show(ex.Detail.Message + ex.Detail.StackTrace,
                    "Server Stack Trace");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace, 
                    "Client Stack Trace");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var proxy = new CalculatorClient("intranet");
            label1.Text = "Answer is " + proxy.Multiply( 
                new Firebrand.Numbers {
                    A = double.Parse(textBox1.Text), 
                    B = double.Parse(textBox2.Text) 
                });
        }
    }
}
