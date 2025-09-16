using Microsoft.EntityFrameworkCore;

namespace MVC1.Models.Data
{
    public class HelpDeskDBContext:DbContext
    {
        public HelpDeskDBContext(DbContextOptions<HelpDeskDBContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
    }
}
