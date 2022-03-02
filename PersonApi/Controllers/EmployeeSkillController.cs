using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PersonApi.Services.Interfaces;

namespace PersonApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeSkillController : ControllerBase
    {
        private readonly IEmployeeSkillService _employeeSkillService;
        public EmployeeSkillController(IEmployeeSkillService employeeSkillService)
        {
            _employeeSkillService = employeeSkillService;
        }
        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var resultList = await _employeeSkillService.GetAllEmployeeSkill();
            return Ok(resultList);
        }

        [HttpGet("GetAllById")]
        public async Task<IActionResult> Get(int id)
        {
            var kq = await _employeeSkillService.GetEmployeeSkillById(id);
            return Ok(kq);
        }
        [HttpGet("Detail")]
        public async Task<IActionResult> GetAllDetail()
        {
           var result= await _employeeSkillService.GetDetail();
            return Ok(result);
        }
    }
}
