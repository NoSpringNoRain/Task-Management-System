using System.Collections.Generic;
using System.Threading.Tasks;
using ApplicationCore.Entities;
using ApplicationCore.Models;
using ApplicationCore.RepositoryInterfaces;
using ApplicationCore.ServiceInterfaces;
using Task = System.Threading.Tasks.Task;

namespace Infrastructure.Services
{
    public class TaskHistoryService : ITaskHistoryService
    {
        private readonly ITaskHistoryRepository _taskHistoryRepository;

        public TaskHistoryService(ITaskHistoryRepository taskHistoryRepository)
        {
            _taskHistoryRepository = taskHistoryRepository;
        }

        public async Task<IEnumerable<TaskHistoryResponseModel>> GetAll()
        {
            var tasksHistory = await _taskHistoryRepository.GetAll();
            var taskHistoryResponseModels = new List<TaskHistoryResponseModel>();

            foreach (var taskHistory in tasksHistory)
            {
                var taskHistoryResponseModel = new TaskHistoryResponseModel
                {
                    TaskId = taskHistory.TaskId,
                    UserId = taskHistory.UserId,
                    Title = taskHistory.Title,
                    Description = taskHistory.Description,
                    DueDate = taskHistory.DueDate,
                    Completed = taskHistory.Completed,
                    Remarks = taskHistory.Remarks
                };
                taskHistoryResponseModels.Add(taskHistoryResponseModel);
            }

            return taskHistoryResponseModels;
        }

        public async Task<bool> Add(TaskHistoryRequestModel taskHistoryRequestModel)
        {
            var taskHistory = new TaskHistory
            {
                UserId = taskHistoryRequestModel.UserId,
                Title = taskHistoryRequestModel.Title,
                Description = taskHistoryRequestModel.Description,
                DueDate = taskHistoryRequestModel.DueDate,
                Completed = taskHistoryRequestModel.Completed,
                Remarks = taskHistoryRequestModel.Remarks
            };
            await _taskHistoryRepository.Add(taskHistory);
            return true;
        }

        public async Task<bool> Update(TaskHistoryRequestModel taskHistoryRequestModel)
        {
            var taskHistory = new TaskHistory
            {
                UserId = taskHistoryRequestModel.UserId,
                Title = taskHistoryRequestModel.Title,
                Description = taskHistoryRequestModel.Description,
                DueDate = taskHistoryRequestModel.DueDate,
                Completed = taskHistoryRequestModel.Completed,
                Remarks = taskHistoryRequestModel.Remarks
            };
            await _taskHistoryRepository.Update(taskHistory);
            return true;
        }

        public async Task<bool> Delete(int id)
        {
            var taskHistory = await _taskHistoryRepository.GetById(id);
            if (taskHistory is null) return false;
            await _taskHistoryRepository.Delete(taskHistory);
            return true;
        }
    }
}