using PersonApi.Models;

namespace PersonApi.Services.Interfaces
{
    public interface IHandleFilePdfService
    {
        Task<string> GetHtmlStringOfFileSalary(int employeeId, DateTime date);
        Task<byte[]> GetFilePdf(int id, DateTime date);
    }
}
