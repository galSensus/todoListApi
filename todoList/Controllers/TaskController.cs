using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using todoList.Models;

namespace todoList.Controllers
{
    public class TaskController : ApiController
    {
        [Route("api/task/addTask")]
        [HttpPost]
        public void AddTask(TaskObj task)
        {
            Task newTask = new Task
            {
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

        [Route("api/task/editTask")]
        [HttpPut]
        public void EditTask(TaskObj task)
        {
            using (var db = new TodoListEntities1())
            {
                var selectedTask = db.Tasks.FirstOrDefault(x => x.TaskId == task.TaskId);
                selectedTask = task;
                db.Tasks.AddOrUpdate(selectedTask);
                db.SaveChanges();
            }
        }

        [Route("api/task/deleteTask")]
        [HttpPost]
        public void DeleteTask(long taskId)
        {
            using (var db = new TodoListEntities1())
            {
                var deleteTask = db.Tasks.FirstOrDefault(x => x.TaskId == taskId);
                db.Tasks.Remove(deleteTask);
                db.SaveChanges();
            }
        }

        [Route("api/task/getTasks")]
        [HttpGet]
        public List<Task> GetTasks()
        {
            using (var db = new TodoListEntities1())
            {
                List<Task> tasksList = db.Tasks.ToList();
                return tasksList;
            }
            
        }




























        //// GET api/values
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "12", "13", "14" };
        //}

        //// GET api/values/5
        //public string Get(int id)
        //{
        //    return "22";
        //}




        //// PUT api/values/5
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE api/values/5
        //public void Delete(int id)
        //{
        //}
    }


    public class TaskObj
    {
        public string Title { get; set; }
        public string Details { get; set; }
        public DateTime Date { get; set; }
        public long TaskId { get; set; }
    }
}
