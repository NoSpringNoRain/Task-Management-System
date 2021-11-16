using System;
using System.Collections.Generic;

namespace ApplicationCore.Models
{
    public class UserTaskHistoryResponseModel
    {
        public UserTaskHistoryResponseModel()
        {
            TasksHistory = new List<UserTaskHistoryModel>();
        }

        public int TotalTasksHistoryCount { get; set; }
        public List<UserTaskHistoryModel> TasksHistory { get; set; }
    }
    
    public class UserTaskHistoryModel
    {
        public int TaskId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime Completed { get; set; }
        public string Remarks { get; set; }
    }
}