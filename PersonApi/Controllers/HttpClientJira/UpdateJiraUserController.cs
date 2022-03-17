using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PersonApi.DTO.Jira;
using PersonApi.Services.HttpClientService;

namespace PersonApi.Controllers.HttpClientJira
{
    [Route("api/[controller]")]
    [ApiController]
    public class UpdateJiraUserController : ControllerBase
    {
        private readonly IClientService _clientService;
        public UpdateJiraUserController(IClientService clientService)
        {
            _clientService = clientService;
        }

        [HttpPut]
        public async Task<IActionResult> IsactiveUser(string key, UpdateUserJira updateUserJira)
        {
          var result =   await _clientService.UpdateUser(key, updateUserJira);
            return Ok(result);
        }
    }
}
