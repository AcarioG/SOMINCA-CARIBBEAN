using SOMINCA.Domain.DTO;
using SOMINCA.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace SOMINCA.Services
{
    public static class ReservaMappers
    {
        public static List<ReservaDTO> ToListReservaDTO(this List<Reserva> reservas)
        {
            List<ReservaDTO> reservaDTOs = new List<ReservaDTO>();
            reservas.ForEach(c => 
            {
                reservaDTOs.Add(c.ToReservaDTO());
            });
            return reservaDTOs;
        }

        public static ReservaDTO ToReservaDTO(this Reserva reserva)
        {
            return new ReservaDTO()
            {
                Id = reserva.Id,
                Reservacion = reserva.Reservacion,
                Entrega = reserva.Entrega,
                Usuario = new UsuarioDTO()
                {
                    Id = reserva.Usuario.Id
                }
            };
        }
        
        public static Reserva ToReserva(this ReservaDTO reserva)
        {
            return new Reserva()
            {
                Id = reserva.Id,
                Reservacion = reserva.Reservacion,
                Entrega = reserva.Entrega,
                Usuario = new Usuario()
                {
                    Id = reserva.Id
                }
            };
        }

        public static Reserva ToPutComic(this PutReservaDTO putReserva)
        {
            return new Reserva()
            {
                Id = putReserva.Id,
                Reservacion = putReserva.Reservacion,
                Entrega = putReserva.Entrega,
                Usuario = new Usuario()
                {
                    Id = putReserva.Id
                }
            };
        }

        public static Reserva ToDeleteReserva(this DeleteReservaDTO deleteReserva)
        {
            return new Reserva()
            {
                Id = deleteReserva.Id,
                Reservacion = deleteReserva.Reservacion,
                Entrega = deleteReserva.Entrega,
                Usuario = new Usuario()
                {
                    Id = deleteReserva.Id
                }
            };
        }

        public static DeleteReservaDTO ToReservaDelete(this ReservaDTO deleteReserva)
        {
            return new DeleteReservaDTO()
            {
                Id = deleteReserva.Id,
                Reservacion = deleteReserva.Reservacion,
                Entrega = deleteReserva.Entrega,
                Usuario = new UsuarioDTO()
                {
                    Id = deleteReserva.Id
                }
            };
        }
    }
}
