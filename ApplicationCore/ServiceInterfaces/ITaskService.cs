using ApplicationCore.Entities;
using ApplicationCore.Models;

namespace ApplicationCore.ServiceInterfaces
{
    public interface ITaskService : IEfService<TaskResponseModel, TaskRequestModel>
    {
        
    }
}