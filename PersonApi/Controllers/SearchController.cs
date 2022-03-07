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
        [HttpGet("GetInforByDynamic")]
        public async Task<IActionResult> GetInforBySomething([FromQuery] string something)
        {
            var result = await _searchService.GetInfor(something);
            return Ok(result);
        }
    }
}
