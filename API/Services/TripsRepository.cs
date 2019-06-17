using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Context;
using API.Entities;
using API.Models.Dto;
using Microsoft.EntityFrameworkCore;

namespace API.Services
{
    public class TripsRepository : ITripsRepository
    {
        private readonly TripsContext datacontext;

        public TripsRepository(TripsContext context)
        {
            datacontext = context;



        }



        #region "Trips"

        bool ITripsRepository.TripExists(int IdTrip)
        {
            throw new NotImplementedException();
        }

        IEnumerable<TripDto> ITripsRepository.ListTrips(int travelerId)
        {



            var mytrips = datacontext.Trip.Where(x => x.TravelerId == travelerId).Include("Country")
                .Select(x => new TripDto
                {
                    IdPais = x.IdCountry,
                    AnnoDeLaVisita = x.DateVisited
               ,
                    CodigoPais = x.Country.CountryCode,
                    Pais = x.Country.Name,
                    UrlFlag = x.Country.FlagUrl
                }).OrderByDescending(f => f.AnnoDeLaVisita).ToList();

            return mytrips;
        }

        void ITripsRepository.UpdateTrip(Trip UpdatedTrip)
        {
            throw new NotImplementedException();
        }


        void ITripsRepository.AddTrip(Trip NewTrip)
        {
            datacontext.Trip.Add(NewTrip);
        }



        void ITripsRepository.DeleteTrip(Entities.Trip IdTrip)
        {
            throw new NotImplementedException();
        }



        Trip ITripsRepository.GetTrip(int IdTrip)
        {
            return datacontext.Trip.Include("Country").FirstOrDefault(x => x.Id == IdTrip);
        }
        #endregion


        #region "Country"
        CountryDto ITripsRepository.GetCountry(int id)
        {
            throw new NotImplementedException();
        }

        IEnumerable<CountryDto> ITripsRepository.ListAllCountries()
        {
            return datacontext.Country.Select(c => new CountryDto
            { IdCountry = c.IdCountry, Name = c.Name, Capital = c.Name, Continent = c.CountryCode, UrlFlag = c.FlagUrl }).ToList();
        }

        #endregion

        #region "WishTrip"


      




      
        #endregion

        bool ITripsRepository.Save()
        {
            return (datacontext.SaveChanges() >= 0);
        }

        IEnumerable<WishTripsDto> ITripsRepository.ListWishList(string clientId)
        {
            var mytrips = datacontext.FutureTrips.Include("Country")
                 .Where(x => x.ClientId == clientId)
                 .Select(x => new WishTripsDto
                 {
                     IdTrip = x.Id,
                     Name = x.Country.Name,
                     annoDeLaVisita = x.TripDate
                 ,
                     IdPais = x.Country.IdCountry,
                     UrlFlag = x.Country.FlagUrl
                 }).ToList();

            return mytrips;
        }
    }
}

