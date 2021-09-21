using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace test.Models
{
    public class Employee
    {
        [Key]
        public string EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public DateTime EmployeeBirth { get; set; }
    }
}