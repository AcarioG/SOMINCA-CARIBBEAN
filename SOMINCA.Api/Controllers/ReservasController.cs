using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SOMINCA.Domain.DTO;
using SOMINCA.Services;
using SOMINCA.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SOMINCA.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("CorsPolicy")]
    public class ReservasController : Controller
    {
        private readonly IReservaServices _reservaServices;
        //private readonly

        public ReservasController(IReservaServices reservaServices)
        {
            _reservaServices = reservaServices;
        }

        //GET: api/Reservas
        [HttpGet]
        public async Task<IEnumerable<ReservaDTO>> GetAync()
        {
            var reserva = await _reservaServices.GetAllReservasAsync();

            if (reserva == null)
            {
                return (IEnumerable<ReservaDTO>)NotFound();
            }
            return reserva;
        }

        [HttpGet("{Id}")]
        public async Task<ActionResult<ReservaDTO>> GetReserva(int Id)
        {
            var reserva = await _reservaServices.GetReservasAsync(Id);
            if (reserva == null)
            {
                return NotFound();
            }
            return reserva;
        }

        //PUT: api/Reservas/1
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{Id}")]
        public async Task<IActionResult> PutReservas(int Id, PutReservaDTO reservas)
        {
            if (Id != reservas.Id)
            {
                return BadRequest();
            }

            await _reservaServices.ModifyReservasAsync(reservas);

            try
            {
                await _reservaServices.SaveReservaAsync();
            }
            catch (DbUpdateConcurrencyException)
            {

                if (!await _reservaServices.ReservaExistAsync(Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return NoContent();
        }

        //POST api/Reservas
        [HttpPost]
        public async Task<IActionResult> PostReservas([FromBody] ReservaDTO reserva)
        {
            await _reservaServices.AddReservasAsync(reserva);
            await _reservaServices.SaveReservaAsync();

            return NoContent();
        }

        [HttpDelete("{Id}")]
        public async Task<IActionResult> DeleteReservas(int Id)
        {
            ReservaDTO reserva = await _reservaServices.GetReservasAsync(Id);
            if (reserva == null)
            {
                return NotFound();
            }

            await _reservaServices.DeleteReservasAsync(reserva.ToReservaDelete());
            await _reservaServices.SaveReservaAsync();

            return NoContent();
        }
    }
}
