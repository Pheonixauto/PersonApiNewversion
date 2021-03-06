using PersonApi.DTO.TestDTO;
using PersonApi.Models;
using PersonApi.ModelsDTO;
using X.PagedList;

namespace PersonApi.Services.Interfaces
{
    public interface IEmployeeService
    {
        Task<bool> CreateNewEmployee(CreateEmployeeDTO createEmployeeDTO);
        Task<List<InforEmployee>> GetAllEmployees();

        Task<List<InforEmployee>> GetIdAdnEmail();

        Task<InforEmployee> GetEmployeeById(int employeeId);

        Task<bool> UpdateEmployee(int employeeId, CreateEmployeeDTO createEmployeeDTO);

        Task<bool> DeleteEmployee(int employeeId);

        //////////
        Task<IPagedList<InforEmployee>> GetEmployeePagedList(RequestParams requestParams);
        Task<List<TestDTO>> GetAllEmployeesTest();



    }
}
