using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApplicationCore.Entities;
using ApplicationCore.RepositoryInterfaces;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Task = ApplicationCore.Entities.Task;

namespace Infrastructure.Repositories
{
    public class UserRepository : EfRepository<User>, IUserRepository
    {
        public UserRepository(TaskManagerDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<IEnumerable<Task>> GetAllTasksForUser(int userId)
        {
            var tasks = await _dbContext.Tasks.Where(t => t.UserId == userId).ToListAsync();
            return tasks;
        }

        public async Task<IEnumerable<TaskHistory>> GetAllTasksHistoryForUser(int userId)
        {
            var tasksHistory = await _dbContext.TasksHistory.Where(th => th.UserId == userId).ToListAsync();
            return tasksHistory;
        }
    }
}