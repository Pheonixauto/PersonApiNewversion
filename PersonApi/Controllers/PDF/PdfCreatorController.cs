using DinkToPdf;
using DinkToPdf.Contracts;
using Microsoft.AspNetCore.Mvc;
using PersonApi.Services.Interfaces;

namespace PersonApi.Controllers.PDF
{
    [Route("api/[controller]")]
    [ApiController]
    public class PdfCreatorController : ControllerBase
    {
        private IConverter _converter;
        private IHandleFilePdfService _handleFilePdf;
        public PdfCreatorController(IConverter converter, IHandleFilePdfService handleFilePdf)
        {
            _converter = converter;
            _handleFilePdf = handleFilePdf;
        }
        [HttpGet("{id:int}")]
        public async Task<IActionResult> getPdf(int id)
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
                HtmlContent = await _handleFilePdf.GetHtmlStringOfFileSalary(id),
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
            return File(file, "application/pdf");
            //return Ok("Successfully");
        }
    }
}
