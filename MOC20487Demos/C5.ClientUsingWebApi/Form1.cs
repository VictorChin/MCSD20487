using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;

namespace C5.ClientUsingWebApi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void GetProductsButton_Click(object sender, EventArgs e)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:830/");
            var response = await client.GetAsync("api/product");
            var products = await response.Content.ReadAsAsync<List<Product>>();
            foreach (var item in products)
            {
                listBox1.Items.Add(item.ProductName + " costs " 
                    + item.UnitPrice.Value.ToString("c"));
            }
        }
    }
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public decimal? UnitPrice { get; set; }
    }
}
