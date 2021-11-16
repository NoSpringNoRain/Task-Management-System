using System.Collections.Generic;
using ApplicationCore.Entities;
using ApplicationCore.ServiceInterfaces;

namespace Infrastructure.Services
{
    public class TaskService : ITaskService
    {
        public async System.Threading.Tasks.Task<IEnumerable<Task>> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public async System.Threading.Tasks.Task<Task> Add(Task entity)
        {
            throw new System.NotImplementedException();
        }

        public async System.Threading.Tasks.Task<Task> Update(Task entity)
        {
            throw new System.NotImplementedException();
        }

        public async System.Threading.Tasks.Task<Task> Delete(Task entity)
        {
            throw new System.NotImplementedException();
        }
    }
}