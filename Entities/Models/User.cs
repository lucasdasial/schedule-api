using schedule_api.Entities.Enums;

namespace schedule_api.Entities.Models
{
    public class User(string name, string email, string password)
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; } = name;
        public string? Email { get; set; } = email;
        public string Password { get; set; } = password;
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public Plan Plan { get; set; } = new();
    }
}
