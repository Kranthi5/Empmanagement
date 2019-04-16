using System;
using EmpMangement.Models;
using Microsoft.EntityFrameworkCore;

namespace CrudApp.Models
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext(DbContextOptions<EmployeeContext> options) : base(options)
        {
            this.Database.EnsureCreated();
        }

        public DbSet<Employee> Employees { get; set; }



    }







}
