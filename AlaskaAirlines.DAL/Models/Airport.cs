using System;
using System.Collections.Generic;
using System.Text;

namespace AlaskaAirlines.BL.Models
{
    public class Airport
    {
        public enum AirportCode
        {
            SEA,
            LAS,
            LAX,
            PHX
        }

        public AirportCode Code { get; set; }
        public String Name { get; set; }
    }
}
