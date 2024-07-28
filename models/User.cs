namespace schedule_api.models
{
    public class User
    {
        public Guid Id { get; init; }
        public string Name { get; set; }
        public string? Email { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }

        public User() 
        {
        }

        public User(string name, string email, string password)
        {
            Name = name;
            Email = email;
            Password = password;
            Id = Guid.NewGuid();
            IsActive = true;
        }

    }
}
