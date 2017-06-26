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

    public class ProjectsController : ApiController
    {
        ProjectsRepository repository;

        public ProjectsController()
        {
            repository = new ProjectsRepository();
        }

        // GET api/projects
        [Route("api/projects")]
        public IEnumerable<Project> Get()
        {
            return repository.GetAllProjects();
        }

        // GET api/projects/5
        [Route("api/projects/{id?}")]
        public Project Get(int id)
        {
            return repository.GetProject(id);
        }

        [Route("api/projects/{name:alpha}")]
        public IEnumerable<Project> Get(string name)
        {
            return repository.GetProjectByName(name);
        }

        [Route("api/projects")]
        public IEnumerable<Project> Post(Project p)
        {
            return repository.InsertProject(p);
        }

        [Route("api/projects/{id}")]
        public IEnumerable<Project> Put([FromBody]Project p)
        {
            return repository.UpdateProject(p);
        }

        [Route("api/projects/{id}")]
        [HttpDelete]
        public IEnumerable<Project> Delete(int id)
        {
            return repository.DeleteProject(id);
        }
    }
}
