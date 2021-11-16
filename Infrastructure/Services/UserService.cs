using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApplicationCore.Models;
using ApplicationCore.RepositoryInterfaces;
using ApplicationCore.ServiceInterfaces;

namespace Infrastructure.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<IEnumerable<UserResponseModel>> GetAllUsers()
        {
            var users = await _userRepository.GetAll();
            var userList = new List<UserResponseModel>();
            foreach (var user in users)
            {
                var userResponseModel = new UserResponseModel
                {
                    Id = user.Id,
                    Email = user.Email,
                    Fullname = user.Fullname,
                    Mobile = user.Mobileno
                };
                userList.Add(userResponseModel);
            }
            return userList;
        }

        public async Task<UserTaskResponseModel> GetAllTasksForUser(int userId)
        {
            var tasks = await _userRepository.GetAllTasksForUser(userId);
            var userTaskResponseModel = new UserTaskResponseModel();
            foreach (var task in tasks)
            {
                var taskResponseModel = new TaskResposneModel
                {
                    Id = task.Id,
                    Title = task.Title,
                    Description = task.Description,
                    DueDate = task.DueDate.GetValueOrDefault(),
                    Remarks = task.Remarks
                };
                userTaskResponseModel.Tasks.Add(taskResponseModel);
            }

            userTaskResponseModel.TotalTasksCount = userTaskResponseModel.Tasks.Count();
            
            return userTaskResponseModel;
        }

        public async Task<UserTaskHistoryResponseModel> GetAllTasksHistoryForUser(int userId)
        {
            var tasksHistory = await _userRepository.GetAllTasksHistoryForUser(userId);
            var userTasksHistoryResponseModel = new UserTaskHistoryResponseModel();
            foreach (var taskHistory in tasksHistory)
            {
                var taskHistoryResponseModel = new TaskHistoryResponseModel
                {
                    TaskId = taskHistory.TaskId,
                    Title = taskHistory.Title,
                    Description = taskHistory.Description,
                    DueDate = taskHistory.DueDate.GetValueOrDefault(),
                    Completed = taskHistory.Completed.GetValueOrDefault(),
                    Remarks = taskHistory.Remarks
                };
                userTasksHistoryResponseModel.TasksHistory.Add(taskHistoryResponseModel);
            }

            userTasksHistoryResponseModel.TotalTasksHistoryCount = userTasksHistoryResponseModel.TasksHistory.Count();
            
            return userTasksHistoryResponseModel;
        }
    }
}