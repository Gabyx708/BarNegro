using BarNegro.Users.Application.Interfaces;
using BarNegro.Users.Domain.Interfaces;

namespace BarNegro.Users.Application.UseCase
{
    public class DesactivateUser : IDesactivateUser
    {
        private readonly IUserRepository _userRepository;

        public DesactivateUser(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        bool IDesactivateUser.DesactivateUser(string userId)
        {
            var user = _userRepository.GetById(userId);

            user.IsActivate = false;

            return _userRepository.UpdateUser(user);
        }
    }
}
