using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Models
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> context)
            : base(context)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"data source=.\SQLEXPRESS;initial catalog=MyDb;integrated security=True;MultipleActiveResultSets=True;");
            }
        }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Account> Orders { get; set; }
        public DbSet<Customer> Customers { get; set; }


    }
}
