using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EmpApi.Models
{
    public class EmployeeAddress
    {
        [Key]
        public int Id { get; set; }
        public String Address_type { get; set; }
        public String House_number { get; set; }
        public String Street { get; set; }
        public String City { get; set; }
        public String State { get; set; }

        public String Country { get; set; }
        public int Pin_Code { get; set; }
        public String Landmark { get; set; }
        [ForeignKey("Employee")]
        public int Empid { get; set; }
        public  employeeDetails Employee { get; set; }
    }
}