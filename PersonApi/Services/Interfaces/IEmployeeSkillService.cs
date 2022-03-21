using PersonApi.DTO;
using PersonApi.Models;

namespace PersonApi.Services.Interfaces
{
    public interface IEmployeeSkillService
    {
        Task<List<InforEmployeeSkill>> GetAllEmployeeSkill();
 
        Task<List<InforEmployeeSkill>> GetEmployeeSkillById(int id);
        Task<List<InforEmployeeSkill>> GetAllDetail();
        Task<object> GetNameSkillEmployee();

        Task<bool> AddEmployeeSkill(CreateEmployeeSkillDTO createEmployeeSkillDTO);

        // nhân viên theo skill, rating
        Task<object> GetEmployeeBySkill(string skillName);
        Task<object> GetEmployeeByRating(double rating);

    }
}
