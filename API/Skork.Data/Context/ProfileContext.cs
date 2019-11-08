using Microsoft.EntityFrameworkCore;
using Skork.Domain.Interfaces.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace Skork.Data.Context
{
    [Table("Profiles")]
    public class ProfileContext : DbContext
    {
        public DbSet<IProfile> Profiles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer(SkorkConnection.GetConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
