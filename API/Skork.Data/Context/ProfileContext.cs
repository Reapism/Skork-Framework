using Microsoft.EntityFrameworkCore;
using Skork.Domain.Interfaces.Models;

namespace Skork.Data.Context
{
    public class ProfileContext : DbContext
    {
        public DbSet<IProfile> Profiles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
