using API.Converters;
using API.Models;
using API.Services;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/travelers")]
    [Produces("application/json")]
    [Consumes("application/json")]
    public class TravelerController : Controller
    {

        private readonly ITravelerRepository _libraryRepository;
        private readonly IConverter CustomMapper;


        public TravelerController(ITravelerRepository LibraryRepository, IConverter convertidorModelos)
        {
            _libraryRepository = LibraryRepository;
            CustomMapper = convertidorModelos;
        }



        [HttpGet("{id}", Name = "GetTraveler")]
        public IActionResult GetTraveler(string id)
        {
            var travelerFromRepo = _libraryRepository.GetTraveler(id);



            if (travelerFromRepo == null)
            {
                return NotFound();
            }

            Models.TravelerDto traveler = CustomMapper.TravelerRepoToTravelerUI(travelerFromRepo);

            return Ok(traveler);
        }

        [HttpPost]
        public IActionResult CreateTraveler([FromBody] API.Models.TravelerForCreationDto traveler)
        {
            if (traveler == null)
            {
                return BadRequest();
            }

            var travelerdb = _libraryRepository.GetTraveler(traveler.ClientId);
            if (travelerdb != null)
                return StatusCode(409);

            var travelerEntity = CustomMapper.MapTravelerForCreationToTravelerDto(traveler);

            _libraryRepository.AddTraveler(travelerEntity);



            if (!_libraryRepository.Save())
            {
                throw new System.Exception("Creating an traveler failed on save.");
            }

            TravelerDto travelerToReturn = CustomMapper.TravelerRepoToTravelerUI(travelerEntity);

            return CreatedAtRoute("GetTraveler",
               new { id = travelerToReturn.Id },
               travelerToReturn);
        }
    }

}
