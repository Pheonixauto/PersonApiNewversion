using AutoMapper;
using PersonApi.Models;
using PersonApi.ModelsDTO;
using PersonApi.Repository.UnitOfWork;
using PersonApi.Services.Interfaces;
using X.PagedList;

namespace PersonApi.Services
{
    public class DepartmentService : IDepartmentService
    {
        public IUnitOfWork _unitOfWork;
        private IMapper _mapper;
        public DepartmentService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<bool> CreateDepartment(CreateDepartmentDTO createDepartmentDTO)
        {
            if (createDepartmentDTO == null)
            {
                return false;
            }
            var newDepartment = _mapper.Map<InformationDepartment>(createDepartmentDTO);
            await _unitOfWork.DepartmentRepository.Add(newDepartment);
            var result = (_unitOfWork.Complete() > 0) ? true : false;
            //if (result > 0)
            //    return true;
            //else return false;
            return result;
        }

        public async Task<bool> DeleteDepartment(int id)
        {
            if (id > 0)
            {
                var department = await _unitOfWork.DepartmentRepository.Get(id);
                _unitOfWork.DepartmentRepository.Delete(department);
                var ressult = _unitOfWork.Complete();
                if (ressult > 0)
                {
                    return true;
                }
                else return false;
            }
            return false;
        }

        public async Task<List<InformationDepartment>> GetAllDepartment()
        {
            var departments = await _unitOfWork.DepartmentRepository.GetAll();
            return (List<InformationDepartment>)departments;
        }

        public async Task<InformationDepartment> GetDepartment(int id)
        {
            if (id > 0)
            {
                var department = await _unitOfWork.DepartmentRepository.Get(id);

                if (department == null)
                {
                    return null;
                }
                return department;
            }
            return null;
        }

        public async Task<IPagedList<InformationDepartment>> GetDepartmentPagedList(RequestParams requestParams)
        {
            var departmentList = await _unitOfWork.DepartmentRepository.GetPageList(requestParams, null);
            return departmentList;
        }

        public async Task<bool> UpdateDepartment(int id, UpdateDepartmentDTO updateDepartmentDTO)
        {
            if (id > 0)
            {
                var department = await _unitOfWork.DepartmentRepository.Get(id);
                _mapper.Map(updateDepartmentDTO, department);
                _unitOfWork.DepartmentRepository.Update(department);
                _unitOfWork.Complete();
                return true;
            }
            return false;
        }
    }
}
