using accounting.api.infrastructure.Tables;
using System;
using System.Collections.Generic;
using System.Text;

namespace accounting.api.infrastructure.Interfaces
{
    public interface IEmployeeRepository : IEntityBaseRepository<EmployeeDetail>
    {
        List<EmployeeDetail> GetEmployee();
        List<EmployeeDetail> GetEmployee(int id);
    }
}
