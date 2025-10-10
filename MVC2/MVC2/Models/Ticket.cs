namespace MVC2.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;

        // Clave foránea
        public int UserId { get; set; }

        // Navegación
        public User User { get; set; } = null!;
    }
}
