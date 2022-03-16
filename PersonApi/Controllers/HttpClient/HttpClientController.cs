using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PersonApi.Services.HttpClientService;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;

namespace PersonApi.Controllers.HttpClient
{
    [Route("api/[controller]")]
    [ApiController]
    public class HttpClientController : ControllerBase
    {
        private readonly IHttpClientFactory _clientFactory;
        private readonly JsonSerializerOptions _options;

        private readonly IClientService _clientService;
        public HttpClientController(IHttpClientFactory clientFactory, IClientService clientService)
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
        [HttpGet("test")]
        public async Task<IActionResult> Gettest()
        {
           var re=  await _clientService.Test();
            return Ok(re);
        }

    }
}
