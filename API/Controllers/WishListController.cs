using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Converters;
using API.Models.Dto;
using API.Services;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/travelers/{travelerId}/wishlists")]
    public class WishListController : Controller
    {

        private readonly ITripsRepository TripsRepository;
        private readonly ITravelerRepository travelerRepository;
        private readonly IConverter CustomMapper;

        public WishListController(ITripsRepository LibraryRepository, IConverter convertidorModelos, ITravelerRepository LibraryTravelerRepository)
        {
            TripsRepository = LibraryRepository;
            CustomMapper = convertidorModelos;
            travelerRepository = LibraryTravelerRepository;
        }




       

        [HttpGet]
        public ActionResult<IEnumerable<string>> ListTripsWishList(string travelerId)
        {

            if (!travelerRepository.TravelerExists(travelerId))
            {
                return NotFound();
            }
            //var usuario = travelerRepository.GetTraveler(travelerId);
            var tripsFromRepo = TripsRepository.ListWishList(travelerId);
            return Ok(tripsFromRepo); //Retonar un codigo 200
        }

      

       
    }
}