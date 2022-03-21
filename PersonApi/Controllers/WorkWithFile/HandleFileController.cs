using ClosedXML.Excel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PersonApi.Services.Interfaces;

using System.Text;

namespace PersonApi.Controllers.UpLoadFile
{
    [Route("api/[controller]")]
    [ApiController]
    public class HandleFileController : ControllerBase
    {
        private readonly IHandleFileService _handleFileService;
        private readonly ISalaryService _salaryService;
        public HandleFileController(IHandleFileService handleFileService, ISalaryService salaryService)
        {
            _handleFileService = handleFileService;
            _salaryService = salaryService;
        }
        [Authorize]
        [HttpPost("UpLoadFile")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UpLoadFileIntoDataBase(IFormFile file)
        {
            var result = await _handleFileService.AddEmployeeRelativeFromCSV(file);
            return Ok(result);
        }
        [HttpGet("DowloadFileCsv")]
        [Authorize]
        public async Task<IActionResult> FileStreamResultCsv()
        {
            var result = await _handleFileService.CreateFileSalary();

            var builder = new StringBuilder();
            builder.AppendLine("DateTime,Salary,Tax,EmployeeId");
            foreach (var item in result)
            {
                builder.AppendLine($"{item.DateTime},{item.Salary},{ item.Tax},{ item.EmployeeId}");
            }
            return File(Encoding.UTF8.GetBytes(builder.ToString()), "text/csv", "users.txt");
        }
        [HttpGet("DowloadFileExcelSalary")]
        [Authorize]
        public async Task<IActionResult> FileStreamResultExcelSalary()
        {
            var result = await _handleFileService.CreateFileSalary();
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Salaries");
                var currentRow = 1;
                worksheet.Cell(currentRow, 1).Value = "DateTime";
                worksheet.Cell(currentRow, 2).Value = "EmployeeId";
                worksheet.Cell(currentRow, 3).Value = "Salary";
                worksheet.Cell(currentRow, 4).Value = "Tax";
                foreach (var item in result)
                {
                    currentRow++;
                    worksheet.Cell(currentRow, 1).Value = item.DateTime;
                    worksheet.Cell(currentRow, 2).Value = item.EmployeeId;
                    worksheet.Cell(currentRow, 3).Value = item.Salary;
                    worksheet.Cell(currentRow, 4).Value = item.Tax;
                }
                using (var stream = new MemoryStream())
                {
                    workbook.SaveAs(stream);
                    var content = stream.ToArray();

                    return File(
                        content,
                        "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
                        "Salaries.xlsx");
                }
            }
        }
        [HttpGet("DowloadFileExcelSalaryDepartment")]
        [Authorize]
        public async Task<IActionResult> DowloadFileExcelSalaryDepartment(string departmentName, DateTime date1)
        {
            var result = await _salaryService.GetFileSalariesByDepartment(departmentName, date1);
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Salaries");
                var currentRow = 1;
                worksheet.Cell(currentRow, 1).Value = "DateTime";
                worksheet.Cell(currentRow, 2).Value = "EmployeeId";
                worksheet.Cell(currentRow, 3).Value = "Salary";
                worksheet.Cell(currentRow, 4).Value = "Tax";
                foreach (var item in result)
                {
                    currentRow++;
                    worksheet.Cell(currentRow, 1).Value = item.DateTime;
                    worksheet.Cell(currentRow, 2).Value = item.EmployeeId;
                    worksheet.Cell(currentRow, 3).Value = item.Salary;
                    worksheet.Cell(currentRow, 4).Value = item.Tax;
                }
                using (var stream = new MemoryStream())
                {
                    workbook.SaveAs(stream);
                    var content = stream.ToArray();

                    return File(
                        content,
                        "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
                        "Salaries.xlsx");
                }
            }
        }
        [HttpGet("DowloadFileExcelSalaryCompany")]
        [Authorize]
        public async Task<IActionResult> GetSalariesByCompany(DateTime date)
        {
            var result = await _handleFileService.GetSalariesOfCompanyByMonth(date);
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Salaries");
                var currentRow = 1;
                worksheet.Cell(currentRow, 1).Value = "DateTime";
                worksheet.Cell(currentRow, 2).Value = "EmployeeId";
                worksheet.Cell(currentRow, 3).Value = "Salary";
                worksheet.Cell(currentRow, 4).Value = "Tax";
                foreach (var item in result)
                {
                    currentRow++;
                    worksheet.Cell(currentRow, 1).Value = item.DateTime;
                    worksheet.Cell(currentRow, 2).Value = item.EmployeeId;
                    worksheet.Cell(currentRow, 3).Value = item.Salary;
                    worksheet.Cell(currentRow, 4).Value = item.Tax;
                }
                using (var stream = new MemoryStream())
                {
                    workbook.SaveAs(stream);
                    var content = stream.ToArray();
                    return File(
                        content,
                        "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
                        "Salaries.xlsx");
                }
            }
        }
    }
}
