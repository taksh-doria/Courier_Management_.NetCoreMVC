using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Courier_Management_System.Models;

    public class DetailsContext : DbContext
    {
        public DetailsContext (DbContextOptions<DetailsContext> options)
            : base(options)
        {
        }

        public DbSet<Courier_Management_System.Models.Consignment_Details> Consignment_Details { get; set; }
    }
