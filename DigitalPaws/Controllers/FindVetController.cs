using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System.Threading.Tasks;
using DigitalPaws.Services; 

namespace DigitalPaws.Controllers
{
    public class VetsController : Controller
    {
        private readonly GooglePlacesService _googlePlacesService;

        public VetsController(GooglePlacesService googlePlacesService)
        {
            _googlePlacesService = googlePlacesService;
        }

        public async Task<IActionResult> Index()
        {
            string userLocation = "43.4643,-80.5204"; 
            int radius = 10000; // 10 km radius

            var json = await _googlePlacesService.GetNearbyVetsAsync(userLocation, radius);

            JObject data = JObject.Parse(json);
            ViewBag.DebugData = json;  
            ViewBag.Vets = data["results"]; 

            return View();
        }
    }
}





