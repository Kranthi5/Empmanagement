using System;
using System.Collections.Generic;
using System.Linq;
using CrudApp.Models;

namespace EmpMangement.Models
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        readonly EmployeeContext _employeeContext;

        public MockEmployeeRepository(EmployeeContext context)
        {
            _employeeContext = context;
        }

        public Employee GetEmployee(int id)
        {
            return _employeeContext.Employees
                  .FirstOrDefault(e => e.Id == id);
        }

        public void Add(Employee entity)
        {
            _employeeContext.Employees.Add(entity);
            _employeeContext.SaveChanges();
        }

        IEnumerable<Employee> IEmployeeRepository.GetAll()
        {
            return _employeeContext.Employees.ToList();
        }


        public void Update(Employee employee, Employee entity)
        {
            employee.Name = entity.Name;
            employee.Email = entity.Email;
            employee.Department = entity.Department;

            _employeeContext.SaveChanges();
        }

        public void Delete(Employee employee)
        {
            _employeeContext.Employees.Remove(employee);
            _employeeContext.SaveChanges();
        }


    }





}
