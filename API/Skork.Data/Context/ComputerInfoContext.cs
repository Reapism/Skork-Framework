using Microsoft.EntityFrameworkCore;
using Skork.Domain.Interfaces;

namespace Skork.Data.Context
{
    public class ComputerInfoContext : DbContext
    {
        public DbSet<IComputerInfo> ComputerInfos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(SkorkConnection.GetConnectionString);
            base.OnConfiguring(optionsBuilder);
        }
    }
}
