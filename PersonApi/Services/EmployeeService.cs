using AutoMapper;
using PersonApi.Models;
using PersonApi.ModelsDTO;
using PersonApi.Repository.UnitOfWork;
using PersonApi.Services.Interfaces;
using X.PagedList;

namespace PersonApi.Services
{
    public class EmployeeService : IEmployeeService
    {
        public IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public EmployeeService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        #region Create new employee
        public async Task<bool> CreateNewEmployee(CreateEmployeeDTO createEmployeeDTO)
        {
            if (createEmployeeDTO != null)
            {
                var newEmployee = _mapper.Map<InforEmployee>(createEmployeeDTO);
                await _unitOfWork.EmployeeRepository.Add(newEmployee);

                var result = _unitOfWork.Complete();

                if (result > 0)
                    return true;
                else
                    return false;
            }
            return false;
        }
        #endregion

        public async Task<bool> DeleteEmployee(int employeeId)
        {
            if (employeeId > 0)
            {
                var employee = await _unitOfWork.EmployeeRepository.Get(employeeId);
                if (employee != null)
                {
                    _unitOfWork.EmployeeRepository.Delete(employee);
                    var result = _unitOfWork.Complete();

                    if (result > 0)
                        return true;
                    else
                        return false;
                }
            }
            return false;
        }

        public async Task<List<InforEmployee>> GetAllEmployees()
        {
            var employeeList = await _unitOfWork.EmployeeRepository.GetAll();
            return (List<InforEmployee>)employeeList;
        }

        public async Task<InforEmployee> GetEmployeeById(int employeeId)
        {
            if (employeeId > 0)
            {
                var emloyee = await _unitOfWork.EmployeeRepository.Get(employeeId);
                if (emloyee != null)
                {
                    var result = _mapper.Map<InforEmployee>(emloyee);
                    return result;
                }
            }
            return null;
        }

        public async Task<bool> UpdateEmployee(int employeeId, CreateEmployeeDTO createEmployeeDTO)
        {
            if (employeeId > 0)
            {
                var employee = await _unitOfWork.EmployeeRepository.Get(employeeId);
                if (employee != null)
                {
                    _mapper.Map(createEmployeeDTO, employee);
                    _unitOfWork.EmployeeRepository.Update(employee);
                    _unitOfWork.Complete();
                    return true;
                }
            }
            return false;
        }

        public async Task<IPagedList<InforEmployee>> GetEmployeePagedList(RequestParams requestParams)
        {
            var employeeList = await _unitOfWork.EmployeeRepository.GetPageList(requestParams, null);
            return employeeList;
        }

    }
}
