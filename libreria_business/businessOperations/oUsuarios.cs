using libreria_business.transactions;
using libreria_data;
using libreria_publica_Data.Models.security;
using Microsoft.EntityFrameworkCore;

namespace libreria_business.businessObjects
{
    public class oUsuarios
    {
        public AplicationDbContext _context { get; set; }
        public oUsuarios(AplicationDbContext context)
        {
            _context = context;
        }
        public List<User> GetUser()
        {
            try
            {
                var data = (from p in _context.User
                            select p).ToList();

                if (data != null)
                {
                    return data;
                }
                return new List<User>();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + "Ocurrio un error al consultar los datos.");
            }
        }
        public List<User> GetUser(string email, string contrasena)
        {
            try
            {
                var data = (from p in _context.User
                            where p.email == email && p.password == contrasena 
                            select p).ToList();

                if (data != null)
                {
                    return data;
                }
                return new List<User>();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + "Ocurrio un error al consultar los datos.");
            }
        }
    }
}
