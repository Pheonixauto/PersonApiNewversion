using Microsoft.AspNetCore.Mvc;
using PersonApi.Services.Interfaces;

namespace PersonApi.Controllers.UpLoadFile
{
    [Route("api/[controller]")]
    [ApiController]
    public class HandleFileController : ControllerBase
    {
        private readonly IHandleFileService _handleFileService;
        public HandleFileController(IHandleFileService handleFileService)
        {
            _handleFileService = handleFileService;
        }
        [HttpPost("UpLoadFile")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpLoadFileIntoDataBase(IFormFile file)
        {
            var path = await _handleFileService.ImportFileCsv(file);
            if (path == string.Empty)
            {
                return BadRequest();
            }
            var result = await _handleFileService.AddEmployeeRelativeFromCSV(path);
            return Ok(result);
        }

        [HttpGet("DowloadFile")]
        public ActionResult Download(string fileName)
        {
            var path = @"D:\ATSProject\PersonApi\PersonApi\HandleFile\CreateFileCsv\Salary.csv";
            return PhysicalFile(path, "text/csv", fileName);
        }

        [HttpGet("CreateFileCsv")]
        public async Task<IActionResult> CreateFileCsv()
        {
            var result = await _handleFileService.CreateFileSalary();
            return Ok(result);
        }
    }
}
