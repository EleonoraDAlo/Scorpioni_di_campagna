namespace GliScorpioniDiCampagna_Droni.Models
{
    public class Flight
    {
        public int Id { get; set; }

        public DateTime DepartureDate { get; set; }

        public DateTime ArrivalDate { get; set; }

       // public int DroneId { get; set; }

        public Drone? Drone { get; set; }
    }
}
