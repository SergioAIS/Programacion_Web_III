using Microsoft.EntityFrameworkCore;
namespace ActividadAsincrona2.Models.Data
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Post> Posts   { get; set; }
    }
}
