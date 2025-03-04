using BarNegro.Users.Application.Dtos;

namespace BarNegro.Users.Application.Interfaces
{
    public interface ICreateUser
    {
        UserDTO CreateWaiter(string id, string name, string lastName);
    }
}
