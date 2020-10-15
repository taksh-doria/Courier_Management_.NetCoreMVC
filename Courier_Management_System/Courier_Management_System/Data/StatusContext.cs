using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Courier_Management_System.Models;

    public class StatusContext : DbContext
    {
        public StatusContext (DbContextOptions<StatusContext> options)
            : base(options)
        {
        }

        public DbSet<Courier_Management_System.Models.Consignment_Status> Consignment_Status { get; set; }
    }
