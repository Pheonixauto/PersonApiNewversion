using Atlassian.Jira;
using Microsoft.AspNetCore.Authorization;
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
        [Authorize(Roles = "Administrator")]
        [HttpGet("GetProjiects")]
        public async Task<IActionResult> GetProjiects(string account, string password)
        {
            var result = await _jiraService.GetProjects(account, password);
            return Ok(result);
        }
        [HttpGet("GetUsers")]
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> GetUsers(string account, string password, string member)
        {
            var result = await _jiraService.GetUsers(account, password, member);
            return Ok(result);
        }
        [HttpPost("CreateUser")]
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> CreateUser(string account,
                                                    string password,
                                                    [FromQuery] JiraUserCreationInfo jiraUserCreationInfo)
        {
            var result = await _jiraService.CreateUser(account, password, jiraUserCreationInfo);
            return Ok(result);
        }
    }
}
