using GliScorpioniDiCampagna_Droni.Models;

namespace GliScorpioniDiCampagna_Droni.Services
{
    public interface IFlightService
    {
        public IEnumerable<T> GetAllFlight<T>();

        public Flight GetFlightByID(int flightId);

        public void AddFlight(Flight flight);

        public void AddDroneIdToFlight(int droneId,int flightId);

    }
}
