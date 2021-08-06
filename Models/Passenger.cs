using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Online_Flight_Booking_Final.Models
{
    //Passenger details such as contact number emain and name 
    public class Passenger
    {
        public int Id { get; set; }

        public string Email { get; set; }

        public string Name { get; set; }

        public string Mobile { get; set; }

    }
}
