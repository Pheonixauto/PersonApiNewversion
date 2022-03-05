using PersonApi.Models;
using PersonApi.ModelsDTO;
using X.PagedList;

namespace PersonApi.Services.Interfaces
{
    public interface ISalaryService
    {
        Task<List<InformationSalary>> GetAllSalary();
        Task<InformationSalary> GetSalaryById(int id);
        Task<bool> CreateSalary(CreateSalaryDTO createSalaryDTO);
        Task<bool> UpdateSalary(int id, UpdateSalaryDTO updateSalaryDTO);
        Task<bool> DeleteSalaryById(int id);
        ///////
        Task<IPagedList<InformationSalary>> GetSalaryPagedList(RequestParams requestParams);
        Task<List<InformationSalary>> GetSalaryByDate(DateTime date1 , DateTime date2);
        Task<object> GetSalaryByDepartment(string departmentName, DateTime date1, DateTime date2);

    }
}
