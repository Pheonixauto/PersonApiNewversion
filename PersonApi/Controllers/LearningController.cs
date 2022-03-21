using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PersonApi.ModelsDTO;
using PersonApi.Services.Interfaces;

namespace PersonApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LearningController : ControllerBase
    {
        protected ILearningService _learningService;
        public LearningController(ILearningService learningService)
        {
            _learningService = learningService;
        }
        [Authorize(Roles = "Administrator")]
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var learnings = await _learningService.GetAllLearning();
            return Ok(learnings);
        }
        [Authorize(Roles = "Administrator")]
        [HttpGet("{id:int}")]
        public async Task<IActionResult> Get(int id)
        {
            var result = await _learningService.GetLearning(id);
            return Ok(result);
        }
        [Authorize(Roles = "Administrator")]
        [HttpPost]
        public async Task<IActionResult> Post(CreateLearningDTO learning)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            await _learningService.CreateLearning(learning);
            return Ok(learning);
        }
        [Authorize(Roles = "Administrator")]
        [HttpPut("{id:int}")]
        public async Task<IActionResult> Put(int id, UpdateLearningDTO learningDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            await _learningService.UpdateLearning(id, learningDTO);
            return Ok(learningDTO);
        }
        [Authorize(Roles = "Administrator")]
        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _learningService.DeleteLearning(id);
            return Ok(new JsonResult($"Delete {id} successful"));
        }
    }
}
