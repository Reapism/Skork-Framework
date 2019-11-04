using Microsoft.EntityFrameworkCore;
using Skork.Domain.Interfaces.Models;

namespace Skork.Data.Context
{
    public class ProfileContext : DbContext
    {
        public DbSet<IProfile> Profiles { get; set; }
    }
}
