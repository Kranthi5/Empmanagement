using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmpMangement.Models
{
    public class Employee
    {
        public Employee()
        {
        }
        [Key]
        public int Id { get; set; }
        [Required]
        [Column(TypeName = "varchar(250)")]
        public string Name { get; set; }
        [Column(TypeName = "varchar(250)")]
        public string Email { get; set; }
        [Column(TypeName = "varchar(250)")]
        public string Department { get; set; }
    }
}
