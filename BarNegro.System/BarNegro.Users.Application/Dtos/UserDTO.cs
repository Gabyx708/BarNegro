using BarNegro.Users.Domain.Enums;

namespace BarNegro.Users.Application.Dtos
{
    public record UserDTO
    {
        public UserDTO(string id, string name, string lastName, DateTime createdDate, UserRol rol)
        {
            Id = id;
            Name = name;
            LastName = lastName;
            CreatedDate = createdDate;
            Rol = rol;
        }

        public string Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime CreatedDate { get; set; }
        public UserRol Rol { get; set; }
    }

}
