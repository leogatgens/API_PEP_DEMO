using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Context;
using API.Models.Dto;

namespace API.Services
{
    public class TripsRepository : IPaisesRepository
    {
        private readonly TripsContext datacontext;

        public TripsRepository(TripsContext context)
        {
            datacontext = context;



        }
        IEnumerable<CountryDto> IPaisesRepository.ListAllCountries()
        {
            return datacontext.Country.Select(c => new CountryDto
            { IdCountry = c.IdCountry, Name = c.Name, Capital = c.Name, Continent = c.CountryCode, UrlFlag = c.FlagUrl }).ToList();
        }

        bool IPaisesRepository.Save()
        {
            throw new NotImplementedException();
        }
    }
}
