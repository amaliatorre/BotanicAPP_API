using System.ComponentModel.DataAnnotations.Schema;

namespace BotanicAPI.Entities.Milestone
{
    [Table("UserMilestones")]
    public class UserMilestonesEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int MilestoneId { get; set; }
        public bool Completed { get; set; }
    }
}
