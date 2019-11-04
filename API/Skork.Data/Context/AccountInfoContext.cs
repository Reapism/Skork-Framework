using Microsoft.EntityFrameworkCore;
using Skork.Domain.Interfaces;

namespace Skork.Data.Context
{
    public class AccountInfoContext : DbContext
    {
        public DbSet<IAccountInfo> AccountInfos { get; set; }
    }
}
