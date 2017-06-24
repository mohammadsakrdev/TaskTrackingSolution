using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TaskTrackingAPI.Controllers
{
    public class ProjectsControllerController : ApiController
    {
        // GET: api/ProjectsController
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/ProjectsController/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/ProjectsController
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/ProjectsController/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/ProjectsController/5
        public void Delete(int id)
        {
        }
    }
}
