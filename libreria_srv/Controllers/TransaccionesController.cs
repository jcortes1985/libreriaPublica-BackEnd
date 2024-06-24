using libreria_business.businessOperations;
using libreria_data;
using libreria_publica_Data.Models.catalogs;
using libreria_publica_DataLayer.Models.operations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace libreria_srv.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransaccionesController : ControllerBase
    {
        private readonly AplicationDbContext _context;

        public TransaccionesController(AplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Transacciones/5
        [HttpGet("{idPersona}")]
        public List<TransaccionesLibro> GetTransacciones(int idPersona)
        {
            oTransacciones trans = new oTransacciones(_context);
            var libro = trans.get(idPersona);

            if (libro == null)
            {
                return new List<TransaccionesLibro>();
            }

            return libro;
        }

        // POST: api/Transacciones
        [HttpPost]
        public List<TransaccionesLibro> PostLibros([FromBody] TransaccionesLibro libro)
        {
            oTransacciones trans = new oTransacciones(_context);
            var data = trans.post(libro);

            if (data == null)
            {
                return new List<TransaccionesLibro>();
            }

            return data;
        }

      
    }
}
