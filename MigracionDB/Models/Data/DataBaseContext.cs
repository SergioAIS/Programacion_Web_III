using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using MigracionDB.Models;

namespace MigracionDB.Models.Data
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Tag> Tags { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Ticket> Tickets { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Tag>()
                .HasMany(t => t.Ticket)
                .WithMany(t => t.Tag);

            modelBuilder.Entity<Ticket>()
                .HasOne(t => t.Author)
                .WithMany(u => u.Tickets)
                .HasForeignKey(t => t.idAuthor)
                .OnDelete(DeleteBehavior.Cascade);
        }
        }
}
