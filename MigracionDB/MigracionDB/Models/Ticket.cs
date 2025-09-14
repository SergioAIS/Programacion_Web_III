namespace MigracionDB.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime UpdatedDate { get; set; } = DateTime.Now;

        public List<Tag> Tag { get; set; } = new List<Tag>();
        public int idAuthor { get; set; }
        public User Author { get; set; }
    }
}
