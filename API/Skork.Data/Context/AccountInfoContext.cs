using Microsoft.EntityFrameworkCore;
using Skork.Domain.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;

namespace Skork.Data.Context
{
    [Table("AccountInfo")]
    public class AccountInfoContext : DbContext
    {
        public DbSet<IAccountInfo> AccountInfos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer(SkorkConnection.GetConnectionString);
        }
    }
}
