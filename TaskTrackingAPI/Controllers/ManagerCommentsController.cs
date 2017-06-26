using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using TaskTrackingAPI.Models;

namespace TaskTrackingAPI.Controllers
{
    [EnableCors(origins: "http://localhost:55058", headers: "*", methods: "*")]
    public class ManagerCommentsController : ApiController
    {
        // GET api/ptmanagercomments
        [Route("api/managercomments")]
        public IEnumerable<ManagerComment> Get()
        {
            return ManagerCommentsRepository.GetAllManagerComments();
        }

        // GET api/ptmanagercomments/5
        [Route("api/managercomments/{id?}")]
        public ManagerComment Get(int id)
        {
            return ManagerCommentsRepository.GetManagerComment(id);
        }

        [Route("api/managercomments")]
        public IEnumerable<ManagerComment> Post(ManagerComment comment)
        {
            return ManagerCommentsRepository.InsertManagerComments(comment);
        }

        [Route("api/managercomments")]
        public IEnumerable<ManagerComment> Put(ManagerComment comment)
        {
            return ManagerCommentsRepository.UpdateManagerComments(comment);
        }

        [Route("api/managercomments")]
        public IEnumerable<ManagerComment> Delete(ManagerComment comment)
        {
            return ManagerCommentsRepository.DeleteManagerComments(comment);
        }
    }
}
