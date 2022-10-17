using GliScorpioniDiCampagna_Droni.Models;
using GliScorpioniDiCampagna_Droni.UtilityClass;
using System.Text.Json;
using System.Text;

namespace GliScorpioniDiCampagna_Droni.Services
{
    public class FlightOnFile : IFlightService
    {
        private string filePath = "C:\\Users\\Alessandro\\Desktop\\VS\\C#.NET\\GliScorpioniDiCampagna_Droni\\GliScorpioniDiCampagna_Droni\\Files\\FlightsCollectiontxt.txt";

        public void AddDroneIdToFlight(int droneId,int flightId)
        {
            var list = WriterReader.Read<Flight>(filePath);
            var flight = list.FirstOrDefault(flight => flight.Id == flightId);
            flight.DroneId = droneId;
            File.WriteAllText(filePath, String.Empty);
            foreach(var item in list)
            {
                    
                WriterReader.Write(JsonSerializer.Serialize(item), filePath);

            }
        }

        public void AddFlight(Flight flight)
        {
            var list = WriterReader.Read<Flight>(filePath);
            foreach (var item in list)
            {
                if (flight.Id != item.Id)
                    WriterReader.Write(JsonSerializer.Serialize(flight), filePath);
            }
        }

        public IEnumerable<Flight> GetAllFlight<Flight>()
        {
            var list = WriterReader.Read<Flight>(filePath);
            return list;
        }

        public Flight GetFlightByID(int flightId)
        {
            var list = WriterReader.Read<Flight>(filePath);
            var flight = list.FirstOrDefault(flight => flight.Id == flightId);
            return flight;
        }
    }
    
}

