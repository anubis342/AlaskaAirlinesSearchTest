using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using AlaskaAirlines.BL;
using AlaskaAirlines.BL.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AlaskaAirlines.Controllers
{
    public class AirportSearchController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet(Name = "GetAirports")]
        public IEnumerable<Airport> GetAirports()
        {
            return AirportManager.Instance.airports;
        }

        [HttpGet(Name = "SearchFlights")]
        public IEnumerable<Flight> SearchFlights(string departure, string arrival)
        {
            var flights = FlightManager.Instance.flights;

            if (!String.IsNullOrEmpty(departure) && !String.IsNullOrEmpty(arrival))
            {
                return flights = flights.Where(f => f.From.Equals(departure) && 
                                               f.To.Equals(arrival)).ToList();
            }

            return null;
        }
    }
}
