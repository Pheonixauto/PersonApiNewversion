using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PersonApi.Services.Interfaces;

namespace PersonApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SearchController : ControllerBase
    {
        private readonly ISearchService _searchService;
        public SearchController(ISearchService searchService)
        {
            _searchService = searchService;
        }
        [HttpGet("GetInforEmployeeByName")]
        public async Task<IActionResult> GetInforByEmployeeName([FromQuery] string name)
        {
            var result = await _searchService.GetInforEmployee(name);
            return Ok(result);
        }

        [HttpGet("GetInforDepartmentByName")]
        public async Task<IActionResult> GetInforDepartmentByName([FromQuery] string name)
        {
            var result = await _searchService.GetInforDepartment(name);
            return Ok(result);
        }

        [HttpGet("GetInfor")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> GetInfor()
        {
       
            var result = await _searchService.GetEmployeeRelativeFromCSV();

            if (!result)
            {
                return BadRequest();
            }
            return Ok(result);
        }
    }
}
