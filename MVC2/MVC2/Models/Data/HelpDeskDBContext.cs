using Microsoft.EntityFrameworkCore;
namespace MVC2.Models.Data
{
    public class HelpDeskDBContext : DbContext
    {
        public HelpDeskDBContext(DbContextOptions<HelpDeskDBContext> options) : base(options)
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
    }
}
