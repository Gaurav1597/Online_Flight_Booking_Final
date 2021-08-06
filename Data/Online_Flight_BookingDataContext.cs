using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Online_Flight_Booking_Final.Models;

namespace Online_Flight_Booking_Final.Models
{
    public class Online_Flight_BookingDataContext : DbContext
    {
        public Online_Flight_BookingDataContext (DbContextOptions<Online_Flight_BookingDataContext> options)
            : base(options)
        {
        }

        public DbSet<Online_Flight_Booking_Final.Models.Flight> Flight { get; set; }

        public DbSet<Online_Flight_Booking_Final.Models.FlightBooking> FlightBooking { get; set; }

        public DbSet<Online_Flight_Booking_Final.Models.Passenger> Passenger { get; set; }
    }
}
