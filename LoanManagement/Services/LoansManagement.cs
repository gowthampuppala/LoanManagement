using LoanManagement.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoanManagement.Services
{
    public class LoansManagement : ILoansManagement
    {
        private readonly CustomerDbContext _cusDbContext;
        public LoansManagement(CustomerDbContext appDbContext)
        {
            _cusDbContext = appDbContext;
        }
        public List<Customer_Loan> Get()
        {
            List<Customer_Loan> custloan = _cusDbContext.Customer_Loans.ToList();
            return custloan;
        }
        public Customer_Loan getLoanDetails(int id)
        {
            Customer_Loan singlecust = _cusDbContext.Customer_Loans.Where(s => s.Id == id).SingleOrDefault();
            return singlecust;
        }

    }
}
