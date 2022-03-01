using PersonApi.Models;
using PersonApi.ModelsDTO;

namespace PersonApi.Services.Interfaces
{
    public interface IDepartmentService 
    {
        Task<List<InformationDepartment>> GetAllDepartment();
        Task<InformationDepartment> GetDepartment(int id);
        Task<bool> CreateDepartment(CreateDepartmentDTO  createDepartmentDTO);
        Task<bool> UpdateDepartment(int id, UpdateDepartmentDTO updateDepartmentDTO);
        Task <bool> DeleteDepartment(int id);
    }
}
