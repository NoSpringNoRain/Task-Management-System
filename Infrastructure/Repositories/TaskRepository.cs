using ApplicationCore.Entities;
using ApplicationCore.RepositoryInterfaces;
using Infrastructure.Data;

namespace Infrastructure.Repositories
{
    public class TaskRepository : EfRepository<Task>, ITaskRepository
    {
        public TaskRepository(TaskManagerDbContext dbContext) : base(dbContext)
        {
        }
    }
}