using BarNegro.Users.Application.Dtos;
using BarNegro.Users.Application.Interfaces;
using BarNegro.Users.Domain.Interfaces;

namespace BarNegro.Users.Application.UseCase
{
    internal class UpdateUser : IUpdateUser
    {
        private readonly IUserRepository _userRepository;

        public UpdateUser(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        UserDTO IUpdateUser.UpdateUser(string id, string name, string lastName)
        {
            var user = _userRepository.GetById(id);

            user.Name = name;
            user.LastName = lastName;

            _userRepository.UpdateUser(user);

            return new UserDTO(user.UserId,
                               user.Name,
                               user.LastName,
                               user.CreatedDate,
                               user.Rol);
        }
    }
}
