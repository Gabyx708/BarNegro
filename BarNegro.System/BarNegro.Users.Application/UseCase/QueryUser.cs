using BarNegro.Users.Application.Dtos;
using BarNegro.Users.Application.Interfaces;
using BarNegro.Users.Domain.Entities;
using BarNegro.Users.Domain.Interfaces;

namespace BarNegro.Users.Application.UseCase
{
    public class QueryUser : IQueryUser
    {
        private readonly IUserRepository _userRepository;

        public QueryUser(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public UserDTO GetUserById(string userId)
        {
            var user = _userRepository.GetById(userId);

            return MapToDto(user);
        }

        public List<UserDTO> GetUsers()
        {
            return _userRepository.GetAllUsers()
                                  .Select(u => MapToDto(u))
                                  .ToList();
        }

        private UserDTO MapToDto(User user)
        {
            return new UserDTO(user.UserId,
                               user.Name,
                               user.LastName,
                               user.CreatedDate,
                               user.Rol);
        }
    }
}
