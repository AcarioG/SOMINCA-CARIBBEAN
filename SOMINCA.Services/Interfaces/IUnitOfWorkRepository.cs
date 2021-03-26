using SOMINCA.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SOMINCA.Services.Interfaces
{
    public interface IUnitOfWorkRepository
    {
        IReservaRepository ReservasRepository { get; }
    }
}
