using API.Converters;
using API.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace API.Controllers
{
    [Route("api/paises")]
    [ApiController]
    [Produces("application/json")]
    [Consumes("application/json")]
    public class PaisesController : ControllerBase
    {

        //private readonly IPaisesRepository TripsRepository;
        //private readonly IConverter CustomMapper;



        //public PaisesController(IPaisesRepository LibraryRepository, IConverter convertidorModelos)
        //{
        //    TripsRepository = LibraryRepository;
        //    CustomMapper = convertidorModelos;

        //    //ObtenerDatosAPIExterno();


        //}

        //// GET api/values
        //[HttpGet]
        //public ActionResult<IEnumerable<string>> Get()
        //{

        //    var countryFromRepo = TripsRepository.ListAllCountries();
        //    return Ok(countryFromRepo); //Retonar un codigo 200

        //}

  

    }
}
