using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using accounting.api.DTOs;
using accounting.api.infrastructure.Interfaces;
using accounting.api.service.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.Swagger.Annotations;
using accounting.api.Mappers;

namespace accounting.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {

        public IEmployeeRepository _EmployeeRepository { get; set; }
        public IEmployeeService _EmployeeService { get; set; }


        public EmployeeController(IEmployeeRepository EmployeeRepository, IEmployeeService EmployeeService)
        {
            _EmployeeRepository = EmployeeRepository;
            _EmployeeService = EmployeeService;
        }

        /// <summary>
        /// Get employees' list
        /// </summary>
        /// <returns>Returns an employees' list with identity and salary information</returns>        
        [HttpGet()]
        [SwaggerResponse(200, Type = typeof(List<EmployeeDTO>))]
        public ActionResult<List<EmployeeDTO>> Get()
        {
            List<EmployeeDTO> lsEmployeeDTO = new List<EmployeeDTO>();
            lsEmployeeDTO = EmployeeDetailToEmployeeDTO.ToEmployeeDTO(_EmployeeService.GetEmployee());
            return lsEmployeeDTO;
        }

        /// <summary>
        /// Get employee by id
        /// </summary>
        /// <returns>Returns an employee with identity and salary information</returns> 
        [HttpGet("{id}", Name = "Get")]
        [SwaggerResponse(200, Type = typeof(List<EmployeeDTO>))]
        public ActionResult<List<EmployeeDTO>> Get(int id)
        {
            List<EmployeeDTO> lsEmployeeDTO = new List<EmployeeDTO>();
            lsEmployeeDTO = EmployeeDetailToEmployeeDTO.ToEmployeeDTO(_EmployeeService.GetEmployee(id));
            return lsEmployeeDTO;
        }

    }
}
