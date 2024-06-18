using libreria_publica_Data.Models.security;

namespace libreria_data
{
    public interface ILibreriaRepositorio
    {
        public List<User> GetUsers();
    }
}
