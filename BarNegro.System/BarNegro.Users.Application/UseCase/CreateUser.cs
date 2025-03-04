using BarNegro.Users.Application.Dtos;
using BarNegro.Users.Application.Interfaces;
using BarNegro.Users.Domain.Entities;
using BarNegro.Users.Domain.Enums;
using BarNegro.Users.Domain.Interfaces;

namespace BarNegro.Users.Application.UseCase
{
    public class CreateUser : ICreateUser
    {
        private readonly IUserRepository _userRepository;

        public CreateUser(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public UserDTO CreateWaiter(string id, string name, string lastName)
        {
            if (CheckIfExist(id))
            {
                throw new InvalidOperationException("this user exist!");
            }

            string encrypthPassword = EncryptPassword(id);
            var user = new User(id, name, lastName,encrypthPassword,UserRol.Waiter);

            _userRepository.InsertUser(user);

            return new UserDTO(user.Name,
                                user.Name,
                                user.LastName,
                                user.CreatedDate,
                                user.Rol);
        }

        private bool CheckIfExist(string id)
        {
            return _userRepository.GetById(id) != null;
        }

        private string EncryptPassword(string plainPassword)
        {
            return "";
        }
    }
}
