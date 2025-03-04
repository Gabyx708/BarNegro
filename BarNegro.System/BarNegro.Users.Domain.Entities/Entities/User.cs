using BarNegro.Users.Domain.Enums;

namespace BarNegro.Users.Domain.Entities
{
    public class User
    {
        public string UserId { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public DateTime CreatedDate { get; set; }
        public string Password { get; set; } = string.Empty;
        public UserRol Rol { get; set; }
        public bool IsActivate { get; set; }

        public User(string userId, string name, string lastName, string encryptPassword, UserRol rol)
        {
            UserId = userId;
            Name = name;
            LastName = lastName;
            Password = encryptPassword;
            CreatedDate = DateTime.Now;
            Rol = rol;
            IsActivate = true;
        }

        public User()
        {

        }
    }
}
