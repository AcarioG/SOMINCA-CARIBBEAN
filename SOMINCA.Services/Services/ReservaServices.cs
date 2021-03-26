using SOMINCA.Domain.DTO;
using SOMINCA.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SOMINCA.Services.Services
{
    public class ReservaServices : IReservaServices
    {
        private readonly IUnitOfWorkRepository _unitOfWork;
        public ReservaServices(IUnitOfWorkRepository unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task AddReservasAsync(ReservaDTO entity)
        {
            await _unitOfWork.ReservasRepository.AddReserva(entity.ToReserva());
        }

        public Task DeleteReservasAsync(DeleteReservaDTO entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ReservaDTO>> GetAllReservasAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ReservaDTO> GetReservasAsync(int Id)
        {
            throw new NotImplementedException();
        }

        public Task ModifyReservasAsync(PutReservaDTO entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ReservaExistAsync(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> SaveReservaAsync()
        {
            throw new NotImplementedException();
        }
    }
}
