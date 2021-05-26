using assetManagement.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace assetManagement.Context
{
    public class MyContext : DbContext
    {
        public MyContext()
        {

        }
        public MyContext(DbContextOptions<MyContext> options) : base(options)
        { }

        public DbSet<Account> Accounts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Condition> Conditions { get; set; }
        public DbSet<ConditionItem> ConditionItems { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<TransactionItem> TransactionItems { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Account-Employee
            modelBuilder.Entity<Account>()
                .HasOne(Account => Account.Employee)
                .WithOne(Employee => Employee.Account)
                .HasForeignKey<Account>(Account => Account.Id);

            //Employee-Role
            modelBuilder.Entity<Employee>()
                .HasOne(Employee => Employee.Role)
                .WithMany(Role=> Role.Employees)

        }
    }
}
