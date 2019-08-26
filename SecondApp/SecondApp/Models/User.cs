namespace SecondApp.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public byte[] PassworHash { get; set; }

        public byte[] PasswordSalt { get; set; }
    }
}