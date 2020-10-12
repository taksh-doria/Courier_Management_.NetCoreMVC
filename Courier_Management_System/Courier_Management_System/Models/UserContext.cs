using System;
using Microsoft.EntityFrameworkCore;

namespace Courier_Management_System.Models
{
    public class UserContext : DbContext
    {
        public UserContext() { }
        public UserContext(DbContextOptions<UserContext> options)
            : base(options)
        {
        }

        public DbSet<Courier_Management_System.Models.User> users { get; set; }
    }
}
