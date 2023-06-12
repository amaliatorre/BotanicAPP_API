using BotanicAPI.Entities.Profile;
using BotanicAPI.Models.LoginModel;
using BotanicAPI.Models.Register;

namespace BotanicAPI.Services.Interfaces
{
    public interface IUserService
    {
        RegisterResponse CreateAsync(UserProfileRegister user);
        LoginResponse LoginAsync(Login login);
        ProfileEntity CreateProfileAsync(ProfileEntity profile);
    }
}
