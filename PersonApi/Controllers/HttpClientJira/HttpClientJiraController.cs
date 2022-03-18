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
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            List<string> account = new List<string> { "4ymFi38BYn3GWoLXPw2O7964" };
            var httpClient = _clientFactory.CreateClient();
            using (var response = await httpClient.GetAsync("https://automationtechnologysolution.atlassian.net", HttpCompletionOption.ResponseHeadersRead))
            {
                response.EnsureSuccessStatusCode();
                var stream = await response.Content.ReadAsStreamAsync();
                var companies = await JsonSerializer.DeserializeAsync<List<object>>(stream, _options);
                return Ok(companies);
            }
        }
        [HttpGet("testmy")]
        public async Task<IActionResult> Gettest()
        {
            var re = await _clientService.Testmyjira();
            return Ok(re);
        }

        [HttpGet("testlogincompany")]
        public async Task<IActionResult> logincopany()
        {
            var re = await _clientService.Logincompanyjira();
            return Ok(re);
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

        [HttpPut]
        public async Task<IActionResult> IsactiveUser(string key, UpdateUserJira updateUserJira)
        {
            var result = await _clientService.UpdateUser(key, updateUserJira);
            return Ok(result);
        }
    }
}
