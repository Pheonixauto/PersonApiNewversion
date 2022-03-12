using PersonApi.ModelsDTO;
using PersonApi.Repository.Repositories.Interfaces;

namespace PersonApi.Services.Interfaces
{
    public interface IHandleFileService 
    {
        Task<bool> AddEmployeeRelativeFromCSV(string path);      
        Task<string> ImportFileCsv(IFormFile file);
        Task<bool> CreateFileSalary();

    }
}
