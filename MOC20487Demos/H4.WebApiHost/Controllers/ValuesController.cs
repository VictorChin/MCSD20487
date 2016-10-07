using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace H4.WebApiHost2.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> GetXXX()
        {
            return new string[] { "Alice", "Bob" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "Value: " + id;
        }

        [ActionName("message")]
        public string Message()
        {
            return "Hello world";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}