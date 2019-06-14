using API.Models.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Services
{
   public interface IPaisesRepository
    {

        IEnumerable<CountryDto> ListAllCountries();


        bool Save();
    }
}
