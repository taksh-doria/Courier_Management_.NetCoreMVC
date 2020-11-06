using System;
using Microsoft.EntityFrameworkCore;

namespace Courier_Management_System.Models
{
    public class DataContext : DbContext
    {
        public DataContext() { }
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
        }

        public DbSet<Courier_Management_System.Models.City> City { get; set; }
        public DbSet<Courier_Management_System.Models.User> users { get; set; }
        public DbSet<Courier_Management_System.Models.Consignment_Details> Consignment_Details { get; set; }
        public DbSet<Courier_Management_System.Models.Employee> Employee { get; set; }
        public DbSet<Courier_Management_System.Models.Consignment_Status> Consignment_Status { get; set; }
    }
}
