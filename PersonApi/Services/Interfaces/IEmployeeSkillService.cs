using PersonApi.Models;

namespace PersonApi.Services.Interfaces
{
    public interface IEmployeeSkillService
    {
        Task<List<InformationEmployeeSkill>> GetAllEmployeeSkill();
 
        Task<List<InformationEmployeeSkill>> GetEmployeeSkillById(int id);
        Task<List<InformationEmployeeSkill>> GetAllDetail();

        Task<object> GetNameSkillEmployee();

    }
}
