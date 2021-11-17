using System.Collections.Generic;
using System.Threading.Tasks;
using ApplicationCore.Entities;
using ApplicationCore.Models;
using ApplicationCore.RepositoryInterfaces;
using ApplicationCore.ServiceInterfaces;
using Task = ApplicationCore.Entities.Task;

namespace Infrastructure.Services
{
    public class TaskService : ITaskService
    {
        private readonly ITaskRepository _taskRepository;

        public TaskService(ITaskRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }

        public async Task<IEnumerable<TaskResponseModel>> GetAll()
        {
            var tasks = await _taskRepository.GetAll();
            var taskResponseModels = new List<TaskResponseModel>();

            foreach (var task in tasks)
            {
                var taskResponseModel = new TaskResponseModel
                {
                    Id = task.Id,
                    UserId = task.UserId,
                    Title = task.Title,
                    Description = task.Description,
                    DueDate = task.DueDate,
                    Priority = task.Priority,
                    Remarks = task.Remarks
                };
                taskResponseModels.Add(taskResponseModel);
            }

            return taskResponseModels;
        }

        public async Task<bool> Add(TaskRequestModel taskRequestModel)
        {
            var task = new Task
            {
                UserId = taskRequestModel.UserId,
                Title = taskRequestModel.Title,
                Description = taskRequestModel.Description,
                DueDate = taskRequestModel.DueDate,
                Priority = taskRequestModel.Priority,
                Remarks = taskRequestModel.Remarks
            };
            await _taskRepository.Add(task);
            return true;
        }

        public async Task<bool> Update(TaskRequestModel taskRequestModel)
        {
            var task = new Task
            {
                UserId = taskRequestModel.UserId,
                Title = taskRequestModel.Title,
                Description = taskRequestModel.Description,
                DueDate = taskRequestModel.DueDate,
                Priority = taskRequestModel.Priority,
                Remarks = taskRequestModel.Remarks
            };
            await _taskRepository.Update(task);
            return true;
        }

        public async Task<bool> Delete(TaskRequestModel taskRequestModel)
        {
            var task = new Task
            {
                UserId = taskRequestModel.UserId,
                Title = taskRequestModel.Title,
                Description = taskRequestModel.Description,
                DueDate = taskRequestModel.DueDate,
                Priority = taskRequestModel.Priority,
                Remarks = taskRequestModel.Remarks
            };
            await _taskRepository.Delete(task);
            return true;
        }
    }
}