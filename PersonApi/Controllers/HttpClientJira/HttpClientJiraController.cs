using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PersonApi.DTO.Jira;
using PersonApi.Services.HttpClientService;
using System.Text.Json;

namespace PersonApi.Controllers.HttpClient
{
    [Route("api/[controller]")]
    [ApiController]
    public class HttpClientJiraController : ControllerBase
    {
        private readonly IHttpClientFactory _clientFactory;
        private readonly JsonSerializerOptions _options;
        private readonly IClientService _clientService;
        public HttpClientJiraController(IHttpClientFactory clientFactory, IClientService clientService)
        {
            _clientFactory = clientFactory;
            _options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            _clientService = clientService;
        }
        [Authorize(Roles = "Administrator")]
        [HttpGet("getmyselfcompany")]
        public async Task<IActionResult> getmyselfcompany(string account,
                                                          string password, string member)
        {
            var re = await _clientService.Getmyselfcompanyjira(account, password, member);
            return Ok(re);
        }
        [Authorize(Roles = "Administrator")]
        [HttpGet("GetInforProjectByUser")]
        public async Task<IActionResult> GetInforProjectByUser(string account,
                                                               string password, string member)
        {
            var re = await _clientService.GetAllKeysProjects(account, password);

            var result = await _clientService.CheckInforProjectByUser(account, password,
                                                                      member, re);

            return Ok(result);
        }
        [Authorize(Roles = "Administrator")]
        [HttpPut("IsActiveUser")]
        public async Task<IActionResult> IsactiveUser(string account,
                                                      string password,
                                                      string userKey,
                                                      UpdateUserJira updateUserJira)
        {
            var result = await _clientService.UpdateUser(account, password, userKey, updateUserJira);
            return Ok(result);
        }
    }
}
