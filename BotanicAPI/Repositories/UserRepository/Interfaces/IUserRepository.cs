using BotanicAPI.Entities.Milestone;
using BotanicAPI.Entities.User;
using BotanicAPI.Entities.User;

namespace BotanicAPI.Repositories.UserRepository.Interfaces
{
    public interface IUserRepository
    {
        UserEntity Create(UserEntity userEntity);
        UserEntity Login(UserEntity userEntity);
        UserMilestonesEntity GetUserMilestoneById(int id, int userId);
    }
}
