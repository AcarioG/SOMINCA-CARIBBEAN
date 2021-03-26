using System;
using System.Collections.Generic;
using System.Text;

namespace SOMINCA.Domain.DTO
{
    public partial class ReservaDTO
    {
        public int Id { get; set; }
        public DateTime Reservacion { get; set; }
        public DateTime Entrega { get; set; }
        public UsuarioDTO Usuario { get; set; }
    }
}
