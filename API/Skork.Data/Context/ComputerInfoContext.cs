using Microsoft.EntityFrameworkCore;
using Skork.Domain.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;

namespace Skork.Data.Context
{
    [Table("ComputerInfo")]
    public class ComputerInfoContext : DbContext
    {
        public DbSet<IComputerInfo> ComputerInfos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer(SkorkConnection.GetConnectionString);
        }
    }
}
