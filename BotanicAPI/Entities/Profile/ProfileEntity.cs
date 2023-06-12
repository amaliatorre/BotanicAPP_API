using BotanicAPI.Entities.Avatar;
using BotanicAPI.Entities.Color;
using System.ComponentModel.DataAnnotations.Schema;

namespace BotanicAPI.Entities.Profile
{
    [Table("Profile")]
    public class ProfileEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; }
        public DateTime Birthday { get; set; } 
        public string Gender { get; set; }
        public bool Active { get; set; }
        public string Rol { get; set; }
        public int ColorId { get; set; }
        [NotMapped]
        public ColorEntity? Color { get; set; }
        public int AvatarId { get; set; }
        [NotMapped]
        public AvatarEntity? Avatar { get; set; }

    }
}
