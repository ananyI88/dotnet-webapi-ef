using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using dotnet_webapi_ef.DTOs.Destination;
using dotnet_webapi_ef.Models;

namespace dotnet_webapi.DTOs
{
    //โครงสร้างข้อมูลที่จะใช้ตอนรับเข้ากับส่งออกไปจาก API
    public class TripDTOs
    {
        public int Idx { get; set; }

        public string Name { get; set; } = null!;

        public string Country { get; set; } = null!;

        public int Destinationid { get; set; }

        [Column("coverimage")]
        public string Coverimage { get; set; } = null!;

        [Column("detail")]
        public string Detail { get; set; } = null!;

        [Column("price")]
        public int Price { get; set; }

        [Column("duration")]
        public int Duration { get; set; }

        // [InverseProperty("Trip")]
        // public virtual ICollection<Booking> Bookings { get; set; } = new List<Booking>();

        [ForeignKey("Destinationid")]
        [InverseProperty("Trips")]
        public virtual DestinationDTO Destination { get; set; } = null!;
    }
}