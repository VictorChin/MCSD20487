using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using C6.ClientUsingWcfDataServices.NorthwindServiceReference;
using System.Data.Services.Client;
using Microsoft.Data.OData;

namespace C6.ClientUsingWcfDataServices
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        NorthwindEntities db = new NorthwindEntities(
            new Uri("http://localhost:840/Northwind.svc/"));

        void db_SendingRequest2(object sender, SendingRequest2EventArgs e)
        {
            e.RequestMessage.SetHeader("myhead", "isbig");
            SendingRequestEvents.Items.Add(string.Format("{0} {1}", e.RequestMessage.Method, e.RequestMessage.Url));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            db.SendingRequest2 += db_SendingRequest2;
        }

        private void GetExpensiveProductsButton_Click(object sender, EventArgs e)
        {
            Cursor lastCursor = this.Cursor;
            this.Cursor = Cursors.WaitCursor;

            // this is LINQ to OData
            var query = db.Products
                .Where(p => p.UnitPrice.Value > decimal.Parse(textBox1.Text))
                .OrderByDescending(p => p.UnitPrice.Value);

            listBox1.Items.Clear();
            foreach (var item in query)
            {
                listBox1.Items.Add(item.ProductName + " costs " +
                    item.UnitPrice.Value.ToString("c"));
            }
            this.Cursor = lastCursor;
        }

        private void AddProductButton_Click(object sender, EventArgs e)
        {
            Cursor lastCursor = this.Cursor;
            this.Cursor = Cursors.WaitCursor;

            var p = new Product();
            p.ProductName = ProductNameTextBox.Text;
            p.CategoryID = 1;
            p.SupplierID = 1;
            p.UnitPrice = 90M;
            db.AddObject("Products", p);

            db.UsePostTunneling = true;

            var response = db.SaveChanges();

            foreach (var item in response)
            {
                if (item.Error == null)
                {
                    MessageBox.Show(p.ProductName + " added successfully.", "Status code: " + item.StatusCode);
                }
                else
                {
                    MessageBox.Show("Error: " + item.Error.Message, "Status code: " + item.StatusCode);
                }
            }
            this.Cursor = lastCursor;
        }

        private void LoadingCategoriesButton_Click(object sender, EventArgs e)
        {
            Cursor lastCursor = this.Cursor;
            this.Cursor = Cursors.WaitCursor;

            listBox1.Items.Clear();

            IQueryable<Category> query;

            if (EagerlyLoadCheckBox.Checked)
            {
                query = db.Categories.Expand("Products");
            }
            else
            {
                query = db.Categories;
            }

            foreach (var item in query)
            {
                listBox1.Items.Add(item.CategoryName);

                if (ExplicitlyLoadCheckBox.Checked)
                {
                    db.LoadProperty(item, "Products"); 
                }

                foreach (var p in item.Products)
                {
                    listBox1.Items.Add("  " + p.ProductName);
                }
            }
            this.Cursor = lastCursor;
        }

        private void ClearEventsButton_Click(object sender, EventArgs e)
        {
            SendingRequestEvents.Items.Clear();
            ODataUriTextBox.Text = "";
        }

        private void SendingRequestEvents_SelectedIndexChanged(object sender, EventArgs e)
        {
            ODataUriTextBox.Text = SendingRequestEvents.SelectedItem.ToString();
        }

        private void ClearObjectsButton_Click(object sender, EventArgs e)
        {
            db = new NorthwindEntities(
                new Uri("http://localhost:840/Northwind.svc/")); ;
        }
    }
}
