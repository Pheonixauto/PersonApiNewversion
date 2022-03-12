using Microsoft.AspNetCore.Mvc;
using PersonApi.Services.Interfaces;

namespace PersonApi.Controllers.UpLoadFile
{
    [Route("api/[controller]")]
    [ApiController]
    public class UploadFileController : ControllerBase
    {
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly IHandleFileService _handleFileService;
        public UploadFileController(IWebHostEnvironment webHostEnvironment, IHandleFileService handleFileService)
        {
            _webHostEnvironment = webHostEnvironment;
            _handleFileService = handleFileService;
        }

        //[HttpPost]
        //public async Task<IActionResult> UploadFile(IFormFile file)
        //{
        //    //string directoryPath = Path.Combine(_webHostEnvironment.ContentRootPath, "UploadFiles"); ;
        //    //if (!Directory.Exists(directoryPath))
        //    //    Directory.CreateDirectory(directoryPath);
        //    //FileInfo fileInfo = new FileInfo(file.FileName);
        //    //var fullPath = Path.Combine(directoryPath, fileInfo.Name);
        //    //if (!System.IO.File.Exists(fullPath))
        //    //{
        //    //    using (FileStream fileStream = new FileStream(fullPath, FileMode.Create))
        //    //    {
        //    //        await file.CopyToAsync(fileStream);
        //    //    }
        //    //    return new JsonResult(new { FileName = fileInfo.Name });
        //    //}
        //    //var path = await _handleFileService.HandleFile(file);
        //    //return BadRequest();
        //}
        [HttpPost("GetInfor")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> PostInfor(IFormFile file)
        {
            var path = await _handleFileService.HandleFile(file);
            if (path == string.Empty)
            {
                return BadRequest();
            }
            var result = await _handleFileService.GetEmployeeRelativeFromCSV(path);
            return Ok(result);
        }
    }
}
