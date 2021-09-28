using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoanManagement.Models.Entities
{
    public class CustomerDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer(@"Data Source=KEERTHANA;Initial Catalog=CustomerDB;Integrated Security=True");
        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Customer_Loan> Customer_Loans { get; set; }
        public DbSet<Loan> Loans { get; set; }

    }

}
