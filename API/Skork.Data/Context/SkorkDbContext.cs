using Microsoft.EntityFrameworkCore;
using Skork.Domain.Interfaces;
using Skork.Domain.Interfaces.Models;

namespace Skork.Data.Context
{
    public class SkorkDbContext : DbContext
    {
        public DbSet<IAccountInfo> AccountInfos { get; set; }
        public DbSet<IComputerInfo> ComputerInfos { get; set; }
        public DbSet<IProject> Projects { get; set; }
        public DbSet<IProfile> Profiles { get; set; }
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
