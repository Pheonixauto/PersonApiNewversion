using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PersonApi.Controllers.UpLoadFile
{
    [Route("api/[controller]")]
    [ApiController]
    public class UploadFileController : ControllerBase
    {
        private readonly IWebHostEnvironment _webHostEnvironment;
        public UploadFileController(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }

        [HttpPost]
        public async Task<IActionResult> UploadFile(IFormFile file)
        {
            string directoryPath = Path.Combine(_webHostEnvironment.ContentRootPath, "UploadFiles"); ;
            if (!Directory.Exists(directoryPath))
                Directory.CreateDirectory(directoryPath);
            FileInfo fileInfo = new FileInfo(file.FileName);
            var fullPath = Path.Combine(directoryPath, fileInfo.Name);
            if (!System.IO.File.Exists(fullPath))
            {
                using (FileStream fileStream = new FileStream(fullPath, FileMode.Create))
                {
                    await file.CopyToAsync(fileStream);
                }
                return new JsonResult(new { FileName = fileInfo.Name });
            }
            return BadRequest();
        }
    }
}
