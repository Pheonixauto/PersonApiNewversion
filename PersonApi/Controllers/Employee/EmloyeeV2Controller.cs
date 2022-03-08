using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PersonApi.Models;
using PersonApi.Services.Interfaces;

namespace PersonApi.Controllers.Employee
{
    [ApiVersion("2.0", Deprecated =true)]
    [Route("api/employee")]
    [ApiController]
    public class EmloyeeV2Controller : ControllerBase
    {
        private readonly IEmployeeService _employeeService;

        public EmloyeeV2Controller(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }
        //[Authorize(Roles ="Administrator")]
        [HttpGet("GetAll")]
        [ProducesResponseType(200)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> Get([FromQuery] RequestParams requestParams)
        {
            var userList = await _employeeService.GetEmployeePagedList(requestParams);
            return Ok(userList);
        }
    }
}
