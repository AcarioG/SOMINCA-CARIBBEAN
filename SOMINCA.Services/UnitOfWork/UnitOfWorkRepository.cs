using SOMINCA.Domain.Models;
using SOMINCA.Repository.Interfaces;
using SOMINCA.Repository.Repositories;
using SOMINCA.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SOMINCA.Services.UnitOfWork
{
    public class UnitOfWorkRepository : IUnitOfWorkRepository
    {
        public IReservaRepository ReservasRepository { get; }

        public UnitOfWorkRepository(ApplicationDbContext context)
        {
            ReservasRepository = new ReservaRepository(context);
        }
    }
}
