using BotanicAPI.Entities.Avatar;
using BotanicAPI.Entities.Color;
using BotanicAPI.Entities.Milestone;
using BotanicAPI.Models.Register;

namespace BotanicAPI.Models.LoginModel
{
    public class LoginResponse
    {
        public RegisterResponse registerResponse { get; set; }
        public List<UserMilestonesEntity> userMilestonesEntities { get; set; }
    }
}
