using SOMINCA.Domain.Models;
using SOMINCA.Repository.Interfaces;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SOMINCA.Repository.Repositories
{
    public class ReservaRepository : BaseRepository<Reserva>, IReservaRepository
    {
        public ReservaRepository(ApplicationDbContext context)
            : base(context)
        {

        }
        public async Task AddReserva(Reserva entity)
        {
            await Insert(entity);
        }

        public async Task DeleteReserva(Reserva entity)
        {
            await Delete(entity);
        }

        public async Task<IEnumerable<Reserva>> GetAllReservas()
        {
            return await GetAll();
        }

        public async Task<Reserva> GetReserva(int Id)
        {
            return await Get(Id);
        }

        public async Task ModifyReserva(Reserva entity)
        {
            await Update(entity);
        }

        public async Task<bool> ReservaExistsAsync(int Id)
        {
            var reserva = await GetAllReservas();
            return reserva.Any(db => db.Id == Id);
        }

        public async Task<bool> SaveReservaDbAsync()
        {
            return await Save();
        }
    }
}
