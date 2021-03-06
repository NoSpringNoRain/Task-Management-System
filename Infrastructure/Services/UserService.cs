using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApplicationCore.Entities;
using ApplicationCore.Models;
using ApplicationCore.RepositoryInterfaces;
using ApplicationCore.ServiceInterfaces;
using Task = System.Threading.Tasks.Task;

namespace Infrastructure.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly ITaskRepository _taskRepository;
        private readonly ITaskHistoryRepository _taskHistoryRepository;

        public UserService(IUserRepository userRepository, ITaskRepository taskRepository, ITaskHistoryRepository taskHistoryRepository)
        {
            _userRepository = userRepository;
            _taskRepository = taskRepository;
            _taskHistoryRepository = taskHistoryRepository;
        }

        public async Task<IEnumerable<UserResponseModel>> GetAll()
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
                var taskResponseModel = new UserTaskModel
                {
                    Id = task.Id,
                    Title = task.Title,
                    Description = task.Description,
                    DueDate = task.DueDate.GetValueOrDefault(),
                    Priority = task.Priority.GetValueOrDefault(),
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
                var taskHistoryResponseModel = new UserTaskHistoryModel
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

        public async Task<bool> Add(UserRequestModel userRequestModel)
        {
            var user = new User
            {
                Email = userRequestModel.Email,
                Password = userRequestModel.Password,
                Fullname = userRequestModel.Fullname,
                Mobileno = userRequestModel.Mobile
            };
            await _userRepository.Add(user);
            return true;
        }

        public async Task<bool> Update(UserRequestModel userRequestModel)
        {
            var user = new User
            {
                Email = userRequestModel.Email,
                Password = userRequestModel.Password,
                Fullname = userRequestModel.Fullname,
                Mobileno = userRequestModel.Mobile
            };
            await _userRepository.Update(user);
            return true;
        }

        public async Task<bool> Delete(int id)
        {
            var user = await _userRepository.GetById(id);
            if (user is null) return false;
            await _userRepository.Delete(user);
            return true;
        }
        
        public async Task<bool> CompleteTask(int taskId)
        {
            var task = await _taskRepository.GetById(taskId);
            if (task is null) return false;
            var taskHistory = new TaskHistory
            {
                TaskId = task.Id,
                UserId = task.UserId.GetValueOrDefault(),
                Title = task.Title,
                Description = task.Description,
                DueDate = task.DueDate,
                Completed = DateTime.Now,
                Remarks = task.Remarks
            };
            await _taskHistoryRepository.Add(taskHistory);
            await _taskRepository.Delete(task);
            return true;
        }
    }
}