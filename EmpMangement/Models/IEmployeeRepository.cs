using System;
using System.Collections.Generic;

namespace EmpMangement.Models
{
    public interface IEmployeeRepository
    {
         IEnumerable<Employee> GetAll();
        Employee GetEmployee(int Id);
        void Add(Employee entity);
        void Update(Employee employee, Employee entity);
        void Delete(Employee Id);
    }
}
