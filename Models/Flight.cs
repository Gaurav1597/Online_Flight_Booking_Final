using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Online_Flight_Booking_Final.Models
{
    //Flight details such as Flight number , from, to price and Flight scheduled time
    public class Flight
    {
        public int Id { get; set; }

        public string FlightNumber { get; set; }

        public string From { get; set; }

        public string To { get; set; }

        public decimal Price { get; set; }

        public DateTime Scheduled  { get; set; }

    }
}
