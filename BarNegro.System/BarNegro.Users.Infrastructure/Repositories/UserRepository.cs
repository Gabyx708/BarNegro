using BarNegro.Users.Domain.Entities;
using BarNegro.Users.Domain.Interfaces;
using BarNegro.Users.Infrastructure.Context;

namespace BarNegro.Users.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly UserContext _context;

        public UserRepository(UserContext context)
        {
            _context = context;
        }

        public bool DeleteUser(string userId)
        {
            throw new NotImplementedException();
        }

        public List<User> GetAllUsers()
        {
            return _context.Users.ToList();
        }

        public User? GetById(string userId)
        {
            return _context.Users.Find(userId);
        }

        public bool InsertUser(User user)
        {
            _context.Users.Add(user);
            return _context.SaveChanges() > 0;
        }

        public bool UpdateUser(User user)
        {
            var existingUser = _context.Users.Find(user.UserId);
            if (existingUser == null) return false;

            _context.Entry(existingUser).CurrentValues.SetValues(user);
            return _context.SaveChanges() > 0;
        }
    }
}
