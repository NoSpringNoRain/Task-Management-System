using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApplicationCore.ServiceInterfaces
{
    public interface IEfService<T> where T : class
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> Add(T entity);
        Task<T> Update(T entity);
        Task<T> Delete(T entity);
    }
}