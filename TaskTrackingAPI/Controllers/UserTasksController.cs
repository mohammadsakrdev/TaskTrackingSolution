using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TaskTrackingAPI.Controllers
{
    public class UserTasksController : ApiController
    {
        // GET: api/UserTasks
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/UserTasks/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/UserTasks
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/UserTasks/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/UserTasks/5
        public void Delete(int id)
        {
        }
    }
}
