using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using libreria_data;
using libreria_publica_Data.Models.catalogs;
using libreria_business.businessObjects;
using libreria_publica_Data.Models.security;
using libreria_business.businessOperations;
using libreria_business.classAbstract;
using Humanizer;
using NuGet.Protocol.Core.Types;

namespace libreria_srv.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LibrosController : ControllerBase
    {
        private readonly AplicationDbContext _context;

        public LibrosController(AplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Libros
        [HttpGet]
        public List<Libros> GetLibros()
        {
            oLibros libros = new oLibros(_context);
            var libro = libros.get();

            if (libro == null)
            {
                return new List<Libros>();
            }

            return libro;
        }

        // GET: api/Libros/5
        [HttpGet("{id}")]
        public Libros GetLibros(int id)
        {
            oLibros libros = new oLibros(_context);
            var libro = libros.get(id);

            if (libro == null)
            {
                return new Libros();
            }

            return libro;
        }

        // PUT: api/Libros/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut]
        public List<Libros> PutLibros(Libros libros)
        {
            oLibros libro = new oLibros(_context);
            var data = libro.put(libros);

            if (libro == null)
            {
                return new List<Libros>();
            }

            return data;


        }

        // POST: api/Libros
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public List<Libros> PostLibros([FromBody]Libros libro)
        {
            oLibros libros = new oLibros(_context);
            var data = libros.post(libro);

            if (data == null)
            {
                return new List<Libros>();
            }

            return data;
        }

        // DELETE: api/Libros/5
        [HttpDelete("{id}")]
        public List<Libros> DeleteLibros(int id)
        {
            oLibros libro = new oLibros(_context);
            var data = libro.delete(id);

            if (libro == null)
            {
                return new List<Libros>();
            }

            return data;
        }

        
        private bool LibrosExists(int id)
        {
            return _context.Libros.Any(e => e.idLibro == id);
        }
    }
}
