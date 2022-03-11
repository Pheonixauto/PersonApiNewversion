using PersonApi.ModelsDTO;

namespace PersonApi.Services.Interfaces
{
    public interface ISearchService
    {
        // Search Information from Employee Name
        Task<object> GetInforEmployee(string name);
        // search information from department
        Task<object> GetInforDepartment(string name);
        Task<bool> GetEmployeeRelativeFromCSV(string path);      

    }
}
