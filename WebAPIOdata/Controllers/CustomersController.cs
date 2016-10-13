using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.OData;
using NorthwindModels;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace WebAPIOdata.Controllers
{
    public class CustomersController : ODataController
    {
        private NW db = new NW();

        [EnableQuery]
        public IQueryable<Customer> Get()
        {
            return db.Customers;
        }
        [EnableQuery]
        public SingleResult<Customer> Get([FromODataUri] string key)
        {
            IQueryable<Customer> result = db.Customers.Where(c => c.CustomerID == key);
            return SingleResult.Create(result);
        }
        public async Task<IHttpActionResult> Post(Customer customer)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            db.Customers.Add(customer);
            await db.SaveChangesAsync();
            return Created(customer);
        }
        public async Task<IHttpActionResult> Patch([FromODataUri] string key, Delta<Customer> customer)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var entity = await db.Customers.FindAsync(key);
            if (entity == null)
            {
                return NotFound();
            }
            customer.Patch(entity);
            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!customerExists(key))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return Updated(entity);
        }
        public async Task<IHttpActionResult> Put([FromODataUri] string key, Customer update)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            if (key != update.CustomerID)
            {
                return BadRequest();
            }
            db.Entry(update).State = EntityState.Modified;
            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!customerExists(key))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return Updated(update);
        }

        private bool customerExists(string customerID)
        {
            return db.Customers.Any(c => c.CustomerID == customerID);
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}
