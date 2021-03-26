using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SOMINCA.Repository.Interfaces
{
    public interface IBaseRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> Get(int Id);
        Task Insert(T entity);
        Task Update(T entity);
        Task Delete(T entity);
        Task<bool> Save();
    }
}
