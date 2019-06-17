using API.Entities;
using API.Models.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Services
{
   public interface ITripsRepository
    {
        IEnumerable<TripDto> ListTrips(int travelerId);
        Trip GetTrip(int IdTrip);

        void AddTrip(Trip NewTrip);
        void DeleteTrip(Trip IdTrip);
        void UpdateTrip(Trip UpdatedTrip);
        bool TripExists(int IdTrip);





        //Manejar WishList
        IEnumerable<WishTripsDto> ListWishList(string clientId);
        

        
        bool Save();
        IEnumerable<CountryDto> ListAllCountries();
        CountryDto GetCountry(int id);
        
    }
}
