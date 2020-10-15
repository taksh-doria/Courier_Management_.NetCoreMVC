using System;
using System.ComponentModel.DataAnnotations;

namespace Courier_Management_System.Models
{
    public class User
    {
        [Key]
        public Int64 id { get; set; }
        public String email { get; set; }
        public String password { get; set; }
        public String name { get; set; }
        public String phone_no { get; set; }
        public String city { get; set; }
        public String address { get; set; }
        public String role { get; set; }
    }
}
