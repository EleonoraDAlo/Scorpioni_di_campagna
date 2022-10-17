using GliScorpioniDiCampagna_Droni.Models.Enumerators;

namespace GliScorpioniDiCampagna_Droni.Models
{
    public class Drone
    {
        public int Id { get; set; }
        public double FlightTime { get; set; }

        public PilotType Pilot { get; set; }

        public PropulsionType Propulsion { get; set; }

        
    }
}
