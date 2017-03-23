using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using srini.webapi.learnings.domain;
using srini.webapi.learnings.data;

namespace srini.webapi.learnings.services
{
    public class EmployeeService : IEmployeeService
    {
        private IRepository<Employee> _employeeRepository;

        public EmployeeService(IRepository<Employee> employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        public List<Employee> GetEmployees()
        {
            try
            {
                return _employeeRepository.Table.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool AddEmployee(Employee employee)
        {
            try
            {
                _employeeRepository.Insert(employee);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
