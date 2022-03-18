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

        //  danh sách lương theo ngày tháng của toàn công ty
        Task<List<InformationSalary>> GetSalaryByDate(DateTime date1, DateTime date2);

        // danh sách lương theo phòng ban và ngày tháng
        Task<object> GetSalaryByDepartment(string departmentName, DateTime date1, DateTime date2);

        // tổng hợp lương công ty theo phòng ban
        Task<object> GetSalaryCompany(DateTime date1);

        // danh sách lương cá nhân
        Task<object> GetEmployeeSalary(int identityNumber);

        Task<IEnumerable<CreateSalaryDTO>> GetFileSalariesByDepartment(string departmentName, DateTime date);



    }
}
