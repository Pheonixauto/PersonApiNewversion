using Microsoft.AspNetCore.Mvc;
using PersonApi.ModelsDTO;
using PersonApi.Repository.Repositories.Interfaces;

namespace PersonApi.Services.Interfaces
{
    public interface IHandleFileService 
    {
        Task<bool> AddEmployeeRelativeFromCSV(IFormFile file);
        Task<IEnumerable<CreateSalaryDTO>> GetSalariesOfCompanyByMonth(DateTime month); 


        Task<List<CreateSalaryDTO>> CreateFileSalary();   
    }
}
