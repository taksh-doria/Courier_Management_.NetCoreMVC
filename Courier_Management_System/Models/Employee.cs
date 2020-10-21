using System;
using System.ComponentModel.DataAnnotations;
namespace Courier_Management_System.Models
{
    public class Employee
    {
       [Key]
       public int emp_id { get; set; }

       public String emp_name { get; set; }
       public String emp_role { get; set; }
       public String emp_address { get; set; }
       public String emp_city { get; set; }
       public String emp_email { get; set; }
       public String emp_password { get; set; }
    }
}
