using System;
using System.Collections.Generic;
using System.Text;

namespace SOMINCA.Domain.Models
{
    public partial class Reserva
    {
        public int Id { get; set; }
        public DateTime Reservacion { get; set; }
        public DateTime Entrega { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
