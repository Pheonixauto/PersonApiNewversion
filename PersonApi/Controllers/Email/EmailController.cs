using EmailService;
using Microsoft.AspNetCore.Mvc;
using PersonApi.Services.Interfaces;

namespace PersonApi.Controllers.Email
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailController : ControllerBase
    {
        private readonly IEmailSender _emailSender;
        private readonly IHandleFilePdfService _handleFilePdfService;
        private readonly IEmployeeService _employeeService;
        public EmailController(IEmailSender emailSender, IHandleFilePdfService handleFilePdfService, IEmployeeService employeeService)
        {
            _emailSender = emailSender;
            _handleFilePdfService = handleFilePdfService;
            _employeeService = employeeService;
        }
        [HttpGet]
        public async Task<IActionResult> get([FromQuery] DateTime date)
        {
            var result = await _employeeService.GetIdAdnEmail();

            foreach (var item in result)
            {
                var file = await _handleFilePdfService.GetFilePdf(item.Id,date);
                var message = new Message(new string[] { item.Email! }, "test async", "from asp.net core", file);
                await _emailSender.SendEmailAsync(message);

            }

            //var file = await _handleFilePdfService.GetFilePdf(employeeid);
            //var message = new Message(new string[] { a }, "test async", "from asp.net core", file);
            //await _emailSender.SendEmailAsync(message);



            return Ok();
        }

        //[HttpPost]
        //public async Task<IActionResult> post(IFormFileCollection file)
        //{ 

        //    var message = new Message(new string[] { "thanhthai2604@gmail.com" }, "Test async with file", "From Asp.net Core", file);
        //    await _emailSender.SendEmailAsync(message);
        //    return Ok();
        //}
    }
}
