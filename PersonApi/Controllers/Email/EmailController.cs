using EmailService;
using Microsoft.AspNetCore.Mvc;

namespace PersonApi.Controllers.Email
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailController : ControllerBase
    {
        private readonly IEmailSender _emailSender;
        public EmailController(IEmailSender emailSender)
        {
            _emailSender = emailSender;
        }
        [HttpGet]
        public async Task<IActionResult> get()
        {
            var message = new Message(new string[] { "thanhthai2604@gmail.com" }, "Test async", "From Asp.net Core",null!);
            await _emailSender.SendEmailAsync(message);
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> post(IFormFileCollection file)
        { 
            
            var message = new Message(new string[] { "thanhthai2604@gmail.com" }, "Test async with file", "From Asp.net Core", file);
            await _emailSender.SendEmailAsync(message);
            return Ok();
        }
    }
}
