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
    }
}
