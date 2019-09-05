using accounting.api.infrastructure.Tables;
using System;
using System.Collections.Generic;
using System.Text;

namespace accounting.api.service.Interfaces
{
    public interface IEmployeeService
    {
        List<EmployeeDetail> GetEmployee();
        List<EmployeeDetail> GetEmployee(int id);
    }
}
