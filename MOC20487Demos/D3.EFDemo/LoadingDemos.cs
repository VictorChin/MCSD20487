using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFDemo
{
    public partial class LoadingDemos : Form
    {
        public LoadingDemos()
        {
            InitializeComponent();
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            var db = new NorthwindEntities();
            db.Configuration.LazyLoadingEnabled = LazyLoadingEnabledCheckBox.Checked;
            
            IQueryable<Category> query;
            if (EagerLoadingEnabledCheckBox.Checked)
            {
                query = db.Categories.Include(c => c.Products);
            }
            else
            {
                query = db.Categories;
            }
            TSQL.Text = query.ToString();

            listBox1.Items.Clear();
            foreach (var category in query)
            {
                var isloaded = db.Entry(category).Collection(c => c.Products).IsLoaded;
                if ((!isloaded) && (ExplicitLoadingEnabledCheckBox.Checked))
                {
                    db.Entry(category).Collection(c => c.Products).Load();
                }
                listBox1.Items.Add(category.CategoryName + " has " + category.Products.Count + " products (IsLoaded? " + isloaded + ")");

                foreach (var product in category.Products)
                {
                    listBox1.Items.Add("   " + product.ProductName);
                }
            }
        }

        private void EagerLoadingEnabledCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
