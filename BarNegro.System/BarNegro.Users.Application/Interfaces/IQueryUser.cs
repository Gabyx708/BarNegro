using BarNegro.Users.Application.Dtos;

namespace BarNegro.Users.Application.Interfaces
{
    public interface IQueryUser
    {
        List<UserDTO> GetUsers();
        UserDTO GetUserById(string userId);
    }
}
