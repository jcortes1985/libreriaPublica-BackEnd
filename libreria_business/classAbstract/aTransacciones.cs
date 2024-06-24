using libreria_publica_Data.Models.catalogs;
using libreria_publica_DataLayer.Models.operations;

namespace libreria_business.classAbstract
{
    public abstract class aTransacciones
    {
        public abstract List<TransaccionesLibro> get(int idPersona);
        public abstract List<TransaccionesLibro> post(TransaccionesLibro libro);
    }
}
