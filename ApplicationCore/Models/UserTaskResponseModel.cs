using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public class UserTaskResponseModel
    {
        public UserTaskResponseModel()
        {
            Tasks = new List<TaskResposneModel>();
        }

        public int TotalTasksCount { get; set; }
        public List<TaskResposneModel> Tasks { get; set; }
    }
    
    public class TaskResposneModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public string Remarks { get; set; }
    }
}