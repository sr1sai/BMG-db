using BMG_db.Models;
using Microsoft.EntityFrameworkCore;

namespace BMG_db.Data
{
    public class BankDBContext : DbContext
    {
        public BankDBContext(DbContextOptions<BankDBContext> options) : base(options)
        {
        }

        public DbSet<Login> Logins { get; set; }
        public DbSet<Locker> Lockers { get; set; }
        public DbSet<Loan> Loans { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Branch> Branches { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql("Server=localhost;Database=bmg;User=root;Password=30012003;", new MySqlServerVersion(new Version(8, 0, 21)));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Specify precision and scale for the decimal property 'amount' on the 'Loan' entity
            modelBuilder.Entity<Loan>()
                .Property(l => l.amount)
                .HasColumnType("decimal(18,2)");

            // Additional configuration if needed
        }
    }
}
