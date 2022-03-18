using Atlassian.Jira;
using Microsoft.AspNetCore.Mvc;
using PersonApi.Services.Interfaces;

namespace PersonApi.Controllers.Jira
{
    [Route("api/[controller]")]
    [ApiController]
    public class JiraController : ControllerBase
    {
        private readonly IJiraService _jiraService;
        public JiraController(IJiraService jiraService)
        {
            _jiraService = jiraService;
        }

        [HttpGet("GetProjiectInfor")]
        public async Task<IActionResult> GetProjiectInfor()
        {
            var result = await _jiraService.GetProjiectInfor();
            return Ok(result);
        }
        [HttpGet("GetProjiects")]
        public async Task<IActionResult> GetProjiects()
        {
            var result = await _jiraService.GetProjects();
            return Ok(result);
        }
        [HttpGet("GetUsers")]
        public async Task<IActionResult> GetUsers()
        {
            var result = await _jiraService.GetUsers();
            return Ok(result);
        }    
        [HttpPost("CreateUser")]
        public async Task<IActionResult> CreateUser([FromQuery] JiraUserCreationInfo jiraUserCreationInfo)
        {
            var result = await _jiraService.CreateUser(jiraUserCreationInfo);
            return Ok(result);
        }
    }
}
