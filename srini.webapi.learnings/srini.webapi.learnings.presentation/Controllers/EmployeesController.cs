using srini.webapi.learnings.domain;
using srini.webapi.learnings.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace srini.webapi.learnings.presentation.Controllers
{
    public class EmployeesController : ApiController
    {
        private readonly IEmployeeService _employeeService;

        public EmployeesController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet]
        public HttpResponseMessage LoadEmployees()
        {
            try
            {
                List<Employee> employees = _employeeService.GetEmployees();
                return Request.CreateResponse(HttpStatusCode.Accepted, employees);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpGet]
        public HttpResponseMessage LoadEmployeeById(int id)
        {
            try
            {
                if (_employeeService.GetEmployees().Any(emp => emp.ID.Equals(id)))
                    return Request.CreateResponse(HttpStatusCode.OK,
                        _employeeService.GetEmployees().FirstOrDefault(emp => emp.ID.Equals(id)));
                else
                    return Request.CreateResponse(HttpStatusCode.NotFound, "No Employee found with this id");
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpPost]
        public HttpResponseMessage AddEmployee(Employee employee)
        {
            try
            {
                _employeeService.AddEmployee(employee);
                var message = Request.CreateResponse(HttpStatusCode.Created, employee);
                message.Headers.Location = new Uri(Request.RequestUri + 
                    _employeeService.GetEmployees().FirstOrDefault(emp => emp.ID.Equals(employee.ID)).ID.ToString());
                return message;
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }
    }
}
