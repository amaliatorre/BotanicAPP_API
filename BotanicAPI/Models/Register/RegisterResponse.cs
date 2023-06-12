using BotanicAPI.Entities.Profile;

namespace BotanicAPI.Models.Register
{
    public class RegisterResponse
    {
        public string Email { get; set; }
        public List<ProfileEntity> RegisterUser { get; set; }

    }
}
