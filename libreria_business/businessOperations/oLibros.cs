using Azure;
using libreria_business.classAbstract;
using libreria_business.errorsControl;
using libreria_business.transactions;
using libreria_data;
using libreria_publica_Data.Models.catalogs;
using libreria_publica_Data.Models.security;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace libreria_business.businessOperations
{
    public class oLibros : aLibros
    {
        public AplicationDbContext _context { get; set; }
        public oLibros(AplicationDbContext context)
        {
            _context = context;
        }
        public override List<Libros> get()
        {
            try
            {
                var data = (from p in _context.Libros
                            join c in _context.Clasificaciones on p.idClasificacion equals c.idClasificacion
                            join g in _context.Generos on p.idGenero equals g.idGenero
                            select p).ToList();
                            

                if (data != null)
                {
                    return data;
                }
                return new List<Libros>();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + "Ocurrio un error al consultar los datos.");
            }
        }

        public override Libros get(int id)
        {
            try
            {
                var data = _context.Libros.Find(id);
                if (data != null)
                {
                    return data;
                }
                return new Libros();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + "Ocurrio un error al consultar los datos.");
            }
        }

        public override List<Libros> post(Libros libro)
        {
            try
            {
                _context.Libros.Add(libro);
                _context.SaveChanges();

                return get();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + "Ocurrio un error al guardar los datos.");
            }
        }

        public override List<Libros> put(Libros libro)
        {

            try
            {
                _context.Entry(libro).State = EntityState.Modified;
                _context.SaveChanges();

                return get();
            }
            catch(Exception ex) 
            {
                throw new Exception(ex.Message + "Ocurrio un error al actualizar el registro.");
            }
        }

        public override List<Libros> delete(int id)
        {
            try
            {
                var libro = _context.Libros.Find(id);

                if(libro != null)
                {
                    _context.Libros.Remove(libro);
                    _context.SaveChanges();
                }
                return get();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + "Ocurrio un error al eliminar el registro.");
            }

        }
    }
}
