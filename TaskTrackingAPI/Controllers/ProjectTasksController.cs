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
    public class ProjectTasksController : ApiController
    {
        // GET api/projecttasks
        [Route("api/projecttasks")]
        public IEnumerable<ProjectTask> Get()
        {
            return ProjectTasksRepository.GetAllProjectTasks();
        }

        // GET api/projecttasks/5
        [Route("api/projecttasks/{id?}")]
        public ProjectTask Get(int id)
        {
            return ProjectTasksRepository.GetProjectTask(id);
        }

        [Route("api/projecttasks")]
        public IEnumerable<ProjectTask> Post(ProjectTask pt)
        {
            return ProjectTasksRepository.InsertProjectTask(pt);
        }

        [Route("api/projecttasks")]
        public IEnumerable<ProjectTask> Put(ProjectTask pt)
        {
            return ProjectTasksRepository.UpdateProjectTask(pt);
        }

        [Route("api/projecttasks")]
        public IEnumerable<ProjectTask> Delete(ProjectTask pt)
        {
            return ProjectTasksRepository.DeleteProjectTask(pt);
        }
    }
}
