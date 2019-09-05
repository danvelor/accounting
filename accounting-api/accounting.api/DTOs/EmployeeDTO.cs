using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace accounting.api.DTOs
{
    public class EmployeeDTO
    {
        public int EmployeeId { get; set; }
        public Int64 EmployeeAddress_id { get; set; }
        public string EmployeeFirst_name { get; set; }
        public string EmployeeLast_name { get; set; }
        public decimal EmployeeSalary { get; set; }
        public int EmployeeId_salary_type { get; set; }
        public string EmployeeType { get; set; }
    }
}
