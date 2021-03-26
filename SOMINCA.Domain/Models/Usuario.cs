using System;
using System.Collections.Generic;
using System.Text;

namespace SOMINCA.Domain.Models
{
    public partial class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public virtual Vehiculo Vehiculos { get; set; }
        public virtual ICollection<Reserva> Reservas { get; set; }
    }
}
