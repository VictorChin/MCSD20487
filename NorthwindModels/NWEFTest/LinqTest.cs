using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NorthwindModels;
using System.Data.Entity;
using System.Linq;
using System.Diagnostics;

namespace NWEFTest
{
    [TestClass]
    public class LinqTest
    {

        [TestMethod]
        public void LinqSelect() 
        {
            NW ctx = new NW();
            ctx.Database.Log= (s) => TestContext.WriteLine(s);
            var q = from c in ctx.Customers.Include("Orders")
                    select c;
            var result = q.ToList();
           Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result.First(), typeof(Customer));

        }
      

        private TestContext testContextInstance;
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

    }
}
