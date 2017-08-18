using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PartialViewEmp040817.Models
{
    public class EmployeeModel
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string Address { get; set; }
        public decimal Salary { get; set; }
    }
}