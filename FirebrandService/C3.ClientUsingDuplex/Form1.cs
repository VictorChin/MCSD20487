using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using C3.ClientUsingDuplex.DuplexServiceReference;
using System.ServiceModel;

namespace C3.ClientUsingDuplex
{
    public partial class Form1 : Form, ICalcDuplexCallback
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var proxy = new CalcDuplexClient(new InstanceContext(this));

            await proxy.DivideAsync(new Numbers { A = 12, B = 3 });
        }

        public void SendAnswer(double answer)
        {
            label1.Text = "Answer is " + answer;
        }
    }
}
