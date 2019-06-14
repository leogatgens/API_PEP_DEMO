using API.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Context
{
    public class TripsContext : DbContext
    {

        public TripsContext(DbContextOptions<TripsContext> options)
           : base(options)
        {


        }

        public DbSet<Country> Country { get; set; }

   
    }
}
