using System;
using System.ComponentModel.DataAnnotations;
namespace Courier_Management_System.Models
{
    public class City
    {
       [Key]
        public String city_name { get; set; }

        public String State { get; set; }
        public Int16 city_pincode { get; set; }
        public String branch_address { get; set; }
    }
}
