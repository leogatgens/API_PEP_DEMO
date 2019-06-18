using API.Entities;
using API.Models.Dto;
using System.Collections.Generic;

namespace API.Services
{
   public interface IWishListRepository
    {
        void AddWishTrip(FutureTrips NewTrip);

        void DeleteWishTrip(FutureTrips wishtripEntity);

        //Manejar WishList
        IEnumerable<WishTripsDto> ListWishList(string clientId);

        FutureTrips GetWishTrip(int IdTrip);
        bool Save();
    }
}
