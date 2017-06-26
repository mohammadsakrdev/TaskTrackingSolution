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

    public class UserStoriesController : ApiController
    {
        UserStoriesRepository repository;

        public UserStoriesController()
        {
            repository = new UserStoriesRepository();
        }

        // GET api/userstories
        [Route("api/userstories")]
        public IEnumerable<UserStory> Get()
        {
            return repository.GetAllUserStories();
        }

        // GET api/userstories/5
        [Route("api/userstories/{id?}")]
        public UserStory Get(int id)
        {
            return repository.GetUserStory(id);
        }

        [Route("api/userstories")]
        public IEnumerable<UserStory> Post([FromBody]UserStory us)
        {
            return repository.InsertUserStory(us);
        }

        [Route("api/userstories")]
        public IEnumerable<UserStory> Put(UserStory us)
        {
            return repository.UpdateUserStory(us);
        }

        [Route("api/userstories")]
        public IEnumerable<UserStory> Delete(UserStory us)
        {
            return repository.DeleteUserStory(us);
        }
    }
}
