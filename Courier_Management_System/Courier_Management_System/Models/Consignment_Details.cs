using System;
using System.ComponentModel.DataAnnotations;
namespace Courier_Management_System.Models
{
    public class Consignment_Details
    {
        [Key]
        public Int64 ID {get; set;}

        public String user { get; set; }
        public String package_type { get; set; }
        public DateTime date { get; set; }
        public String destination_city { get; set; }
        public  String  Consignee_name { get; set; }
        public String address { get; set; }
        public  float  pkg_weight_in_grams { get; set; }
        public  float amount { get; set; }
    }
}
