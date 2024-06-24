using libreria_business.businessOperations;
using libreria_business.classAbstract;
using libreria_data;
using libreria_publica_Data.Models.catalogs;
using libreria_publica_DataLayer.Models.catalogs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using static System.Runtime.InteropServices.JavaScript.JSType;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace libreria_srv.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatalogosController : ControllerBase
    { 
         private readonly AplicationDbContext _context;

        public CatalogosController(AplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("GetCatPersonas")]
        public List<Personas> GetCatPersonas()
        {
            oCatalogos catalogos = new oCatalogos(_context);
            var data = catalogos.GetCatalogoPersonas();

            if (data == null)
            {
                return new List<Personas>();
            }

            return data;
          
        }

        [HttpGet]
        [Route("GetCatClasificaciones")]
        public List<Clasificaciones> GetCatClasificaciones()
        {
            oCatalogos catalogos = new oCatalogos(_context);
            var data = catalogos.GetCatalogoClasificaciones();

            if (data == null)
            {
                return new List<Clasificaciones>();
            }

            return data;

        }

        [HttpGet]
        [Route("GetCatGeneros")]
        public List<Generos> GetCatGeneros()
        {
            oCatalogos catalogos = new oCatalogos(_context);
            var data = catalogos.GetCatalogoGeneros();

            if (data == null)
            {
                return new List<Generos>();
            }

            return data;

        }

        [HttpGet]
        [Route("GetCatLibros")]
        public List<Libros> GetCatLibros()
        {
            oLibros libros = new oLibros(_context);
            var libro = libros.get();
            
            if (libro == null)
            {
                return new List<Libros>();
            }
            return libro;
        }
    }
}
