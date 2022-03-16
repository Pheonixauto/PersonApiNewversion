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

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _jiraService.GetProjectInfor();
            return Ok(result);
        }

        [HttpGet("GetProjiects")]
        public async Task<IActionResult> GetProjiects()
        {
            var result = await _jiraService.GetProjects();
            return Ok(result);
        }

        [HttpGet("GetUser")]
        public async Task<IActionResult> GetUser()
        {
            var result = await _jiraService.GetUser();
            return Ok(result);
        }

        [HttpGet("GetUsers")]
        public async Task<IActionResult> GetUsers()
        {
            var result = await _jiraService.GetUsers();
            return Ok(result);
        }

        [HttpGet("GetUsersByGroups")]
        public async Task<IActionResult> GetUsersByGroups()
        {
            var result = await _jiraService.GetUsersByGroups();
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
