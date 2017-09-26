using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UFOSightings.BL;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace UFOSightings.Controllers
{
    public class UFOSightingsController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet(Name = "GetNumberOfSightings")]
        public Object GetNumberOfSightings()
        {
            var response = new Dictionary<String, int>();
            List<BL.Models.UFOSightings> ufoSightings = UFOSightingsManager.Instance.UFOSightings;
            response.Add("count", ufoSightings.Count);
            return response;
        }

        [HttpGet(Name = "GetNumberOfUniqueShips")]
        public Object GetNumberOfUniqueShips()
        {
            var response = new Dictionary<String, int>();
            List<BL.Models.UFOSightings> ufoSightings = UFOSightingsManager.Instance.UFOSightings;
            response.Add("count", ufoSightings.Select(x => x.shape).Distinct().ToList().Count);
            return response;
        }
    }
}
