using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using ApplicationCore.Models;

namespace ApplicationCore.ServiceInterfaces
{
    public interface IUserService
    {
        Task<IEnumerable<UserResponseModel>> GetAllUsers();
        Task<UserTaskResponseModel> GetAllTasksForUser(int userId);
        Task<UserTaskHistoryResponseModel> GetAllTasksHistoryForUser(int userId);
    }
}