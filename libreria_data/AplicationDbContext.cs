using libreria_publica_Data.Models.catalogs;
using libreria_publica_Data.Models.security;
using libreria_publica_DataLayer.Models.catalogs;
using libreria_publica_DataLayer.Models.operations;
using Microsoft.EntityFrameworkCore;


namespace libreria_data
{
    public partial class AplicationDbContext : DbContext
    {
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options) : base(options)
        {

        }
        /*
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // in memory database used for simplicity, change to a real db for production applications
            options.UseInMemoryDatabase("DB_Libreria");
        }
        */
        //public AplicationDbContext(DbContextOptions<AplicationDbContext> options) : base(options)
        //{

        //}

        //Seteo para la Creacion de Tabla
        public DbSet<Clasificaciones> Clasificaciones { get; set; }
        public DbSet<Generos> Generos { get; set; }
        public DbSet<Libros> Libros { get; set; }
        public DbSet<Personas> Personas { get; set; }
        public DbSet<TransaccionesLibro> TransaccionesLibro { get; set; }
        public DbSet<Rol> Rol { get; set; }
        public DbSet<RolesUser> RolesUser { get; set; }
        public DbSet<User> User { get; set; }

     }
}
