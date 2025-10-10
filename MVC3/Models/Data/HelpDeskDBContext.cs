using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MVC3.Models.Data
{
    public class HelpDeskDBContext: IdentityDbContext<IdentityUser>
    {
        public HelpDeskDBContext(DbContextOptions<HelpDeskDBContext> options) : base(options)
        {
        }
        
        public DbSet<User> Users { get; set; }
    }
}
