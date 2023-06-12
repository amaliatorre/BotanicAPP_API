using BotanicAPI.Entities.Avatar;
using BotanicAPI.Entities.Color;
using BotanicAPI.Entities.Profile;
using BotanicAPI.Models.LoginModel;

namespace BotanicAPI.Repositories.ProfileRepository.Interfaces
{
    public interface IProfileRepository
    {
        ProfileEntity Create(ProfileEntity profileEntity);
        List<ProfileEntity> GetAllByUserId(int id);
    }
}
