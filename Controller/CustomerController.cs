using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_webapi_ef.Data;
using dotnet_webapi_ef.Mappers;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomerController : ControllerBase
    {
        private readonly ApplicationDBContext _context;
        public CustomerController(ApplicationDBContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var customers = _context.Customers.Select(c => c.ToCustomerDTO());
            return Ok(customers);
        }

        [HttpGet("{id}")]
        public IActionResult GetById([FromRoute] int id)
        {
            var customer = _context.Customers.Find(id);
            if (customer == null)
            {
                return NotFound();
            }
            return Ok(customer.ToCustomerDTO());
        }

        [HttpGet("name/{name}")]
        public IActionResult GetByName([FromRoute] string name)
        {
            var customers = _context.Customers.Where(c => c.Fullname.Contains(name)).Select(c => c.ToCustomerDTO());
            return Ok(customers);
        }
    }
}