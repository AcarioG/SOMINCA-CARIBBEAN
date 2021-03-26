using SOMINCA.Domain.Models;
using SOMINCA.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOMINCA.Repository.Repositories
{
    public class UserRepository : BaseRepository<Usuario>, IUserRepository
    {
        public UserRepository(ApplicationDbContext context)
            : base(context)
        {

        }
        public async Task AddUser(Usuario entity)
        {
            await Insert(entity);
        }

        public async Task DeleteUser(Usuario entity)
        {
            await Delete(entity);
        }

        public async Task<IEnumerable<Usuario>> GetAllUsers()
        {
            return await GetAll();
        }

        public async Task<Usuario> GetUser(int Id)
        {
            return await Get(Id);
        }

        public async Task ModifyUser(Usuario entity)
        {
            await Update(entity);
        }

        public async Task<bool> SaveUserDbAsync()
        {
            return await Save();
        }

        public async Task<bool> UserExistsAsync(int Id)
        {
            var user = await GetAllUsers();
            return user.Any(db => db.Id == Id);
        }
    }
}
