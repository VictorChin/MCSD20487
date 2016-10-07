using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace LinqDemos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void varButton_Click(object sender, EventArgs e)
        {
            var person = new { Name = "Bob", Age = 42 };
            MessageBox.Show(person.Name + " is " + person.Age);

            // gives a compile error because anonymous types are immutable
            // person.Age = 22; 
        }

        private void GenericsButton_Click(object sender, EventArgs e)
        {
            MyGeneric<int> g = new MyGeneric<int>();
            g.Data = 123;
            g.ProcessData();
        }

        private int Calc1(int a, int b)
        {
            return a + b;
        }
        private int Calc2(int a, int b)
        {
            return a * b;
        }
        private void DelegateButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Call method directly: " + Calc1(2, 3));

            // the LAST type is always the RETURN type
            // the other are any INPUT types
            Func<int, int, int> d = new Func<int, int, int>(Calc1);
            MessageBox.Show("Call method using delegate: " + d(4, 5));

            d = new Func<int, int, int>(Calc2);
            MessageBox.Show("Call another method using delegate: " + d(4, 5));

            d = new Func<int, int, int>((a, b) => a * b);
            MessageBox.Show("Call another method using delegate: " + d(4, 5));

            d = Calc2;
            MessageBox.Show("Call another method using delegate: " + d(4, 5));

            d = (a, b) => a * b;
            MessageBox.Show("Call another method using delegate: " + d(4, 5));
        }

        private void LinqExtensionMethodsButton_Click(object sender, EventArgs e)
        {
            var names = new string[] { "George", "Emily", "Max", "Bob", "Sally" };

            var query = names.Where(x => x.Length > 4);

            listBox1.Items.Clear();
            listBox1.Items.AddRange(query.ToArray());
        }
        private void LinqToEntitiesButton_Click(object sender, EventArgs e)
        {
            var db = new NorthwindEntities();
            var query = db.Products.Where(p => p.UnitPrice.Value > 100).Take(3);

            var q2 = (from p in db.Products
                     where p.UnitPrice.Value > 50
                     orderby p.UnitPrice.Value descending
                     select p).Skip(2).Take(3);


            textBox1.Text = q2.ToString(); // log the T-SQL

            listBox1.Items.Clear();
            foreach (var item in q2)
            {
                listBox1.Items.Add(item.ProductName + " costs " + item.UnitPrice.Value);
            }

        }

        private void LinqToXmlButton_Click(object sender, EventArgs e)
        {
            var db = new NorthwindEntities();

            var products = db.Products.ToList();

            var xml = new XElement("products",
                from p in products
                select new XElement("product",
                    new XAttribute("name", p.ProductName),
                    new XAttribute("price", p.UnitPrice.Value),
                    new XElement("unitsInStock", p.UnitsInStock)));

            textBox1.Text = xml.ToString();
        }
    }

    public static class MyExtensions
    {
        public static bool MoreThanFour<T>(this IEnumerable<T> array)
        {
            return true;
        }
    }

    delegate int CalcDelegate(int x, int y); // signature types must match

    public class MyGeneric<T> where T : IComparable
    {
        public T Data { get; set; }
        public void ProcessData()
        {
            //Data.CompareTo
        }
    }
}
