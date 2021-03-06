using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PersonApi.Models;
using PersonApi.ModelsDTO;
using PersonApi.Services.AuthManager;

namespace PersonApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly UserManager<ApiUser> _userManager;
        private readonly ILogger<AccountController> _logger;
        private readonly IMapper _mapper;
        private readonly IAuthManager _authManager;
        public AccountController(UserManager<ApiUser> userManager,
                                 ILogger<AccountController> logger,
                                 IMapper mapper,
                                 IAuthManager authManager)
        {
            _userManager = userManager;
            _logger = logger;
            _mapper = mapper;
            _authManager = authManager;
        }
        [HttpPost]
        [Route("register")]
        public async Task<IActionResult> Register([FromBody] UserDTO userDTO)
        {
            _logger.LogInformation($"Registation attempt for {userDTO.Email}");
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                var user = _mapper.Map<ApiUser>(userDTO);
                user.UserName = userDTO.Email;
                var result = await _userManager.CreateAsync(user, userDTO.PassWord);
                if (!result.Succeeded)
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError(error.Code, error.Description);
                    }
                    return BadRequest(ModelState);
                }
                await _userManager.AddToRolesAsync(user, userDTO.Roles);
                return Accepted();
            }
            catch (Exception e)
            {
                _logger.LogError(e, $"Something went wrong in {nameof(Register)}");
                return Problem($"Something went wrong in {nameof(Register)}", statusCode: 500);
            }
        }
        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> Login([FromBody] LoginUserDTO loginUserDTO)
        {
            _logger.LogInformation($"Registation attempt for {loginUserDTO.Email}");
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                if (!await _authManager.ValidateUser(loginUserDTO))
                {
                    return Unauthorized();
                }
                return Accepted(new { Token = await _authManager.CreateToken() });
            }
            catch (Exception e)
            {
                _logger.LogError(e, $"Something went wrong in {nameof(Login)}");
                return Problem($"Something went wrong in {nameof(Login)}", statusCode: 500);
            }
        }
        [Authorize(Roles = "Administrator")]
        [HttpPut]
        [Route("UpdateUser")]
        public async Task<IActionResult> UpdateUser(string email, string password, [FromBody] UserDTO userDTO)
        {
            var user = await _userManager.FindByEmailAsync(email);
            _mapper.Map(userDTO, user);
            var check = await _userManager.CheckPasswordAsync(user, password);
            if (check)
            {
                var result = await _userManager.UpdateAsync(user);
                return Ok(result);
            }
            return BadRequest();
        }
        [HttpDelete]
        public async Task<IActionResult> Delete(string email, string password)
        {
            var result = await _authManager.DeleteUser(email, password);
            return Ok(result);
        }

    }
}
