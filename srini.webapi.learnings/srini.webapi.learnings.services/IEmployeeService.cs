using srini.webapi.learnings.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace srini.webapi.learnings.services
{
    public interface IEmployeeService
    {
        List<Employee> GetEmployees();
        bool AddEmployee(Employee employee);
    }
}
