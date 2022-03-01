using AutoMapper;
using PersonApi.Models;
using PersonApi.ModelsDTO;
using PersonApi.Repository.UnitOfWork;
using PersonApi.Services.Interfaces;

namespace PersonApi.Services
{
    public class LearningService : ILearningService
    {
        public IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public LearningService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<List<InformationLearning>> GetAllLearning()
        {
            var learningList = await _unitOfWork.LearningRepository.GetAll();
            return (List<InformationLearning>)learningList;
        }

        public async Task<InformationLearning> GetLearning(int id)
        {
            if (id > 0)
            {
                var learning = await _unitOfWork.LearningRepository.Get(id);
                if (learning == null) { return null; }
                return learning;
            }
            return null;
        }

        public async Task<bool> CreateLearning(CreateLearningDTO learning)
        {
            var learningMap = _mapper.Map<InformationLearning>(learning);
            await _unitOfWork.LearningRepository.Add(learningMap);
            var result = _unitOfWork.Complete();
            if (result > 0)
            {
                return true;
            }
            else return false;
        }
        public async Task<bool> UpdateLearning(int id, UpdateLearningDTO learningDTO)
        {
            if (id > 0)
            {
                var learning = await _unitOfWork.LearningRepository.Get(id);
                var learningMap = _mapper.Map(learningDTO, learning);
                _unitOfWork.LearningRepository.Update(learningMap);
                var result = _unitOfWork.Complete();
                if (result > 0)
                {
                    return true;
                }
                else return false;
            }
            return false;
        }

        public async Task<bool> DeleteLearning(int id)
        {
            if (id > 0)
            {
                var learning = await _unitOfWork.LearningRepository.Get(id);
                _unitOfWork.LearningRepository.Delete(learning);
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
