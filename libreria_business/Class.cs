using libreria_data;
using Microsoft.EntityFrameworkCore;

namespace libreria_business
{
    public class Class
    {
        public Boolean validaUsuario(AplicationDbContext db, int id)
        {
            var user = db.User.FindAsync(id);
            return true;
        }
    }
}
