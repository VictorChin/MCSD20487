using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFDemo
{
    public partial class EditorForm : Form
    {
        public EditorForm()
        {
            InitializeComponent();
        }

        NorthwindEntities db = new NorthwindEntities();

        private void AddCustomerButton_Click(object sender, EventArgs e)
        {
            var newCustomer = new Customer();
            newCustomer.CustomerID = CustomerIDTextBox.Text;
            newCustomer.CompanyName = CompanyNameTextBox.Text;
            newCustomer.City = CityTextBox.Text;
            db.Customers.Add(newCustomer); // marks it as Added
            int affected = db.SaveChanges(); // inserts into database
            MessageBox.Show(affected + " row(s) affected.");
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            var customerToUpdate = db.Customers.Find(CustomerIDTextBox.Text);
            customerToUpdate.CompanyName = CompanyNameTextBox.Text;
            customerToUpdate.City = CityTextBox.Text; // tracks changes
            int affected = db.SaveChanges(); // updates in database
            MessageBox.Show(affected + " row(s) affected.");
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            var customerToDelete = db.Customers.Find(CustomerIDTextBox.Text);
            db.Customers.Remove(customerToDelete); // marks for deletion
            int affected = db.SaveChanges(); // deletes in database
            MessageBox.Show(affected + " row(s) affected.");
        }
    }
}
