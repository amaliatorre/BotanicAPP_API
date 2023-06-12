using System.ComponentModel.DataAnnotations.Schema;

namespace BotanicAPI.Entities.Milestone
{
    [Table("Milestone")]
    public class MilestoneEntity
    {
        public int Id { get; set; }
        public int RouteId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Info { get; set; }
        [NotMapped]
        public bool? Completed { get; set; } = false;
    }
}
