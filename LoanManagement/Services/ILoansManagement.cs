using LoanManagement.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoanManagement.Services
{
    public interface ILoansManagement
    {
        List<Customer_Loan> Get();
        Customer_Loan getLoanDetails(int id);
    }
}
