using GliScorpioniDiCampagna_Droni.Models;
using System.Text.Json;

namespace GliScorpioniDiCampagna_Droni.UtilityClass
{
    public interface IDroneService
    {
      
        public List<Drone> GetAllDrones();

        public Drone GetDroneByID(int droneID);

        public void AddDrone(Drone drone);

           


    }
}
