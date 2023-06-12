using BotanicAPI.Entities.Milestone;

namespace BotanicAPI.Models.RouteMilestone
{
    public class RouteMilestone
    {
        public string Name { get; set; } = string.Empty;
        public List<MilestoneEntity> Milestone { get; set; }        
    }
}
