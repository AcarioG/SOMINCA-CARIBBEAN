using SOMINCA.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SOMINCA.Repository.Interfaces
{
    public interface IReservaRepository :IBaseRepository<Reserva>
    {
        Task<IEnumerable<Reserva>> GetAllReservas();
        Task<Reserva> GetReserva(int Id);
        Task AddReserva(Reserva entity);
        Task ModifyReserva(Reserva entity);
        Task DeleteReserva(Reserva entity);
        Task<bool> SaveReservaDbAsync();
        Task<bool> ReservaExistsAsync(int Id);
    }
}
