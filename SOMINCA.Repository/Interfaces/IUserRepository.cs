using SOMINCA.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOMINCA.Repository.Interfaces
{
    public interface IUserRepository : IBaseRepository<Usuario>
    {
        Task<IEnumerable<Usuario>> GetAllUsers();
        Task<Usuario> GetUser(int Id);
        Task AddUser(Usuario entity);
        Task ModifyUser(Usuario entity);
        Task DeleteUser(Usuario entity);
        Task<bool> SaveUserDbAsync();
        Task<bool> UserExistsAsync(int Id);
    }
}
