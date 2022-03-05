using AutoMapper;
using PersonApi.Models;
using PersonApi.ModelsDTO;
using PersonApi.Repository.UnitOfWork;
using PersonApi.Services.Interfaces;
using System.Linq;
using X.PagedList;

namespace PersonApi.Services
{
    public class SalaryService : ISalaryService
    {
        public IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public SalaryService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<bool> CreateSalary(CreateSalaryDTO createSalaryDTO)
        {
            if (createSalaryDTO != null)
            {
                var salaryMap = _mapper.Map<InformationSalary>(createSalaryDTO);
                await _unitOfWork.SalaryRepository.Add(salaryMap);
                var result = _unitOfWork.Complete();
                if (result > 0)
                {
                    return true;
                }
                else return false;
            }
            return false;
        }

        public async Task<bool> DeleteSalaryById(int id)
        {
            if (id > 0)
            {
                var salary = await _unitOfWork.SalaryRepository.Get(id);
                _unitOfWork.SalaryRepository.Delete(salary);
                var result = _unitOfWork.Complete();
                if (result > 0)
                {
                    return true;
                }
                else return false;
            }
            return false;
        }

        public async Task<List<InformationSalary>> GetAllSalary()
        {
            var salaryList = await _unitOfWork.SalaryRepository.GetAll();
            return (List<InformationSalary>)salaryList;
        }

        public async Task<InformationSalary> GetSalaryById(int id)
        {
            if (id > 0)
            {
                var salary = await _unitOfWork.SalaryRepository.Get(id);
                return (InformationSalary)salary;
            }
            return null;
        }

        public async Task<bool> UpdateSalary(int id, UpdateSalaryDTO updateSalaryDTO)
        {
            if (id > 0)
            {
                var salary = await _unitOfWork.SalaryRepository.Get(id);
                if (salary != null)
                {
                    _mapper.Map(updateSalaryDTO, salary);
                    _unitOfWork.SalaryRepository.Update(salary);
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

        public async Task<IPagedList<InformationSalary>> GetSalaryPagedList(RequestParams requestParams)
        {
            var salaryList = await _unitOfWork.SalaryRepository.GetPageList(requestParams, null);
            return salaryList;
        }

        public async Task<List<InformationSalary>> GetSalaryByDate(DateTime date1, DateTime date2)
        {

            var salaryList = await _unitOfWork.SalaryRepository.GetAll();
            var salaryByDate = from x in salaryList
                               where x.DateTime >= date1 && x.DateTime <= date2
                               select x;
            return salaryByDate.ToList();

        }

        public async Task<object> GetSalaryByDepartment(string departmentName, DateTime date1, DateTime date2)
        {
            List<string> include = new List<string> { "InformationDepartment", "InformationSalaries" };
            var employeeList = await _unitOfWork.EmployeeRepository.GetAllAsync(null, null, include);
            var query = from employee in employeeList
                        where employee.InformationDepartment.Name == departmentName

                        select employee.InformationSalaries
                                       .Where(d => d.DateTime <= date2 && d.DateTime >= date1)
                                       .Select((x, y) =>
                                       new
                                       {
                                           x.InformationEmployee.LastName,
                                           x.DateTime,
                                           x.Salary,
                                           x.Tax,
                                       }
                                       );

            return query;
        }
    }
}
