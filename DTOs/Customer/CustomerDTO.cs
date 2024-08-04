using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_webapi_ef.Models;

namespace dotnet_webapi_ef.DTOs.Customer
{
    public class CustomerDTO
    {

        public int Idx { get; set; }

        public string Fullname { get; set; } = null!;

        public string Phone { get; set; } = null!;

        public string Email { get; set; } = null!;

        public string Image { get; set; } = null!;

        // public string Password { get; set; } = null!;

        // public virtual ICollection<Booking> Bookings { get; set; } = new List<Booking>();
    }
}