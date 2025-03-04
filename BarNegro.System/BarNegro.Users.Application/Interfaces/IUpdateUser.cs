using BarNegro.Users.Application.Dtos;

namespace BarNegro.Users.Application.Interfaces
{
    public interface IUpdateUser
    {
        UserDTO UpdateUser(string id, string name, string lastName);
    }
}
