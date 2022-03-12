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

       
    }
}
