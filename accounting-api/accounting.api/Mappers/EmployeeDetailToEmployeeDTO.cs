using accounting.api.DTOs;
using accounting.api.infrastructure.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace accounting.api.Mappers
{
    public static class EmployeeDetailToEmployeeDTO
    {
        public static List<EmployeeDTO> ToEmployeeDTO(List<EmployeeDetail> lsEmployeeDetail)
        {
            List<EmployeeDTO> lsEmployeeDTO = new List<EmployeeDTO>();
            EmployeeDTO employeeDTO = new EmployeeDTO();

            foreach(var item in lsEmployeeDetail)
            {
                employeeDTO = new EmployeeDTO();
                employeeDTO.EmployeeId = item.id;
                employeeDTO.EmployeeAddress_id = item.address_id;
                employeeDTO.EmployeeFirst_name = item.first_name;
                employeeDTO.EmployeeLast_name = item.last_name;
                employeeDTO.EmployeeSalary = item.salary;
                employeeDTO.EmployeeId_salary_type = item.id_salary_type;
                employeeDTO.EmployeeType = item.type;

                lsEmployeeDTO.Add(employeeDTO);
            }

            return lsEmployeeDTO;
        }

    }
}
