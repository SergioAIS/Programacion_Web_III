namespace MigracionDB.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; }
        public string Password { get; set; }
        public string UserName { get; set; }

        public List<Ticket> Tickets { get; set; } = new List<Ticket>();
    }
}
