
using System.ComponentModel.DataAnnotations.Schema;

namespace BotanicAPI.Models.LoginModel
{
    public class Color
    {
        public int BorderColorId { get; set; }
        public string BorderColorName { get; set; }
        public string BorderColorCode { get; set; }
        public string BorderColorDescription { get; set; }
    }
}
