using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public class UserTaskResponseModel
    {
        public UserTaskResponseModel()
        {
            Tasks = new List<UserTaskModel>();
        }

        public int TotalTasksCount { get; set; }
        public List<UserTaskModel> Tasks { get; set; }
    }
    
    public class UserTaskModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public char Priority { get; set; }
        public string Remarks { get; set; }
    }
}