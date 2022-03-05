using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PersonApi.Models;
using PersonApi.ModelsDTO;
using PersonApi.Services.Interfaces;

namespace PersonApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RelativeController : ControllerBase
    {
        private IRelativeService _relativeService;
        public RelativeController(IRelativeService relativeService)
        {
            _relativeService = relativeService;
        }
        [HttpGet("GetAllPagedList")]
        public async Task<IActionResult> GetAll([FromQuery] RequestParams requestParams)
        {
            return Ok(await _relativeService.GetRelativePagedList(requestParams));
        }
        [HttpGet("{id:int}")]
        public async Task<IActionResult> Get(int id)
        {
            var relative = await _relativeService.GetRelativeById(id);
            if (relative == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(relative);
            }
        }
        [HttpPost]
        public async Task<IActionResult> Post(CreateRelativeDTO createRelativeDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var result = await _relativeService.CreateRelative(createRelativeDTO);
            if (!result)
            {
                return BadRequest();
            }
            return Ok(createRelativeDTO);
        }
        [HttpPut("{id:int}")]
        public async Task<IActionResult> Put(int id, UpdateRelativeDTO updateRelativeDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var result = await _relativeService.UpDateRelative(id, updateRelativeDTO);
            if (!result)
                return BadRequest();
            return Ok(updateRelativeDTO);
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> DeleteById(int id)
        {
            await _relativeService.DeleteRelativeById(id);
            return Ok(new JsonResult($"Delete Relative have ID={id} successful"));
        }
    }
}
