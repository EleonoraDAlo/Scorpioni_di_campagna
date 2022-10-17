using GliScorpioniDiCampagna_Droni.UtilityClass;
using Microsoft.AspNetCore.Mvc;

namespace GliScorpioniDiCampagna_Droni.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class DronesController : Controller
    {
        private DroneService _droneService = new();

        [HttpGet] 
        public IActionResult GetAll()
        {
            return StatusCode(200,_droneService.GetAllDrones());
        }
    }
}
