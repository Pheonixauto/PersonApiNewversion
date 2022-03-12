using PersonApi.Repository.Repositories.Interfaces;

namespace PersonApi.Services.Interfaces
{
    public interface IHandleFileService 
    {
        Task<bool> GetEmployeeRelativeFromCSV(string path);
        
        Task<string> HandleFile(IFormFile file);
    }
}
