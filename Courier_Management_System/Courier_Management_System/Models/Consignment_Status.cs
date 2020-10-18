using System;
using System.ComponentModel.DataAnnotations;

namespace Courier_Management_System.Models
{
    public class Consignment_Status
    {
        [Key]
        public Int64 pkg_id { get; set; }

        public Int64 consignment_no { get; set; }

        public String user { get; set; }

        public String consignee_name { get; set; }

        public DateTime date { get; set; }

        public String status { get; set; }

    }
}
