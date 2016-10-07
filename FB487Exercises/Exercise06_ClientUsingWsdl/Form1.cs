using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Exercise06_ClientUsingWsdl.ExerciseServiceReference;

namespace Exercise06_ClientUsingWsdl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AddToListButton_Click(object sender, EventArgs e)
        {
            NamesListBox.Items.Add(NameTextBox.Text);
            NameTextBox.Text = "";
            NameTextBox.Focus();
        }

        private ExerciseClient proxy = new ExerciseClient("Local");

        async private void TotalCharsButton_Click(object sender, EventArgs e)
        {
            string[] names = NamesListBox.Items.Cast<string>().ToArray();
            int chars = await proxy.GetTotalNumberOfCharsAsync(names);
            CharsLabel.Text = string.Format("There are {0} total characters in the list of names.", chars);
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (NamesListBox.SelectedIndex < 0)
            {
                MessageBox.Show("You must select a name in the list.", "Remove");
            }
            else
            {
                NamesListBox.Items.RemoveAt(NamesListBox.SelectedIndex);
            }
        }

        async private void FactorialButton_Click(object sender, EventArgs e)
        {
            int number = int.Parse(NumberTextBox.Text);
            int factorial = await proxy.FactorialAsync(number);
            FactorialLabel.Text = string.Format("The factorial of {0} is {1}.", number, factorial);
        }

        async private void HowManyDaysOldButton_Click(object sender, EventArgs e)
        {
            var person = new Person
            {
                FirstName = PersonNameTextBox.Text,
                DateOfBirth = DOB.Value
            };
            DaysOldLabel.Text = await proxy.HowManyDaysOldAsync(person);
        }
    }
}
