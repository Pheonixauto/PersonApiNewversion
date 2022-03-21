using PersonApi.Models;
using PersonApi.ModelsDTO;
using X.PagedList;

namespace PersonApi.Services.Interfaces
{
    public interface IDepartmentService 
    {
        Task<List<InforDepartment>> GetAllDepartment();
        Task<InforDepartment> GetDepartment(int id);
        Task<bool> CreateDepartment(CreateDepartmentDTO  createDepartmentDTO);
        Task<bool> UpdateDepartment(int id, UpdateDepartmentDTO updateDepartmentDTO);
        Task <bool> DeleteDepartment(int id);
        //////////////////////////////
        Task<IPagedList<InforDepartment>> GetDepartmentPagedList(RequestParams requestParams);

    }
}
