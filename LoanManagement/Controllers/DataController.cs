using LoanManagement.Models.Entities;
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
        // GET: api/<DataController>
        [HttpGet]
        public IEnumerable<Customer_Loan> Get()
        {
            //CRUD
            using (var _context = new CustomerDbContext())
            {
                return _context.Customer_Loans.ToList();

            }
        }
        // GET api/<DataController>/5
        [HttpGet("{id}")]
        public Customer_Loan Get(int id)
        {
            using (var _context = new CustomerDbContext())
            {
                 return _context.Customer_Loans.Where(x=>x.Id==id).SingleOrDefault();
            }
        
        }

        // POST api/<DataController>
        [HttpPost]
        public IActionResult Post([FromBody] Customer r)
        {
            try
            {
            using (var _context = new CustomerDbContext())
            {
                    _context.Customers.Add(r);
                    _context.SaveChanges(); 
            }

            }
            catch (Exception)
            {

                return StatusCode(500, "An error occured");
            }
            using (var _context = new CustomerDbContext())
            {
                var custs = _context.Customers.ToList();
                return Ok(custs);
            }

        }




        [HttpPost]
        public IActionResult PostintoLoan([FromBody] Customer_Loan r)
        {
            try
            {
                using (var _context = new CustomerDbContext())
                {
                    _context.Customer_Loans.Add(r);
                    _context.SaveChanges();
                }

            }
            catch (Exception)
            {

                return StatusCode(500, "An error occured");
            }
            using (var _context = new CustomerDbContext())
            {
                var custs = _context.Customer_Loans.ToList();
                return Ok(custs);
            }
        }





        // PUT api/<DataController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<DataController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
