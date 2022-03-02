using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PersonApi.ModelsDTO;
using PersonApi.Services.Interfaces;

namespace PersonApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalaryController : ControllerBase
    {
        private readonly ISalaryService _salaryService;
        public SalaryController(ISalaryService salaryService)
        {
            _salaryService = salaryService;
        }
        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {

            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var salaryList = await _salaryService.GetAllSalary();
            return Ok(salaryList);
        }

        [HttpGet("{id:int}", Name = "GetSalaryById")]
        public async Task<IActionResult> Get(int id)
        {
            var salary = await _salaryService.GetSalaryById(id);
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            return Ok(salary);
        }
        [HttpPost]
        public async Task<IActionResult> Post(CreateSalaryDTO createSalaryDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            try
            {
                await _salaryService.CreateSalary(createSalaryDTO);
                return Ok(createSalaryDTO);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal Server {ex}. Please try again!");
            }
        }
        [HttpPut("{id:int}")]
        public async Task<IActionResult> Put(int id, UpdateSalaryDTO updateSalaryDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            try
            {
                var salaryNew = await _salaryService.UpdateSalary(id, updateSalaryDTO);
                return Ok(updateSalaryDTO);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
        [HttpDelete("{id:int}", Name = "DeleteById")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                await _salaryService.DeleteSalaryById(id);
                return Ok(new JsonResult($"Delete salary ID={id} successful"));
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

    }
}
