using Microsoft.EntityFrameworkCore;
using PersonApi.Datas;
using PersonApi.Models;
using PersonApi.Repository.UnitOfWork;
using PersonApi.Services.Interfaces;
using System.ComponentModel;
using System.Linq;

namespace PersonApi.Services
{
    public class SearchService : ISearchService
    {
        public readonly IUnitOfWork _unitOfWork;
        public DatabaseContext _context;
        public SearchService(IUnitOfWork unitOfWork, DatabaseContext context)
        {
            _unitOfWork = unitOfWork;
            _context = context;
        }
        public async Task<object> GetInfor(string something)
        {
            List<string> include = new List<string> { "InformationDepartment",
                                                      "InformationEmployeeLearnings"
                                                        };

            var employee = await _unitOfWork.EmployeeRepository.GetAllAsync(null, null, include);

            var emp = await _context.informationEmployees
                             .Include(c => c.InformationDepartment)
                             .Include(c => c.InformationEmployeeLearnings)
                             .ThenInclude(t => t.InformationLearning).ToListAsync();

            if (something == null)
            {
                return null;
            }
            string name = something;
            int id;
            DateTime dateTime;
            bool bid = Int32.TryParse(something, out id);
            bool bdatetime = DateTime.TryParse(something, out dateTime);

            if (bid == true)
            {
                var result1 = employee.Where(x => x.Id == id || x.IdentityNumber == id).Select(x => x.LastName);
                return result1;
            }
            if (bdatetime == true)
            {
                var result2 = employee.Where(x => x.BirthDay == dateTime).Select(x => x.LastName);
                return result2;
            }
            var result = emp.Where(x => x.LastName == name).Select(x =>
                                          new
                                          {
                                              FullName = x.FirstName + " " + x.MiddleName + " " + x.LastName,
                                              Department = x.InformationDepartment?.Name,
                                              Learning = x.InformationEmployeeLearnings.Select(x => x.InformationLearning.UniversityName)
                                          }
                                        );
            return result;
        }
    }
}
