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
        public async Task<object> GetInforEmployee(string name)
        {

            var inforEp = await _unitOfWork
                                .EmployeeRepository
                                .GetMultiChild(include: ic =>
                                               ic.Include(c => c.InformationDepartment)
                                                 .Include(c => c.InformationEmployeeSkills)
                                                 .ThenInclude(tc => tc.InformationSkill)
                                                 .Include(c => c.InformationEmployeeLearnings)
                                                 .ThenInclude(tc => tc.InformationLearning)
                                                 );
            var result = inforEp.Where(c => c.LastName == name)
                                .Select(s =>
                                    new
                                    {
                                        FullName = $"{s.FirstName} {s.MiddleName} {s.LastName}",
                                        NumberPhone = s.PhoneNumber,
                                        Studing = s.InformationEmployeeLearnings
                                                  .Select(s =>
                                                          new
                                                          {
                                                              Major = s.Major,
                                                              University = s.InformationLearning.UniversityName
                                                          }),
                                        DepartmentName = s.InformationDepartment.Name,
                                        Skill = s.InformationEmployeeSkills
                                                .Select(s =>
                                                        new
                                                        {
                                                            Rating = s.Rating,
                                                            NameSkill = s.InformationSkill.Name
                                                        })

                                    });


            return result;
        }
    }
}
