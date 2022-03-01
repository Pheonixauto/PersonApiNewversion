using AutoMapper;
using PersonApi.Models;
using PersonApi.ModelsDTO;
using PersonApi.Repository.UnitOfWork;
using PersonApi.Services.Interfaces;

namespace PersonApi.Services
{
    public class SkillService : ISkillService
    {
        public IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public SkillService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<List<InformationSkill>> GetAllSkill()
        {
            var skills = await _unitOfWork.SkillRepository.GetAll();
            return (List<InformationSkill>)skills;
        }

        public async Task<InformationSkill> GetSkill(int skillId)
        {
            if (skillId > 0)
            {
                var skill = await _unitOfWork.SkillRepository.Get(skillId);
                return (InformationSkill)skill;
            }
            return null;

        }

        public async Task<InformationSkill> CreateSkill(CreateSkillDTO createSkillDTO)
        {
            var skill = _mapper.Map<InformationSkill>(createSkillDTO);
            await _unitOfWork.SkillRepository.Add(skill);
            var result = _unitOfWork.Complete();
            if (result > 0)
            {
                return skill;
            }
            else return null;

        }

        public async Task<bool> UpdateSkill(int skillId, UpdateSkillDTO updateSkillDTO)
        {
            if (skillId > 0)
            {
                var skill = await _unitOfWork.SkillRepository.Get(skillId);
                if (skill != null)
                {
                    _mapper.Map(updateSkillDTO, skill);
                    _unitOfWork.SkillRepository.Update(skill);
                    var result = _unitOfWork.Complete();
                    if (result > 0)
                    {
                        return true;
                    }
                    else return false;
                }
            }
            return false;
        }

        public async Task<bool> DeleteSkill(int skillId)
        {
            if (skillId > 0)
            {
                var skill = await _unitOfWork.SkillRepository.Get(skillId);
                _unitOfWork.SkillRepository.Delete(skill);
                var result = _unitOfWork.Complete();
                if (result > 0)
                {
                    return true;
                }
                else return false;
            }
            return false;
        }
    }
}
