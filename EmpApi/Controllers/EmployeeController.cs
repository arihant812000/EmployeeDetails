using EmpApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EmpApi.Controllers
{
    public class EmployeeController : ApiController
    {
        EmployeeContext ec = new EmployeeContext();
       
        public IEnumerable<employeeDetails> get()
        {
            var data = ec.employeeDetails.ToList();
            foreach(var dat in data)
            { 
                dat.empaddr =ec.EmployeeAddresses.Where(x => x.Empid == dat.EmpId).ToList();;
            }
            return data;
            
        }
        public HttpResponseMessage delete(int id)
        {
            try
            {
 ec.employeeDetails.Remove(ec.employeeDetails.FirstOrDefault(x=>x.EmpId==id));
                ec.SaveChanges();
            return Request.CreateResponse(HttpStatusCode.OK, "deleted");
            }
            catch(Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.OK, "error occured");
            }
           

          

        }
        public HttpResponseMessage post([FromBody]employeeDetails employee)
        {           
            ec.employeeDetails.Add(employee);
            ec.SaveChanges();
            return Request.CreateResponse(HttpStatusCode.OK, "added");
            

        }
        public HttpResponseMessage put([FromUri]int id,[FromBody]employeeDetails employee)
        {
            
           
            try
            {
                var data = ec.employeeDetails.FirstOrDefault(e => e.EmpId == id);
                if (data == null)
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound, "some error occured");
                }
                else
                {
                    var da=ec.EmployeeAddresses.Where(x => x.Empid == id).ToList();
                    foreach(var d in da)
                    {
                        ec.EmployeeAddresses.Remove(d);
                        ec.SaveChanges();
                    }
                  
                    data.First_Name =employee.First_Name ;
                data.Last_Name = employee.Last_Name;
                data.Age = employee.Age;
                data.Date_of_Birth = employee.Date_of_Birth;
                data.Department = employee.Department;
                data.Email = employee.Email;
                data.Job_Role = employee.Job_Role;
                data.Phone_No = employee.Phone_No;
                    data.empaddr = employee.empaddr;

                    ec.SaveChanges();
                    return Request.CreateResponse(HttpStatusCode.OK, "data updated");
                }

            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, "some error occured");
            }
        }
    }
}
