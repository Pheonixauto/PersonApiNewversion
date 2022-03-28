using Marvin.Cache.Headers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PersonApi.Models;
using PersonApi.Models.FluentValidation;
using PersonApi.ModelsDTO;
using PersonApi.Services.Interfaces;

namespace PersonApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }
        //[Authorize(Roles = "Administrator")]
        [HttpGet("GetAll")]
        [HttpCacheExpiration(CacheLocation = CacheLocation.Public, MaxAge = 90)]
        [HttpCacheValidation(MustRevalidate = false)]
        [ProducesResponseType(200)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> Get([FromQuery] RequestParams requestParams)
        {
            var userList = await _employeeService.GetEmployeePagedList(requestParams);
            return Ok(userList);
        }

        [HttpGet("test")]
        public async Task<IActionResult> Test()
        {
            var result = await _employeeService.GetAllEmployeesTest();
            return Ok(result);
        }

        [Authorize(Roles = "Administrator")]
        [HttpGet("{employeeId}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> Get(int employeeId)
        {
            var employee = await _employeeService.GetEmployeeById(employeeId);

            if (employee != null)
            {
                return Ok(employee);
            }
            else
            {
                return BadRequest(employee);
            }
        }


        [Authorize(Roles = "Administrator")]
        [HttpPost("Create")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> Post(CreateEmployeeDTO createEmployeeDTO)
        {
            EmployeeValidator validationRules = new EmployeeValidator();
            var validationResult = validationRules.Validate(createEmployeeDTO);
            if (!validationResult.IsValid)
            {
                return StatusCode(StatusCodes.Status400BadRequest, validationResult.Errors);
            }
            var employeeCreated = await _employeeService.CreateNewEmployee(createEmployeeDTO);

            if (employeeCreated)
            {
                return Ok(employeeCreated);
            }
            else
            {
                return BadRequest(employeeCreated);
            }
        }

        [Authorize(Roles = "Administrator")]
        [HttpPut("{employeeId}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> Put(int employeeId, CreateEmployeeDTO createEmployeeDTO)
        {
            EmployeeValidator validationRules = new EmployeeValidator();
            var validationResult = validationRules.Validate(createEmployeeDTO);
            if (!validationResult.IsValid)
            {
                return StatusCode(StatusCodes.Status400BadRequest, validationResult.Errors);
            }
            var employeeCreated = await _employeeService.UpdateEmployee(employeeId, createEmployeeDTO);

            if (employeeCreated)
            {
                return Ok(employeeCreated);
            }
            else
            {
                return BadRequest(employeeCreated);
            }
        }

        [Authorize(Roles = "Administrator")]
        [HttpDelete("{employeeId}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> Delete(int employeeId)
        {
            var employee = await _employeeService.DeleteEmployee(employeeId);

            if (employee)
            {
                return Ok(employee);
            }
            else
            {
                return BadRequest(employee);
            }
        }

    }
}
