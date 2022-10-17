using GliScorpioniDiCampagna_Droni.Models;

namespace GliScorpioniDiCampagna_Droni.UtilityClass
{
    public static class ExtensionMethodIdentityId
    {
        public static int MaxDroneIdValue(this IEnumerable<Drone> enumerable)
        {
            int countId = 0;
            foreach(var item in enumerable)
            {
                if(item.Id >= countId)
                {
                    countId = item.Id + 1;
                }
            }
            return countId;
        }

        public static int MaxFlightIdValue(this IEnumerable<Flight> enumerable)
        {
            int countId = 0;
            foreach (var item in enumerable)
            {
                if (item.Id >= countId)
                {
                    countId = item.Id + 1;
                }
            }
            return countId;
        }
    }
}
