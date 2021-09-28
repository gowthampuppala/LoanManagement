using LoanManagement.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoanManagement.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {

       

        [HttpGet]
        public string Get()
        {
            //CRUD
            using (var _context = new CustomerDbContext())
            {
                //Publisher publisher = new Publisher();
                //publisher.PublisherName = "Egmont Book";

                //_context.Publishers.Add(publisher);

                //_context.SaveChanges();

                //Publisher publisher = _context.Publishers.FirstOrDefault();
                //publisher.PublisherName = "Egmont Books";

                //_context.Publishers.Remove(publisher);

                //               _context.SaveChanges();

                return "hi";

            }
        }
    }
}
