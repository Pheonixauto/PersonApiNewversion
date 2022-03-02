using PersonApi.Models;
using PersonApi.ModelsDTO;

namespace PersonApi.Services.Interfaces
{
    public interface ISalaryService
    {
        Task<List<InformationSalary>> GetAllSalary();
        Task<InformationSalary> GetSalaryById(int id);
        Task<bool> CreateSalary(CreateSalaryDTO createSalaryDTO);
        Task<bool> UpdateSalary(int id, UpdateSalaryDTO updateSalaryDTO);
        Task<bool> DeleteSalaryById(int id);
    }
}
