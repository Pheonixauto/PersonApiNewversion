using DinkToPdf;
using DinkToPdf.Contracts;
using PersonApi.Repository.UnitOfWork;
using PersonApi.Services.Interfaces;
using System.Text;

namespace PersonApi.Services
{
    public class HandleFilePdfService : IHandleFilePdfService
    {
        private readonly IUnitOfWork _unitOfWork;
        private IConverter _converter;

        public HandleFilePdfService(IUnitOfWork unitOfWork, IConverter converter)
        {
            _unitOfWork = unitOfWork;
            _converter = converter;
        }

        public async Task<byte[]> GetFilePdf(int employeeid, DateTime date)
        {
            var globalSettings = new GlobalSettings
            {
                ColorMode = ColorMode.Color,
                Orientation = Orientation.Portrait,
                PaperSize = PaperKind.A4,
                Margins = new MarginSettings { Top = 10 },
                DocumentTitle = "PDF Report",
                //Out = @"D:\PDFCreators\SalaryReport.pdf"
            };
            var objectSettings = new ObjectSettings
            {
                PagesCount = true,
                HtmlContent = await GetHtmlStringOfFileSalary(employeeid, date),
                WebSettings = { DefaultEncoding = "utf-8", UserStyleSheet = Path.Combine(Directory.GetCurrentDirectory(), "Assets", "Styles.css") },
                HeaderSettings = { FontName = "Arial", FontSize = 9, Right = "Page[page]of[toPage]", Line = true },
                FooterSettings = { FontName = "Arial", FontSize = 9, Line = true, Center = "Report Footer" }
            };
            var pdf = new HtmlToPdfDocument
            {
                GlobalSettings = globalSettings,
                Objects = { objectSettings }
            };
            var file = _converter.Convert(pdf);
            return file;
        }

        public async Task<string> GetHtmlStringOfFileSalary(int employeeId, DateTime date)
        {
            var salaries = await _unitOfWork.SalaryRepository.GetAllAsync(expression:x => (x.EmployeeId == employeeId)&& (x.DateTime.Month==date.Month));
            var sb = new StringBuilder();
            sb.Append(@"
                        <html>
                            <head>
                            </head>
                            <body>
                                  <div class='header'>
                                       <h1>This is the Generated PDF Report </h1>
                                  </div>
                                  <table align='center'>
                                        <tr>
                                            <th> Id </th>
                                            <th> Salary </th>
                                            <th> DateTime </th>
                                            <th> Tax </th>
                                            <th> EmployeeId </th>                                            
                                        </tr>
                       
                      ");
            foreach (var salary in salaries)
            {
                sb.AppendFormat(@"
                                <tr>
                                   <td>{0}</td>
                                   <td>{1}</td>
                                   <td>{2}</td>
                                   <td>{3}</td>
                                   <td>{4}</td>
                                </tr>
                                ", salary.Id, salary.Salary, salary.DateTime, salary.Tax, salary.EmployeeId);
            }
            sb.Append(@"           </table>
                            </body>
                        </html>");
            return sb.ToString();
        }
    }
}
