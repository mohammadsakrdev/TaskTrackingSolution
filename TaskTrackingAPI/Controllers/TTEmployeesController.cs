using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TaskTrackingAPI.Controllers
{
    public class TTEmployeesController : ApiController
    {
        // GET: api/TTEmployees
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/TTEmployees/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/TTEmployees
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/TTEmployees/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/TTEmployees/5
        public void Delete(int id)
        {
        }
    }
}
