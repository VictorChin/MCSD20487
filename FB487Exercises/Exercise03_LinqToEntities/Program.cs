using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise03_LinqToEntities
{
    class OrderSubtotal
    {
        public int OrderID { get; set; }
        public string CustomerID { get; set; }
        public decimal ValueOfOrder { get; set; }
    }
    class CustomerTotal
    {
        public string CompanyName { get; set; }
        public decimal TotalValueOfOrders { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var db = new Northwind();

            Console.WriteLine("Show the number of orders shipped by each shipping company");

            var numberOfOrdersShippedByEachShippingCompany = db.Shippers.GroupJoin(db.Orders,
                s => s.ShipperID, o => o.ShipVia,
                (shipper, orders) => new
                {
                    shipper.CompanyName,
                    NumberOfOrdersShipped = orders.Count()
                }).ToArray();

            foreach (var item in numberOfOrdersShippedByEachShippingCompany)
            {
                Console.WriteLine("{0} shipped {1:N0} orders.", item.CompanyName, item.NumberOfOrdersShipped);
            }
            Console.WriteLine("");

            Console.WriteLine("Show the total value of orders for each customer ordered with the largest order value first");

            var customers = db.Customers.Select(c => new { c.CustomerID, c.CompanyName }).ToArray();

            var orderValues = db.Orders.GroupJoin(db.Order_Details,
                o => o.OrderID, d => d.OrderID,
                (order, details) => new OrderSubtotal
                {
                    OrderID = order.OrderID,
                    CustomerID = order.CustomerID,
                    ValueOfOrder = details.Sum(d => d.Quantity * d.UnitPrice)
                }).ToArray();

            var totalValueOfOrdersForEachCustomer = customers.GroupJoin(orderValues,
                c => c.CustomerID, o => o.CustomerID,
                (customer, orders) => new CustomerTotal
                {
                    CompanyName = customer.CompanyName,
                    TotalValueOfOrders = orders.Sum(v => v.ValueOfOrder)
                }).OrderByDescending(t => t.TotalValueOfOrders).ToArray();

            foreach (var item in totalValueOfOrdersForEachCustomer)
            {
                Console.WriteLine("{0} ordered a total value of {1:C}.", item.CompanyName, item.TotalValueOfOrders);
            }
            Console.WriteLine("");

            /*
                Write code to 
                Insert a new customer
                Modify the customer named Alfred’s Futterkiste to move to an address in London, UK
                Delete the customer that you added earlier
            */

            var newCustomer = new Customer
            {
                CompanyName = "NewCo",
                CustomerID = "AAAAA",
                Country = "UK"
            };
            db.Customers.Add(newCustomer);

            var alfreds = db.Customers.Find("ALFKI");
            alfreds.Address = "Russell Square";
            alfreds.City = "London";
            alfreds.Country = "UK";
            int changes = db.SaveChanges();
            Console.WriteLine("{0} changes saved.", changes);

            var deleteCustomer = db.Customers.Find("AAAAA");
            db.Customers.Remove(deleteCustomer);
            int deleted = db.SaveChanges();
            Console.WriteLine("{0} customers deleted.", deleted);
        }
    }
}
