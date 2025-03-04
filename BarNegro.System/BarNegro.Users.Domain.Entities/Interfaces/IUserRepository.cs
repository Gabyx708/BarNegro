using BarNegro.Users.Domain.Entities;

namespace BarNegro.Users.Domain.Interfaces
{
    public interface IUserRepository
    {
        User? GetById(string userId);
        bool InsertUser(User user);
        bool UpdateUser(User user);
        bool DeleteUser(string userId);
        List<User> GetAllUsers();
    }
}
