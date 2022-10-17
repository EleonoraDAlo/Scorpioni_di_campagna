using GliScorpioniDiCampagna_Droni.Models;
using GliScorpioniDiCampagna_Droni.UtilityClass;
using System.Text.Json;

namespace GliScorpioniDiCampagna_Droni.Services
{
    public class DroneOnFile : IDroneService
    {
       // TODO cambiare il percorso con uno relativo
        private string filePath = "C:\\Users\\hp\\Source\\Repos\\Scorpioni_di_campagnaa\\GliScorpioniDiCampagna_Droni\\Files\\DronesCollectiontxt.txt";
 
        public void AddDrone(Drone drone)
        {
            var list = WriterReader.Read<Drone>(filePath);
            WriterReader.Write(JsonSerializer.Serialize(drone), filePath);
            //foreach(var item in list)
            //{
            //    if (item.Id == drone.Id)
            //    {
            //        return;
            //    }
            //    //else
            //    //{
            //    //    WriterReader.Write(JsonSerializer.Serialize(drone), filePath);
            //    //}
            //}
            //foreach(var item in list)
            //{
            //    if (drone.Id != item.Id)
            //        WriterReader.Write(JsonSerializer.Serialize(drone),filePath);
            //}
        }

        public IEnumerable<Drone> GetAllDrones<Drone>()
        {
            var list = WriterReader.Read<Drone>(filePath);
            return list;
        }

        public Drone GetDroneByID(int droneID)
        {
            var list = WriterReader.Read<Drone>(filePath);
            var drone = list.FirstOrDefault(drone => drone.Id == droneID);
            return drone;
        }
    }
}
