using API.Entities;

namespace API.Services
{
   public interface ITravelerRepository
    {
        Traveler GetTraveler(string id);
        void AddTraveler(Traveler newTraveler);
        bool TravelerExists(string travelerId);
        bool Save();
    }
}
