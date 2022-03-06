using PersonApi.Repository.UnitOfWork;
using PersonApi.Services.Interfaces;

namespace PersonApi.Services
{
    public class EmployeeLearningService : IEmployeeLearningService
    {
        public IUnitOfWork _unitOfWork;
        public EmployeeLearningService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<object> GetEmployeeBySchoolName(string schoolName)
        {
            List<string> include = new List<string> { "InformationEmployee", "InformationLearning" };
            var employeeLearning = await _unitOfWork.EmployeeLearningRepository.GetAllAsync(null, null, include);
            var result = employeeLearning.Where(x => x.InformationLearning.UniversityName == schoolName)
                                        .Select(x => x.InformationEmployee.LastName);
            return result;
        }
    }
}
