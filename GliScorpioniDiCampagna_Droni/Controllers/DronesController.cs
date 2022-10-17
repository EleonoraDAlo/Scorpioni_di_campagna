using GliScorpioniDiCampagna_Droni.UtilityClass;
using Microsoft.AspNetCore.Mvc;
using GliScorpioniDiCampagna_Droni.Services;
using GliScorpioniDiCampagna_Droni.Models;

namespace GliScorpioniDiCampagna_Droni.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class DronesController : Controller
    {
        private IDroneService _droneService = new DroneOnFile();

        [HttpGet] 
        public IActionResult GetAll()
        {
            return StatusCode(200,_droneService.GetAllDrones<Drone>());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
           
            if (id.GetType() == typeof(string))
                return BadRequest("Parametro errato!");

            return StatusCode(200, _droneService.GetDroneByID(id));
        }

        [HttpPost]
        public IActionResult Post([FromBody] Drone drone)
        {
           _droneService.AddDrone(drone);
            return StatusCode(200);
        }


    }
}
