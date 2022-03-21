using PersonApi.Models;
using PersonApi.ModelsDTO;

namespace PersonApi.Services.Interfaces
{
    public interface ISkillService
    {
        Task<List<InforSkill>> GetAllSkill();
        Task<InforSkill> GetSkill(int skillId);
        Task<InforSkill> CreateSkill(CreateSkillDTO  createSkillDTO); 
        Task<bool> UpdateSkill(int skillId ,UpdateSkillDTO updateSkillDTO);
        Task<bool> DeleteSkill(int skillId);

      
    }
}
