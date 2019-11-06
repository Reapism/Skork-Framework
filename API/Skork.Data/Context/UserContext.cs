using Microsoft.EntityFrameworkCore;
using Skork.Domain.Interfaces;

namespace Skork.Data.Context
{
    public class UserContext : DbContext
    {
        public DbSet<IUser> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(SkorkConnection.GetConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IUser>().HasIndex(u => new { u.Email });
            base.OnModelCreating(modelBuilder);
        }
    }
}
