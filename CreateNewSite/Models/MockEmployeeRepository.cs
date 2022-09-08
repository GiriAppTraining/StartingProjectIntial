using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employeeList;

        public MockEmployeeRepository()
        {
            _employeeList = new List<Employee>()
            {
                new Employee(){Id = 1, Name= "Giri", Email= "giri@gmail.com", Department= Dept.Developer},
                new Employee(){Id = 2, Name= "Sankar", Email= "Sankar@gmail.com", Department= Dept.DevOpsEngineer},
                new Employee(){Id = 3, Name= "GiSa", Email= "GiSa@gmail.com", Department= Dept.Tester},

            };
        }

        public Employee Add(Employee employee)
        {
            employee.Id = _employeeList.Max(e => e.Id) + 1 ;
            _employeeList.Add(employee);
            return employee;
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return _employeeList;
        }

        public Employee GetEmployee(int Id)
        {
            return _employeeList.FirstOrDefault(g => g.Id == Id);
        }
    }
}
