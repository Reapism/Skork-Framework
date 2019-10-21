using Microsoft.EntityFrameworkCore;
using Skork.Domain.Models;

namespace Skork.Data.Context
{
    public class UserContext : DbContext
    {
        public DbSet<User> Users { get; set; }
    }
}
