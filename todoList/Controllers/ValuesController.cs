using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using todoList.Models;

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
            Task newTask = new Task
            {
                TaskId = task.Id,
                Title = task.Title,
                Details = task.Details,
                Date = task.Date   
            };
            using (var db = new TodoListEntities1())
            {
                db.Tasks.Add(newTask);
                db.SaveChanges();
            }
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
        public DateTime Date { get; set; }
        public long Id { get; set; }
    }
}
