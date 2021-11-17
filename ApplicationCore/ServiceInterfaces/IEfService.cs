using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApplicationCore.ServiceInterfaces
{
    public interface IEfService<T, U> where T : class where U : class
    {
        Task<IEnumerable<T>> GetAll();
        Task<bool> Add(U entity);
        Task<bool> Update(U entity);
        Task<bool> Delete(int id);
    }
}