using GliScorpioniDiCampagna_Droni.Models;
using GliScorpioniDiCampagna_Droni.UtilityClass;
using System.Text.Json;
using System.Text;

namespace GliScorpioniDiCampagna_Droni.Services
{
    public class FlightOnFile : IFlightService
    {
        private string _flightFilePath = "C:\\Users\\hp\\Source\\Repos\\Scorpioni_di_campagnaa\\GliScorpioniDiCampagna_Droni\\Files\\FlightsCollection.txt";
        private string _dronefilePath = "C:\\Users\\hp\\Source\\Repos\\Scorpioni_di_campagnaa\\GliScorpioniDiCampagna_Droni\\Files\\DronesCollectiontxt.txt";

        public void AddDroneIdToFlight(int droneId,int flightId)
        {
            var listFlight = WriterReader.Read<Flight>(_flightFilePath);
            var listDrone = WriterReader.Read<Drone>(_dronefilePath);

            var flight = listFlight.FirstOrDefault(flight => flight.Id == flightId);
            var drone = listDrone.FirstOrDefault(drone => drone.Id == droneId);
            flight.Drone = drone;
            File.WriteAllText(_flightFilePath, String.Empty);
            foreach(var item in listFlight)
            {
                    
                WriterReader.Write(JsonSerializer.Serialize(item), _flightFilePath);

            }
        }

        public void AddFlight(Flight flight)
        {
            var list = WriterReader.Read<Flight>(_flightFilePath);
            foreach (var item in list)
            {
                if (flight.Id != item.Id)
                    WriterReader.Write(JsonSerializer.Serialize(flight), _flightFilePath);
            }
        }

        public IEnumerable<Flight> GetAllFlight<Flight>()
        {
            var list = WriterReader.Read<Flight>(_flightFilePath);
            return list;
        }

        public Flight GetFlightByID(int flightId)
        {
            var list = WriterReader.Read<Flight>(_flightFilePath);
            var flight = list.FirstOrDefault(flight => flight.Id == flightId);
            return flight;
        }
    }
    
}

