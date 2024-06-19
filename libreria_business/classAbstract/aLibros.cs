using libreria_publica_Data.Models.catalogs;

namespace libreria_business.classAbstract
{
    public abstract class aLibros
    {
        public abstract List<Libros> get();
        public abstract Libros get(int id);
        public abstract List<Libros> post(Libros libro);
        public abstract List<Libros> put(Libros libro);
        public abstract List<Libros> delete(int id);

    }
}
