namespace BotanicAPI.Models.Register
{
    public class RegisterUser
    {
        public string? Dni { get; set; } = string.Empty;
        public string? Email { get; set; } = string.Empty;
        public string? Password { get; set; } = string.Empty;
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public string Gender { get; set; }
        public string? Surname { get; set; } = string.Empty;

    }
}
