using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ApplicationCore.RepositoryInterfaces
{
    public interface IAsyncRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> GetById(int id);
        Task<T> Add(T entity);
        Task<T> Update(T entity);
        Task Delete(T entity);
    }
}