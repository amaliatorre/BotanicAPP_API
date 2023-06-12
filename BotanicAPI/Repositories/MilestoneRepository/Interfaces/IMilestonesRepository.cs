using BotanicAPI.Entities.Milestone;

namespace BotanicAPI.Repositories.MilestoneRepository.Interfaces
{
    public interface IMilestonesRepository
    {
        UserMilestonesEntity Create(UserMilestonesEntity userMilestonesEntity);
        MilestoneEntity MilestoneCreate(MilestoneEntity MilestonesEntity);
        List<UserMilestonesEntity> GetAllByUserId(int id);
        MilestoneEntity GetById(int id);
        List<MilestoneEntity> GetMilestoneByRoute(int routeId);
        MilestoneEntity Delete(MilestoneEntity milestoneEntity);
        MilestoneEntity Update(MilestoneEntity milestoneEntity);
        bool GetByMilestoneId(int id);
    }
}
