using ApplicationCore.Entities;
using ApplicationCore.RepositoryInterfaces;
using Infrastructure.Data;

namespace Infrastructure.Repositories
{
    public class TaskHistoryRepository : EfRepository<TaskHistory>, ITaskHistoryRepository
    {
        public TaskHistoryRepository(TaskManagerDbContext dbContext) : base(dbContext)
        {
        }
    }
}