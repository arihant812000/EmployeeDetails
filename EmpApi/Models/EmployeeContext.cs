using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EmpApi.Models
{
    public class EmployeeContext : DbContext
    {
       public EmployeeContext() : base("conn") { }
        public DbSet<employeeDetails> employeeDetails { get; set; }
        public DbSet<EmployeeAddress> EmployeeAddresses { get; set; }
    }
}