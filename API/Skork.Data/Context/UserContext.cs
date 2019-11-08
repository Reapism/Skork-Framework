using Microsoft.EntityFrameworkCore;
using Skork.Domain.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;

namespace Skork.Data.Context
{
    [Table("Users")]
    public class UserContext : DbContext
    {
        public DbSet<IUser> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer(SkorkConnection.GetConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IUser>().HasIndex(u => new { u.Email });
            base.OnModelCreating(modelBuilder);
        }   
    }
}
