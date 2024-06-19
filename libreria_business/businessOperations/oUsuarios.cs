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
        public User GetUser()
        {
            try
            {
                var data = _context.User.Find();
                if (data != null)
                {
                    return data;
                }
                return new User();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + "Ocurrio un error al consultar los datos.");
            }
        }
        public User GetUser(int id)
        {
            try
            {
                var data = _context.User.Find(id);
                if (data != null)
                {
                    return data;
                }
                return new User();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + "Ocurrio un error al consultar los datos.");
            }
        }
    }
}
