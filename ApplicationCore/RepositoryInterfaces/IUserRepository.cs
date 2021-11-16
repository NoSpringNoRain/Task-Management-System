using System.Collections.Generic;
using System.Threading.Tasks;
using ApplicationCore.Entities;
using Task = ApplicationCore.Entities.Task;

namespace ApplicationCore.RepositoryInterfaces
{
    public interface IUserRepository : IAsyncRepository<User>
    {
        Task<IEnumerable<Task>> GetAllTasksForUser(int userId);
        Task<IEnumerable<TaskHistory>> GetAllTasksHistoryForUser(int userId);
    }
}