using LoanManagement.Models.Entities;
using LoanManagement.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Graph;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LoanManagement.Controllers
{
    

    [Route("api/[controller]")]
    [ApiController]
    public class DataController : ControllerBase
    {


        private readonly ILoansManagement _LMService;

        static readonly log4net.ILog _log4net = log4net.LogManager.GetLogger(typeof(DataController));

        public DataController(ILoansManagement LoanService)
        {
            _LMService = LoanService;
        }



        ///<summary>
        /// Get all details of customer loan
        /// </summary>
        /// <return>
        /// Returns list of Customers_loan
        /// </return>
        /// <remarks>
        /// Sample request
        /// GET /api/Data
        /// </remarks>
        /// <response code="200">Returns Customers_loan</response>
        // GET: api/<DataController>
        [HttpGet]
       
        public  ActionResult<List<Customer_Loan>> Get()
        {
            
            _log4net.Info("Get All initiated!");
            List<Customer_Loan> customer_Loans = _LMService.Get();
            _log4net.Info("Returned List of customer loans");
            return (customer_Loans);
        }

        ///<summary>
        /// Get all details of customer loan by ID
        /// </summary>
        /// <return>
        /// Returns a Customer object by id
        /// </return>
        /// <remarks>
        /// Sample request
        /// GET /api/Data/{id}
        /// </remarks>
        /// <response code="200">Returns Customer by ID</response>
        // GET api/<DataController>/5
        [HttpGet("{id}")]
        public ActionResult<Customer_Loan> getLoanDetails(int id)
        {
            Customer_Loan custloan = _LMService.getLoanDetails(id);

            if (custloan != null)
            {
                _log4net.Info("Retunrning the Customer Loan By Id");
                return custloan;
            }
            else 
            {
                _log4net.Info("No Customer Loan Found");
                return NotFound();
            }
        }
    }
}
