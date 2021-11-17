using ApplicationCore.Entities;
using ApplicationCore.Models;

namespace ApplicationCore.ServiceInterfaces
{
    public interface ITaskHistoryService : IEfService<TaskHistoryResponseModel, TaskHistoryRequestModel>
    {
        
    }
}