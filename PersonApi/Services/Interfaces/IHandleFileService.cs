using PersonApi.ModelsDTO;
using PersonApi.Repository.Repositories.Interfaces;

namespace PersonApi.Services.Interfaces
{
    public interface IHandleFileService 
    {
        Task<bool> AddEmployeeRelativeFromCSV(IFormFile file);           
        Task<List<CreateSalaryDTO>> CreateFileSalary();   
    }
}
