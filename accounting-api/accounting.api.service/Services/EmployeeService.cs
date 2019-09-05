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
            return SalaryFormula(_EmployeeRepository.GetEmployee());
        }

        public List<EmployeeDetail> GetEmployee(int id)
        {
            return SalaryFormula(_EmployeeRepository.GetEmployee(id));
        }

        private List<EmployeeDetail> SalaryFormula(List<EmployeeDetail> lsEmployeeDetail)
        {
            foreach(var item in lsEmployeeDetail)
            {
                List<EmployeeDetail> lsEmployeeDetail_ = new List<EmployeeDetail>();
                
                if (item.id_salary_type == 1)
                {
                    item.salary = 120 * item.salary * 12;
                }else if (item.id_salary_type == 2)
                {
                    item.salary = item.salary * 12;
                }

                lsEmployeeDetail_.Add(item);

            }
            return lsEmployeeDetail;
        }
    }
}