using GliScorpioniDiCampagna_Droni.Services;
using Microsoft.AspNetCore.Mvc;
using GliScorpioniDiCampagna_Droni.Models;
using GliScorpioniDiCampagna_Droni.UtilityClass;
using System.Text;

namespace GliScorpioniDiCampagna_Droni.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class FlightsController : Controller
    {
        private IFlightService _flightService = new FlightOnFile();

        [HttpGet]
        public IActionResult GetAll()
        {
            return StatusCode(200, _flightService.GetAllFlight());
        }

        [HttpGet("{id}")]
        public IActionResult GetByID(int id)
        {
            if (id == 0)
                return NotFound("Elemento non trovato");
            if (id.GetType() == typeof(string))
                return BadRequest("Parametro errato!");

            return StatusCode(200, _flightService.GetFlightByID(id));
        }

        [HttpPost]
        public IActionResult Post([FromBody] Flight flight)
        {
            _flightService.AddFlight(flight);
            return StatusCode(200);
        }

        [HttpPost]
        public 
       
    }
}
