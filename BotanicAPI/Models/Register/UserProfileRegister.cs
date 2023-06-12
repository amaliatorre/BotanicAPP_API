namespace BotanicAPI.Models.Register
{
    public class UserProfileRegister
    {
        public string? Dni { get; set; } = string.Empty;
        public string? Email { get; set; } = string.Empty;
        public string? Password { get; set; } = string.Empty;
        public string? Surname { get; set; } = string.Empty;
        //public List<RegisterProfile>? RegisterProfile { get; set; }
        public object? RegisterProfile { get; set; }
    }
}
