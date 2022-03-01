using PersonApi.Models;
using PersonApi.ModelsDTO;

namespace PersonApi.Services.Interfaces
{
    public interface ISkillService
    {
        Task<List<InformationSkill>> GetAllSkill();
        Task<InformationSkill> GetSkill(int skillId);
        Task<InformationSkill> CreateSkill(CreateSkillDTO  createSkillDTO); 
        Task<bool> UpdateSkill(int skillId ,UpdateSkillDTO updateSkillDTO);
        Task<bool> DeleteSkill(int skillId);
    }
}
