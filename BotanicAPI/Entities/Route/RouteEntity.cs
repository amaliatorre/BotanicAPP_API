using System.ComponentModel.DataAnnotations.Schema;

namespace BotanicAPI.Entities.Route
{
    [Table("Routes")]
    public class RouteEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
