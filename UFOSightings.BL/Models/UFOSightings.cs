using System;
using System.Collections.Generic;
using System.Text;

namespace UFOSightings.BL.Models
{


    public class UFOSightings
    {
        public int id{ get; set; }
        public String occurred_at { get; set; }
        public String city { get; set; }
        public String state { get; set; }
        public String country { get; set; }
        public String shape { get; set; }
        public String duration_seconds { get; set; }
        public String duration_text { get; set; }
        public String description { get; set; }
        public String reported_on { get; set; }
        public String latitude { get; set; }
        public String longitude { get; set; }
    }
}
