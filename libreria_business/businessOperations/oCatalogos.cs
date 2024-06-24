using libreria_data;
using libreria_publica_Data.Models.catalogs;
using libreria_publica_Data.Models.security;
using libreria_publica_DataLayer.Models.catalogs;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace libreria_business.businessOperations
{
    public class oCatalogos : ControllerBase
    {

        public AplicationDbContext _context { get; set; }
        public oCatalogos(AplicationDbContext context)
        {
            _context = context;
        }

        
        public  List<Personas> GetCatalogoPersonas()
        {
            try
            {
                var data = (from p in _context.Personas
                            select p).ToList();



                if (data != null)
                {
                    return data;
                }
                return new List<Personas>();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + "Ocurrio un error al consultar los datos.");
            }
        }

        public List<Clasificaciones> GetCatalogoClasificaciones()
        {
            try
            {
                var data = (from p in _context.Clasificaciones
                            select p).ToList();



                if (data != null)
                {
                    return data;
                }
                return new List<Clasificaciones>();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + "Ocurrio un error al consultar los datos.");
            }
        }

        public List<Generos> GetCatalogoGeneros()
        {
            try
            {
                var data = (from p in _context.Generos
                            select p).ToList();



                if (data != null)
                {
                    return data;
                }
                return new List<Generos>();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + "Ocurrio un error al consultar los datos.");
            }
        }
    }
}
