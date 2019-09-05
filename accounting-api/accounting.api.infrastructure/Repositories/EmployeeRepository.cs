using accounting.api.infrastructure.Tables;
using accounting.api.infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using accounting.api.infrastructure.Repositories;
using accounting.api.infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace accounting.api.infrastructure.Repository
{
    public class EmployeeRepository : EntityBaseRepository<EmployeeDetail>, IEmployeeRepository
    {
        public EmployeeRepository(accountingContext context) : base(context)
        {

        }

        public List<EmployeeDetail> GetEmployee()
        {
            StringBuilder sqlQuery = new StringBuilder();

            sqlQuery.Append(" SELECT ve.id, ve.address_id, ve.first_name, ve.last_name, ve.salary, ve.id_salary_type, ve.type ");
            sqlQuery.Append(" FROM dbo.v_employees AS ve  ");

            var Employee = this.Context.EmployeeDetail.FromSql(sqlQuery.ToString()).AsNoTracking().ToList();

            return Employee;
        }

        public List<EmployeeDetail> GetEmployee(int id)
        {
            StringBuilder sqlQuery = new StringBuilder();

            sqlQuery.Append(" SELECT ve.id, ve.address_id, ve.first_name, ve.last_name, ve.salary, ve.id_salary_type, ve.type ");
            sqlQuery.Append(" FROM dbo.v_employees AS ve  ");
            sqlQuery.Append(" where ve.id = {0}");

            var Employee = this.Context.EmployeeDetail.FromSql(sqlQuery.ToString(), id.ToString()).AsNoTracking().ToList();

            return Employee;
        }
    }
}
