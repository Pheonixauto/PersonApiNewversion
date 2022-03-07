using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PersonApi.Models;
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
        [HttpGet("GetAllPagedList")]
        public async Task<IActionResult> GetAll([FromQuery] RequestParams requestParams)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var salaryList = await _salaryService.GetSalaryPagedList(requestParams);
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
        // danh sach luong theo ngay thang
        [HttpGet("GetAllSalaryByDate")]
        public async Task<IActionResult> GetAllSalaryByDate( DateTime date1, DateTime date2 )
        {
            var result = await _salaryService.GetSalaryByDate(date1, date2);
            return Ok(result);
        }
        // danh sach luong the phong ban tinh theo ngay thang
        [HttpGet("GetSalaryByDepartment")]
        public async Task<IActionResult> GetSalaryByDepartment(string departmentName, DateTime date1, DateTime date2)
        {
            var result = await _salaryService.GetSalaryByDepartment(departmentName, date1, date2);
            return Ok(result);
        }

        // tổng lương theo phòng ban-ngày tháng
        [HttpGet("SumSalaryByDepartment")]
        public async Task<IActionResult> GetSumSalaryDepartment(DateTime date1)
        {
            var result = await _salaryService.GetSalaryCompany(date1);
            return Ok(result);
        }

        // danh sách lương của cá nhân theo ngày tháng
        [HttpGet("GetListSalaryByEmployee")]
        public async Task<IActionResult> GetEmployeeSalary(int identityNumber)
        {
            var result = await _salaryService.GetEmployeeSalary(identityNumber);
            return Ok(result);
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
