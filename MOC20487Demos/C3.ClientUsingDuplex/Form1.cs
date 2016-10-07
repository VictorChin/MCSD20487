using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using C3.ClientUsingDuplex.CalcDuplexServiceReference;
using System.ServiceModel;

namespace C3.ClientUsingDuplex
{
    public partial class Form1 : Form, ICalcDuplexCallback
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void DivideButton_Click(object sender, EventArgs e)
        {
            var proxy = new CalcDuplexClient(new InstanceContext(this));
            var a = double.Parse(ATextBox.Text);
            var b = double.Parse(BTextBox.Text);
            await proxy.DivideNumbersAsync(a, b);
        }

        public void SendAnswer(double answer)
        {
            AnswerLabel.Text = "Answer: " + answer;
        }
    }
}
