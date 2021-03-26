using System;
using System.Collections.Generic;
using System.Text;

namespace SOMINCA.Domain.DTO
{
    public class UsuarioDTO
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public VehiculoDTO Vehiculos { get; set; }
        public virtual ICollection<ReservaDTO> Reservas { get; set; }
    }
}
