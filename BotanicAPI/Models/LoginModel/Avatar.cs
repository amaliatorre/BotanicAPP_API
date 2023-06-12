using System.ComponentModel.DataAnnotations.Schema;

namespace BotanicAPI.Models.LoginModel
{
    public class Avatar
    {
        public int AvatarId { get; set; }
        public string AvatarName { get; set; }
        public string AvatarLocation { get; set; }
        public string AvatarDescription { get; set; }
    }
}
