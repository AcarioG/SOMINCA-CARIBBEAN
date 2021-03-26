using SOMINCA.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SOMINCA.Services.Interfaces
{
    public interface IReservaServices
    {
        Task<IEnumerable<ReservaDTO>> GetAllReservasAsync();
        Task<ReservaDTO> GetReservasAsync(int Id);
        Task AddReservasAsync(ReservaDTO entity);
        Task ModifyReservasAsync(PutReservaDTO entity);
        Task DeleteReservasAsync(DeleteReservaDTO entity);
        Task<bool> SaveReservaAsync();
        Task<bool> ReservaExistAsync(int Id);
    }
}
