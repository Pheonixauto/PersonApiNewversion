using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PersonApi.DTO;
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
        [Authorize(Roles = "Administrator")]
        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var resultList = await _employeeSkillService.GetAllEmployeeSkill();
            return Ok(resultList);
        }

        [HttpGet("GetAllById")]
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> Get(int id)
        {
            var kq = await _employeeSkillService.GetEmployeeSkillById(id);
            return Ok(kq);
        }
        [HttpGet("AllDetail")]
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> GetAllDetail()
        {
           var result= await _employeeSkillService.GetAllDetail();
            return Ok(result);
        }
        [HttpGet("NameSkill")]
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> NameSkill()
        {
            var result = await _employeeSkillService.GetNameSkillEmployee();
            return Ok(result);
        }
        [Authorize(Roles = "Administrator")]
        [HttpGet("GetEmployeeBySkillName")]
        public async Task<IActionResult> GetEmployeeBySkillName(string skillName)
        {
            var result = await _employeeSkillService.GetEmployeeBySkill(skillName);
            return Ok(result);
        }
        [Authorize(Roles = "Administrator")]
        [HttpGet("GetEmployeeByRating")]
        public async Task<IActionResult> GetEmployeeByRating(double rating)
        {
            var result = await _employeeSkillService.GetEmployeeByRating(rating);
            return Ok(result);
        }
        [Authorize(Roles = "Administrator")]
        [HttpPost]
        public async Task<IActionResult> Post(CreateEmployeeSkillDTO createEmployeeSkillDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            await _employeeSkillService.AddEmployeeSkill(createEmployeeSkillDTO);
            return Ok();
        }
    }
}
