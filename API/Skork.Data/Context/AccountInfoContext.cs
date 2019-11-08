using Microsoft.EntityFrameworkCore;
using Skork.Domain.Interfaces;

namespace Skork.Data.Context
{
    public class AccountInfoContext : DbContext
    {
        public DbSet<IAccountInfo> AccountInfos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(SkorkConnection.GetConnectionString);
            base.OnConfiguring(optionsBuilder);
        }
    }
}
