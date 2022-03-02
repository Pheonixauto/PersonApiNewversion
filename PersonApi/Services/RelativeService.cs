using AutoMapper;
using PersonApi.Models;
using PersonApi.ModelsDTO;
using PersonApi.Repository.UnitOfWork;
using PersonApi.Services.Interfaces;

namespace PersonApi.Services
{
    public class RelativeService : IRelativeService
    {
        public IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public RelativeService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<List<InformationRelative>> GetAllRelative()
        {
            var relativeList = await _unitOfWork.RelativeRepository.GetAll();
            return (List<InformationRelative>)relativeList;
        }

        public async Task<InformationRelative> GetRelativeById(int id)
        {
            if (id > 0)
            {
                var relative = await _unitOfWork.RelativeRepository.Get(id);
                if (relative == null)
                {
                    return null;
                }
                return relative;
            }
            return null;
        }

        public async Task<bool> CreateRelative(CreateRelativeDTO createRelativeDTO)
        {
            var relativeCreate = _mapper.Map<InformationRelative>(createRelativeDTO);
            if (createRelativeDTO == null)
            {
                return false;
            }
            else
            {
                await _unitOfWork.RelativeRepository.Add(relativeCreate);
                var result = _unitOfWork.Complete();
                if (result > 0)
                {
                    return true;
                }
                else return false;
            }
        }

        public async Task<bool> UpDateRelative(int id, UpdateRelativeDTO updateRelativeDTO)
        {
            if (id > 0)
            {
                var relative = await _unitOfWork.RelativeRepository.Get(id);
                _mapper.Map(updateRelativeDTO, relative);
                _unitOfWork.RelativeRepository.Update(relative);
                var result = _unitOfWork.Complete();
                if (result > 0)
                    return true;
                return false;
            }
            return false;
        }

        public async Task<bool> DeleteRelativeById(int id)
        {
            if (id > 0)
            {
                var relative = await _unitOfWork.RelativeRepository.Get(id);
                _unitOfWork.RelativeRepository.Delete(relative);
                var result = _unitOfWork.Complete();
                if (result > 0)
                {
                    return true;
                }
                return false;
            }
            return false;
        }
    }
}
