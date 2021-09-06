using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace EfDatabaseFirst.Ef
{
    public partial class EfEntities : DbContext
    {
        public EfEntities()
            : base("name=EfConnection")
        {
        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<RollCheck> RollChecks { get; set; }
        public virtual DbSet<Transaction> Transactions { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>()
                .Property(e => e.Balance)
                .HasPrecision(38, 2);

            modelBuilder.Entity<Transaction>()
                .Property(e => e.Amount)
                .HasPrecision(38, 2);
        }
    }
}
