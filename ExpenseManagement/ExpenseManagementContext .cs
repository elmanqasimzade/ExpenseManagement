using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;


namespace ExpenseManagement
{
    public class ExpenseManagementContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Expense> Expenses { get; set; }
        public DbSet<ExpenseType> ExpenseTypes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = System.Configuration.ConfigurationManager
                .ConnectionStrings["ExpenseDbConnection"].ConnectionString;
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }

    public class Expense
    {
        public int Id { get; set; }
        public int ExpenseTypeId { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public ExpenseType ExpenseType { get; set; }
    }

    public class ExpenseType
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

}
