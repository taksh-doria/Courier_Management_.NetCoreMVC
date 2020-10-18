using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Courier_Management_System.Models;

    public class CityContext : DbContext
    {
        public CityContext (DbContextOptions<CityContext> options)
            : base(options)
        {
        }

        public DbSet<Courier_Management_System.Models.City> City { get; set; }
    }
