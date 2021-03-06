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
            var newDepartment = _mapper.Map<InforDepartment>(createDepartmentDTO);
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

        public async Task<List<InforDepartment>> GetAllDepartment()
        {
            var departments = await _unitOfWork.DepartmentRepository.GetAll();
            return (List<InforDepartment>)departments;
        }

        public async Task<InforDepartment> GetDepartment(int id)
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

        public async Task<IPagedList<InforDepartment>> GetDepartmentPagedList(RequestParams requestParams)
        {
            List<string> include = new List<string> { "InformationEmployees" };
            var departmentList = await _unitOfWork.DepartmentRepository.GetPageList(requestParams, include);
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
