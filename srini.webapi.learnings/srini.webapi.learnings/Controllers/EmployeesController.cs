using srini.webapi.learnings.domain;
using srini.webapi.learnings.Models.Employee;
using srini.webapi.learnings.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace srini.webapi.learnings.Controllers
{
    public class EmployeesController : ApiController
    {
        private readonly IEmployeeService _employeeService;

        public EmployeesController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }
        //List<Employee> _employees = new List<Employee>()
        //{
        //    new Employee { id=1,firstName="srinivasulu",lastName="polubyena",email="srinivas5a0@gmail.com",dateOfBirth="18/02/1989",age=27,salary=750000},
        //    new Employee { id=2,firstName="sridhar",lastName="polubyena",email="sridhar@gmail.com",dateOfBirth="18/02/1989",age=23,salary=450000},
        //    new Employee { id=3,firstName="srilatha",lastName="polubyena",email="latha@gmail.com",dateOfBirth="18/02/1989",age=21,salary=350000}
        //};

        [HttpGet]
        public HttpResponseMessage GetEmployees()
        {
            try
            {
                List<Employee> employees = _employeeService.GetEmployees();
                //int secondHighestSalary = _employees.OrderByDescending(e => e.salary).ToList()[1].salary;
                return Request.CreateResponse(HttpStatusCode.Accepted, employees);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        //[HttpGet]
        //public HttpResponseMessage LoadEmployeeById(int id)
        //{
        //    try
        //    {
        //        if(_employees.Any(emp => emp.id.Equals(id)))
        //        {
        //            var message = Request.CreateResponse(HttpStatusCode.OK, _employees.FirstOrDefault(emp => emp.id.Equals(id)));
        //            return message;
        //        }
        //        else
        //        {
        //            var message = Request.CreateResponse(HttpStatusCode.NotFound, "No Employee found with this id");
        //            return message;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
        //    }
        //}

        //[HttpPost]
        //public HttpResponseMessage AddEmployee( [FromBody] Employee employee)
        //{
        //    try
        //    {
        //        _employees.Add(employee);
        //        var message = Request.CreateResponse(HttpStatusCode.Created, employee);
        //        message.Headers.Location = new Uri(Request.RequestUri + employee.id.ToString());
        //        return message;
        //    }
        //    catch (Exception ex)
        //    {
        //        return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
        //    }
        //}

        

    }
}
