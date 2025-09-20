namespace ActividadAsincrona2.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
        public DateOnly CreationDate { get; set; }
        public string Author { get; set; } = string.Empty;
    }
}
