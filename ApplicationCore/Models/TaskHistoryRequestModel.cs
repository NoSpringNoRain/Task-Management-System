using System;

namespace ApplicationCore.Models
{
    public class TaskHistoryRequestModel
    {
        public int TaskId { get; set; }
        public int UserId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime? DueDate { get; set; }
        public DateTime Completed { get; set; }
        public string Remarks { get; set; }
    }
}