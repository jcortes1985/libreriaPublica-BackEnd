using libreria_business.classAbstract;
using libreria_data;
using libreria_publica_Data.Models.catalogs;
using libreria_publica_DataLayer.Models.operations;

namespace libreria_business.businessOperations
{
    public class oTransacciones : aTransacciones
    {
        public AplicationDbContext _context { get; set; }
        public oTransacciones(AplicationDbContext context)
        {
            _context = context;
        }

        public override List<TransaccionesLibro> post(TransaccionesLibro transaccion)
        {
            try
            {
                transaccion.FechaTransaccion = DateTime.Now;
                _context.TransaccionesLibro.Add(transaccion);
                _context.SaveChanges();

                return get(transaccion.idPersona);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + "Ocurrio un error al guardar los datos.");
            }
        
    }

        public override List<TransaccionesLibro> get(int idPersona)
        {
            try
            {
                var data = (from p in _context.TransaccionesLibro
                            where p.idPersona == idPersona
                            select p
                            ).ToList();

                if (data != null)
                {
                    return data;
                }
                return new List<TransaccionesLibro>();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + "Ocurrio un error al consultar los datos.");
            }
        }
    }
}
