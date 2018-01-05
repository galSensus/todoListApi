//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace todoList.Models
{
    using System;
    using System.Collections.Generic;
    using todoList.Controllers;

    public partial class Task
    {
        public long TaskId { get; set; }
        public string Title { get; set; }
        public string Details { get; set; }
        public Nullable<System.DateTime> Date { get; set; }

        public static implicit operator Task(TaskObj taskObj)
        {
            Task newTask = new Task
            {
                TaskId = taskObj.TaskId,
                Details = taskObj.Details,
                Date = taskObj.Date,
                Title = taskObj.Title
            };
            return newTask;
        }
    }
}
