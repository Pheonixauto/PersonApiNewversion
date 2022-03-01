using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
        [HttpGet("GetAll")]
        [ProducesResponseType(200)]
        public async Task<IActionResult> Get()
        {
            var userList = await _employeeService.GetAllEmployees();
            return Ok(userList);
        }

        [HttpGet("{employeeId}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
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
        [HttpPost("Create")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        public async Task<IActionResult> Post(CreateEmployeeDTO createEmployeeDTO)
        {
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
        [HttpPut("{employeeId}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        public async Task<IActionResult> Put(int employeeId, CreateEmployeeDTO createEmployeeDTO)
        {
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
        [HttpDelete("{employeeId}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
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
