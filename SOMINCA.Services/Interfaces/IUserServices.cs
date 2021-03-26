using SOMINCA.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOMINCA.Services.Interfaces
{
    public interface IUserServices
    {
        Task<IEnumerable<UsuarioDTO>> GetAllUserAsync();
        Task<UsuarioDTO> GetUsuarioAsync(int Id);
        Task AddUsuarioAsync(UsuarioDTO entity);
        Task ModifyUsuarioAsync(UsuarioDTO entity);
    }
}
