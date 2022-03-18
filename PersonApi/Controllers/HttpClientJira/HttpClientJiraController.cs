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
        [HttpGet("getmyselfcompany")]
        public async Task<IActionResult> getmyselfcompany()
        {
            var re = await _clientService.Getmyselfcompanyjira();
            return Ok(re);
        }
        [HttpGet("GetInforProjectByUser")]
        public async Task<IActionResult> GetInforProjectByUser(string userName)
        {
            var re = await _clientService.GetAllKeysProjects();

            var result = await _clientService.CheckInforProjectByUser(userName, re);

            return Ok(result);
        }

        [HttpPut("IsActiveUser")]
        public async Task<IActionResult> IsactiveUser(string key, UpdateUserJira updateUserJira)
        {
            var result = await _clientService.UpdateUser(key, updateUserJira);
            return Ok(result);
        }
    }
}
