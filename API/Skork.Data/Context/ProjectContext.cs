using Microsoft.EntityFrameworkCore;
using Skork.Domain.Interfaces;

namespace Skork.Data.Context
{
    public class ProjectContext : DbContext
    {
        public DbSet<IProject> Projects { get; set; }
    }
}
