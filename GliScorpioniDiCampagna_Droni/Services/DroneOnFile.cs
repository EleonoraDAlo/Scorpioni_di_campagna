using GliScorpioniDiCampagna_Droni.Models;
using GliScorpioniDiCampagna_Droni.UtilityClass;
using System.Text.Json;

namespace GliScorpioniDiCampagna_Droni.Services
{
    public class DroneOnFile : IDroneService
    {
        private string filePath = "C:\\Users\\Alessandro\\Desktop\\VS\\C#.NET\\GliScorpioniDiCampagna_Droni\\GliScorpioniDiCampagna_Droni\\Files\\DronesCollectiontxt.txt";
        public void AddDrone(Drone drone)
        {
            var list = WriterReader.Read<Drone>(filePath);
            foreach(var item in list)
            {
                if (drone.Id != item.Id)
                    WriterReader.Write(JsonSerializer.Serialize(drone),filePath);
            }
        }

        public List<Drone> GetAllDrones()
        {
            var list = WriterReader.Read<Drone>(filePath);
            return list;
        }

        public Drone GetDroneByID(int droneID)
        {
            throw new NotImplementedException();
        }
    }
}
