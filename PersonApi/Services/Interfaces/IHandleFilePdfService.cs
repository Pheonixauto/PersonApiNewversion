using PersonApi.Models;

namespace PersonApi.Services.Interfaces
{
    public interface IHandleFilePdfService
    {
        Task<string> GetHtmlStringOfFileSalary(int id);
    }
}
