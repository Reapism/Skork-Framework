using Skork.Data.Interfaces;
using Skork.Data.Models;
using System;
using System.Data.Entity;
using System.Linq;

namespace Skork.Data.Entities
{
    public class UserContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public UserContext()
        {
            Users.Add(new User());
        }

        /// <summary>
        /// When creating a migration, adding this line will tell the
        /// EF to not update by adding a column with IsDirty.
        /// This is a field that we want only on the client side
        /// and dont want to persist it in the DB.
        /// </summary>
        /// <param name="modelBuilder">The <see cref="DbModelBuilder"/> to use.</param>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Types().Configure(t => t.Ignore("IsModified"));
            base.OnModelCreating(modelBuilder);
        }

        public override int SaveChanges()
        {
            return SaveChangesHelper();
        }

        private int SaveChangesHelper()
        {
            // Give me everything its tracking that implements 
            // IModificationHistory and is known to be modified or added.
            foreach (IModification history in ChangeTracker.Entries()
                .Where(e => e.Entity is IModification && (e.State == EntityState.Added ||
                e.State == EntityState.Modified))
                .Select(e => e.Entity as IModification))
            {
                history.DateModified = DateTime.Now;
                if (history.DateCreated == DateTime.MinValue)
                {
                    history.DateCreated = DateTime.Now;
                }
            }

            int result = base.SaveChanges();

            foreach (IModification history in ChangeTracker.Entries()
                .Where(e => e.Entity is IModification)
                .Select(e => e.Entity as IModification))
            {
                history.IsModified = false;
            }
            return result;
        }
    }
}
