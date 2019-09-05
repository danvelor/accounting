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
            return AnnualSalary(_EmployeeRepository.GetEmployee());
        }

        public List<EmployeeDetail> GetEmployee(int id)
        {
            return AnnualSalary(_EmployeeRepository.GetEmployee(id));
        }

        private List<EmployeeDetail> AnnualSalary(List<EmployeeDetail> lsEmployeeDetail)
        {
            foreach(var item in lsEmployeeDetail)
            {
                List<EmployeeDetail> lsEmployeeDetail_ = new List<EmployeeDetail>();
 
                switch (item.id_salary_type)
                {
                    case 1:
                        item.salary = 120 * item.salary * 12;
                        break;
                    case 2:
                        item.salary = item.salary * 12;
                        break;
                    default:
                        item.salary = 0;
                        break;
                }

                lsEmployeeDetail_.Add(item);

            }
            return lsEmployeeDetail;
        }
    }
}