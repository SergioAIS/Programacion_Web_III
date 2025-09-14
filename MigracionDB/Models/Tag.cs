namespace MigracionDB.Models
{
    public class Tag
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        public List<Ticket> Ticket { get; set; } = new List<Ticket>();
    }
}
