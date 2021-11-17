using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using ApplicationCore.Models;

namespace ApplicationCore.ServiceInterfaces
{
    public interface IUserService : IEfService<UserResponseModel, UserRequestModel>
    {
        Task<UserTaskResponseModel> GetAllTasksForUser(int userId);
        Task<UserTaskHistoryResponseModel> GetAllTasksHistoryForUser(int userId);
        Task<bool> CompleteTask(int taskId);
    }
}