using PersonApi.Models;
using PersonApi.ModelsDTO;
using X.PagedList;

namespace PersonApi.Services.Interfaces
{
    public interface IEmployeeService
    {
        Task<bool> CreateNewEmployee(CreateEmployeeDTO createEmployeeDTO);
        Task<List<InformationEmployee>> GetAllEmployees();

        Task<InformationEmployee> GetEmployeeById(int employeeId);

        Task<bool> UpdateEmployee(int employeeId, CreateEmployeeDTO createEmployeeDTO);

        Task<bool> DeleteEmployee(int employeeId);

        //////////
        Task<IPagedList<InformationEmployee>> GetEmployeePagedList(RequestParams requestParams);
    }
}
