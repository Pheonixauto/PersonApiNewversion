using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PersonApi.Models;
using PersonApi.ModelsDTO;
using PersonApi.Services.Interfaces;

namespace PersonApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly IDepartmentService _departmentService;
        public DepartmentController(IDepartmentService departmentService)
        {
            _departmentService = departmentService;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var employeeList = await _departmentService.GetAllDepartment();
            return Ok(employeeList);
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> Get(int id)
        {
            var department = await _departmentService.GetDepartment(id);
            return Ok(department);
        }

        [HttpPost]
        public async Task<IActionResult> Post(CreateDepartmentDTO createDepartmentDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            await _departmentService.CreateDepartment(createDepartmentDTO);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Put(int id, UpdateDepartmentDTO updateDepartmentDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            await _departmentService.UpdateDepartment(id, updateDepartmentDTO);
            return Ok();
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _departmentService.DeleteDepartment(id);
            return Ok();
        }
    }
}
