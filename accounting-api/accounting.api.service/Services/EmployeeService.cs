using accounting.api.infrastructure.Interfaces;
using accounting.api.infrastructure.Tables;
using accounting.api.service.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace accounting.api.service.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _EmployeeRepository;

        public EmployeeService(IEmployeeRepository EmployeeRepository)
        {
            this._EmployeeRepository = EmployeeRepository;
        }

        public List<EmployeeDetail> GetEmployee()
        {
            return _EmployeeRepository.GetEmployee();
        }

        public List<EmployeeDetail> GetEmployee(int id)
        {
            return _EmployeeRepository.GetEmployee(id);
        }
    }
}
