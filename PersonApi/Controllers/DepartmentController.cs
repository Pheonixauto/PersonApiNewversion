using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PersonApi.Models;
using PersonApi.Models.FluentValidation;
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
        [ProducesResponseType(200)]
        public async Task<IActionResult> GetAll([FromQuery] RequestParams requestParams)
        {
            try
            {
                var employeeList = await _departmentService.GetDepartmentPagedList(requestParams);
                return Ok(employeeList);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpGet("{id:int}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        public async Task<IActionResult> Get(int id)
        {
            var department = await _departmentService.GetDepartment(id);
            return Ok(department);
        }

        //[Authorize(Roles = "Administrator")]
        [HttpPost]
        [ProducesResponseType(200)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(400)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> Post(CreateDepartmentDTO createDepartmentDTO)
        {
            DepartmentValidator validationRules = new DepartmentValidator();
            var validationResult = validationRules.Validate(createDepartmentDTO);
            if (!validationResult.IsValid)
            {
                return StatusCode(StatusCodes.Status400BadRequest, validationResult.Errors);
            }
            await _departmentService.CreateDepartment(createDepartmentDTO);
            return Ok();
        }

        //[Authorize(Roles = "Administrator")]
        [HttpPut("{id:int}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]

        public async Task<IActionResult> Put(int id, UpdateDepartmentDTO updateDepartmentDTO)
        {
            DepartmentValidator validationRules = new DepartmentValidator();
            var validationResult = validationRules.Validate(updateDepartmentDTO);
            if (!validationResult.IsValid)
            {
                return StatusCode(StatusCodes.Status400BadRequest, validationResult.Errors);
            }
            await _departmentService.UpdateDepartment(id, updateDepartmentDTO);
            return Ok();
        }

        [Authorize(Roles = "Administrator")]
        [HttpDelete("{id:int}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<IActionResult> Delete(int id)
        {
            await _departmentService.DeleteDepartment(id);
            return Ok();
        }
    }
}
