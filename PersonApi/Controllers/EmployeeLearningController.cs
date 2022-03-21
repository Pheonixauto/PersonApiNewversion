using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PersonApi.Services.Interfaces;

namespace PersonApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeLearningController : ControllerBase
    {
        private readonly IEmployeeLearningService _employeeLearningService;
        public EmployeeLearningController(IEmployeeLearningService employeeLearningService)
        {
            _employeeLearningService = employeeLearningService;
        }
        [Authorize]
        [HttpGet("GetEmployeeByNameSchool")]
        public async Task<IActionResult> GetEmployeeBySchoolName( string schoolName)
        {
            var result = await _employeeLearningService.GetEmployeeBySchoolName(schoolName);
            return Ok(result);
        }
    }
}
