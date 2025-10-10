using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MVC4.Models.Data
{
    public class MyDBContext : IdentityDbContext<IdentityUser>
    {
        public MyDBContext(DbContextOptions<MyDBContext> options) : base(options)
        {

        }
        public DbSet<Tag> Tags { get; set; }
    }
}
