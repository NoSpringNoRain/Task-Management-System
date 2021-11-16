using System.Collections.Generic;
using System.Threading.Tasks;
using ApplicationCore.Entities;
using ApplicationCore.ServiceInterfaces;

namespace Infrastructure.Services
{
    public class TaskHistoryService : ITaskHistoryService
    {
        public async Task<IEnumerable<TaskHistory>> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public async Task<TaskHistory> Add(TaskHistory entity)
        {
            throw new System.NotImplementedException();
        }

        public async Task<TaskHistory> Update(TaskHistory entity)
        {
            throw new System.NotImplementedException();
        }

        public async Task<TaskHistory> Delete(TaskHistory entity)
        {
            throw new System.NotImplementedException();
        }
    }
}