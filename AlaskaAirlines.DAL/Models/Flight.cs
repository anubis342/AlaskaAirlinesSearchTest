using System;
using System.Collections.Generic;
using System.Text;

namespace AlaskaAirlines.BL.Models
{
    public class Flight
    {
        public String From { get; set; }
        public String To { get; set; }
        public int FlightNumber { get; set; }
        public DateTime Departs { get; set; }
        public DateTime Arrives { get; set; }
        public int MainCabinPrice { get; set; }
        public int FirstClassPrice { get; set; }
    }
}
