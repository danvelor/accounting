using System;
using System.Collections.Generic;
using System.Text;

namespace accounting.api.infrastructure.Tables
{
    public class EmployeeDetail
    {
        public int id { get; set; }
        public Int64 address_id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public decimal salary { get; set; }
        public int id_salary_type { get; set; }
        public string type { get; set; }
    }
}
