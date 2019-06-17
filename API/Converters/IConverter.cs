using API.Entities;
using API.Models;
using API.Models.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Converters
{
   public interface IConverter
    {
        Trip MapTripDtoToTrip(TripForCreationDto value);
        TripDto MapTripTripDto(Trip tripFromRepo);





        Traveler MapTravelerForCreationToTravelerDto(TravelerForCreationDto traveler);
        TravelerDto TravelerRepoToTravelerUI(Traveler travelerFromRepo);




    }
}
