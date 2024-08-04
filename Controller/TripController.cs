using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_webapi.Mappers;
using dotnet_webapi_ef.Data;
using dotnet_webapi_ef.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace api.Controllers
{
    [ApiController]
    // [controller] => Name of the controller
    [Route("api/[controller]")]
    public class TripController : ControllerBase
    {
        // Attribute context is private and readonly
        // _name => only use in this class => this.xxxx
        private readonly ApplicationDBContext _context;
        public TripController(ApplicationDBContext context)
        {
            _context = context;
        }

        //http://localhost:5710/api/trip
        [HttpGet]
        public IActionResult GetAll(){
            var trip = _context.Trips.Include(t => t.Destination).Select(t=>t.ToTripDTO());
            return Ok(trip);
        }

        [HttpGet("{id}")]
        public IActionResult GetById([FromRoute] int id){
            // var trip = _context.Trips.Find(id);
            // if(trip == null){
            //     return NotFound();
            // }
            // return Ok(trip.ToTripDTO());
            //First is the first Default is has by default
            var trip = _context.Trips.Include(t => t.Destination).Where(t => t.Idx == id).FirstOrDefault();
            if (trip == null)
            {
                return NotFound();
            }
            return Ok(trip.ToTripDTO());
        }

        [HttpGet("name/{name}")]
        public IActionResult GetByName([FromRoute] string name){
            var customer = _context.Customers.Where(
                c => c.Fullname.Contains(name)
            );
            return Ok(customer);
        }
    }
}