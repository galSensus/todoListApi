using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace todoList.Controllers
{
    public class TaskController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "12", "13", "14" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "22";
        }


        public void AddTask(TaskObj task)
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


    public class TaskObj
    {
        public string Title { get; set; }
        public string Details { get; set; }
        public string Date { get; set; }
        public int Id { get; set; }
    }
}
