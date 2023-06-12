using System.ComponentModel.DataAnnotations.Schema;

namespace BotanicAPI.Entities.User
{
    [Table("User")]
    public class UserEntity
    {
        public int? Id { get; set; }
        public string? Email { get; set; } = string.Empty;
        public string? Password { get; set; } = string.Empty;
        public string? Dni { get; set; } = string.Empty;
        public string? Surname { get; set; } = string.Empty;

    }
}
