using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.Entity.Infrastructure;
using System.Data.Objects;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        NorthwindEntities db = new NorthwindEntities();

        private void GetCustomersInCityButton_Click(object sender, EventArgs e)
        {
            var query = db.Customers.Where(c => c.City == CityTextBox.Text)
                .Select(c => new { c.CompanyName, c.City });
            TSQL.Text = query.ToString();
            listBox1.Items.Clear();
            foreach (var customer in query)
            {
                listBox1.Items.Add(customer.CompanyName + " in " + customer.City);
            }
        }

        private void GetProductsThatCostLessThanButton_Click(object sender, EventArgs e)
        {
            var price = decimal.Parse(UnitPriceTextBox.Text);
            var query = db.Products.Where(p => p.UnitPrice.Value < price)
                .Select(p => new { p.ProductName, p.UnitPrice });
            TSQL.Text = query.ToString();
            listBox1.Items.Clear();
            foreach (var product in query)
            {
                listBox1.Items.Add(product.ProductName 
                    + " costs " + product.UnitPrice.Value.ToString("c"));
            }
        }

        private void GetCustomersInCityUsingESQLButton_Click(object sender, EventArgs e)
        {
            var esql = "SELECT VALUE c " + 
                "FROM NorthwindEntities.Customers AS c WHERE c.City == @City";
            var oc = (db as IObjectContextAdapter).ObjectContext;
            var query = oc.CreateQuery<Customer>(esql,
                new ObjectParameter("City", CityTextBox.Text));
            TSQL.Text = query.ToTraceString();
            listBox1.Items.Clear();
            foreach (var customer in query)
            {
                listBox1.Items.Add(customer.CompanyName + " in " + customer.City);
            }
        }

        private void GetCustomersInCityUsingTSQLButton_Click(object sender, EventArgs e)
        {
            var tsql = "SELECT * FROM Customers WHERE City = @City";
            
            var query = db.Database.SqlQuery<Customer>(tsql,
                new SqlParameter("@City", CityTextBox.Text));

            TSQL.Text = query.ToString();
            listBox1.Items.Clear();
            foreach (var customer in query)
            {
                listBox1.Items.Add(customer.CompanyName + " in " + customer.City);
            }
        }

        private void EditorButton_Click(object sender, EventArgs e)
        {
            var form = new EditorForm();
            form.Show();
        }

        private void LoadingButton_Click(object sender, EventArgs e)
        {
            var loading = new LoadingDemos();
            loading.Show();
        }
    }
}
