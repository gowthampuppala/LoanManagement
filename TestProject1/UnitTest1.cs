using LoanManagement.Controllers;
using LoanManagement.Models.Entities;
using LoanManagement.Services;
using Microsoft.AspNetCore.Mvc;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using Xunit;

namespace TestProject1
{
    public class UnitTest1
    {
        public Mock<ILoansManagement> mock = new Mock<ILoansManagement>();
        [Fact]
        public void Test_ValidData_Get()
        {
            List<Customer_Loan> result = new List<Customer_Loan>();
            result.Add(new Customer_Loan()
            {
                Id = 2,
                LoanProductId = 3,
                CustomerId = 4,
                LoanPrincipal = 5,
                Tenure = 6,
                Interest = 7,
                EMI = 90, 
                CollateralId = 3

            });
            mock.Setup(p => p.Get()).Returns(result);
            DataController controller = new DataController(mock.Object);
            Microsoft.AspNetCore.Mvc.ActionResult<List<Customer_Loan>> result1 = controller.Get();
            NUnit.Framework.Assert.True(result.Equals(result1.Value));

        }
        [Fact]
        public void Test_ValidData_GetById()
        {
            var result = new Customer_Loan()
            {
                Id = 1,
                LoanProductId = 3,
                CustomerId = 4,
                LoanPrincipal = 5,
                Tenure = 6,
                Interest = 7,
                EMI = 90,
                CollateralId = 3

            };
            mock.Setup(p => p.getLoanDetails(1)).Returns(result);
            var controller = new DataController(mock.Object);
            var result1 =  controller.getLoanDetails(1);
            NUnit.Framework.Assert.True(result.Equals(result1.Value));
        }
        [Fact]
        public void Test_InValidData_GetById()
        {
            var result = new Customer_Loan()
            {
                Id = 1,
                LoanProductId = 3,
                CustomerId = 4,
                LoanPrincipal = 5,
                Tenure = 6,
                Interest = 7,
                EMI = 90,
                CollateralId = 3
            };
            mock.Setup(p => p.getLoanDetails(1)).Returns(result);
            var controller = new DataController(mock.Object);
            var result1 = controller.getLoanDetails(2);
            NUnit.Framework.Assert.False(result.Equals(result1.Value));
        }

        [Fact]
        public void Test_NotFoundData_GetById()
        {
            var result = new Customer_Loan()
            {


            };
            mock.Setup(p => p.getLoanDetails(55)).Returns(result);
            var controller = new DataController(mock.Object);
            var result1 = controller.getLoanDetails(55);
            NUnit.Framework.Assert.True(result.Equals(result1.Value));
        }

    }
}
