using AutoMapper;
using PersonApi.Models;
using PersonApi.ModelsDTO;
using PersonApi.Repository.UnitOfWork;
using PersonApi.Services.Interfaces;
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
                var salaryMap = _mapper.Map<InforSalary>(createSalaryDTO);
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

        public async Task<List<InforSalary>> GetAllSalary()
        {
            var salaryList = await _unitOfWork.SalaryRepository.GetAll();
            return (List<InforSalary>)salaryList;
        }

        public async Task<InforSalary> GetSalaryById(int id)
        {
            if (id > 0)
            {
                var salary = await _unitOfWork.SalaryRepository.Get(id);
                return (InforSalary)salary;
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

        public async Task<IPagedList<InforSalary>> GetSalaryPagedList(RequestParams requestParams)
        {
            var salaryList = await _unitOfWork.SalaryRepository.GetPageList(requestParams, null);
            return salaryList;
        }

        public async Task<List<InforSalary>> GetSalaryByDate(DateTime date1, DateTime date2)
        {

            var salaryList = await _unitOfWork.SalaryRepository.GetAll();
            var salaryByDate = from x in salaryList
                               where x.DateTime >= date1 && x.DateTime <= date2
                               select x;
            return salaryByDate.ToList();

        }
        // danh sách lương theo phòng ban - ngày tháng
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

        // tổng lương công ty
        public async Task<object> GetSalaryCompany(DateTime date1)
        {
            List<string> include = new List<string> { "InformationDepartment", "InformationSalaries" };
            var employeeList = await _unitOfWork.EmployeeRepository.GetAllAsync(null, null, include);

            //var r1 = result.Select((x, y) =>
            //                           x.Select((y) =>
            //                                    new { Department = y.InformationDepartment.Name, Count = y.InformationSalaries.Sum((s) =>
            //                                                                 s.Salary))
            //                                                          .Sum()}
            //                       );
            var result = employeeList.Select(x => new
            {
                name = x.InformationDepartment.Name,
                totalsalary = x.InformationSalaries.Where(x => x.DateTime == date1).Sum(y => y.Salary)
            });
            var result1 = result.GroupBy(x => x.name).Select(x => new { NameDepartment = x.Key, SalaryTotal = x.Select(x => x.totalsalary).Sum() });
            return result1;
        }

        public async Task<object> GetEmployeeSalary(int identityNumber)
        {
            List<string> include = new List<string> { "InformationSalaries" };
            var employeeList = await _unitOfWork.EmployeeRepository.GetAllAsync(null, null, include);
            var result = employeeList.Where(x => x.IdentityNumber == identityNumber)
                                    .Select(x => x.InformationSalaries);
            var re = result.Select(x => x.Select(y => new { y.DateTime, y.Salary, y.Tax }));
            return re;
        }

        public async Task<IEnumerable<CreateSalaryDTO>> GetFileSalariesByDepartment(string departmentName, DateTime date)
        {
            List<CreateSalaryDTO> createSalaryDTOs = new List<CreateSalaryDTO>();

            List<string> include = new List<string> { "InformationDepartment", "InformationSalaries" };
            var employeeList = await _unitOfWork.EmployeeRepository.GetAllAsync(null, null, include);
            var employees = employeeList.Where(x => x.InformationDepartment.Name == departmentName);

            foreach (var item in employees)
            {
               foreach(var i in item.InformationSalaries)
                {
                    createSalaryDTOs.Add(new CreateSalaryDTO { DateTime=i.DateTime, EmployeeId=i.EmployeeId,Salary=i.Salary,Tax=i.Tax});
                }
            }

            var result = createSalaryDTOs.Where(x => x.DateTime.Month == date.Month);

            return result;


         
        }
    }
}
