using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EmpApi.Models
{
    public class employeeDetails
    {
        [Key]
        public int EmpId { get; set; }
        public String First_Name { get; set; }
        public String Last_Name { get; set; }
        public String Date_of_Birth { get; set; }
        public int Age { get; set; }

        public String Email { get; set; }
        public String Phone_No { get; set; }
       // public EmployeeAddress Permenant_Address { get; set; }
        //public EmployeeAddress Current_Address { get; set; }
        public String Department{ get; set; }
        public String Job_Role { get; set; }
        public ICollection<EmployeeAddress> empaddr { get; set; }


    }
}