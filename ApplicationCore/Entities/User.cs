using System.Collections;
using System.Collections.Generic;

namespace ApplicationCore.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Fullname { get; set; }
        public string Mobileno { get; set; }
        
        public ICollection<Task> Tasks{ get; set; }
        public ICollection<TaskHistory> TasksHistory { get; set; }
    }
}