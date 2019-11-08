using Microsoft.EntityFrameworkCore;
using Skork.Domain.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;

namespace Skork.Data.Context
{
    [Table("Projects")]
    public class ProjectContext : DbContext
    {
        public DbSet<IProject> Projects { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer(SkorkConnection.GetConnectionString);
        }

    }
}
