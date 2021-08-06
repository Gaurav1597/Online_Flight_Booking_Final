using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Online_Flight_Booking_Final.Models
{
    //Booking of a Flight including the passenger and flight information
    public class FlightBooking
    {
        public int Id { get; set; }

        public int FlightId { get; set; }

        public int PassengerId { get; set; }

        public Passenger Passenger { get; set; }

        public Flight Flight { get; set; }




       }
}
