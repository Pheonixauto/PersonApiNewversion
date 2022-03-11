using AutoMapper;
using CsvHelper;
using CsvHelper.Configuration;
using Microsoft.EntityFrameworkCore;
using PersonApi.Datas;
using PersonApi.DTO;
using PersonApi.Models;
using PersonApi.ModelsDTO;
using PersonApi.Repository.UnitOfWork;
using PersonApi.SeedDataFromFile;
using PersonApi.Services.Interfaces;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;

namespace PersonApi.Services
{
    public class SearchService : ISearchService
    {
        public readonly IUnitOfWork _unitOfWork;
        public DatabaseContext _context;
        private readonly IMapper _mapper;

        public SearchService(IUnitOfWork unitOfWork, DatabaseContext context, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _context = context;
            _mapper = mapper;
        }

        public async Task<bool> GetEmployeeRelativeFromCSV()
        {
            using (var reader = new StreamReader(@"D:\ATSProject\PersonApi\PersonApi\SeedDataFromFile\EmployeeData.csv"))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture, leaveOpen: false))
            {
                csv.Context.RegisterClassMap<EmployeeRelativeMap>();
                var records1 = csv.GetRecords<EmployeeRelativeDTO>();
                foreach (var item in records1)
                {
                    var result1 = _mapper.Map<InformationEmployee>(item);
                    var result2 = _mapper.Map<InformationRelative>(item);
                    await _unitOfWork.EmployeeRepository.Add(result1);
                    await _unitOfWork.RelativeRepository.Add(result2);
                }
                var br = _unitOfWork.Complete();
                if (br > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

        }
        public async Task<object> GetInforDepartment(string name)
        {
            var infDep = await _unitOfWork.DepartmentRepository.GetMultiChild(include: ic =>
                                         ic.Include(c => c.InformationEmployees)
            );
            var result = infDep.Where(c => c.Name == name).Select(s => new { Name = s.Name, NumberEmployee = s.NumberEmployee, EmployeesName = s.InformationEmployees.Select(s1 => s1.LastName) });
            return result;
        }

        public async Task<object> GetInforEmployee(string name)
        {
            var inforEp = await _unitOfWork
                                .EmployeeRepository
                                .GetMultiChild(include: ic
                                  => ic.Include(c => c.InformationDepartment)
                                       .Include(c => c.InformationEmployeeSkills)
                                       .ThenInclude(tc => tc.InformationSkill)
                                       .Include(c => c.InformationEmployeeLearnings)
                                       .ThenInclude(tc => tc.InformationLearning)
                                       .Include(c => c.InformationPosition)
                                               );
            var result = inforEp.Where(c => c.LastName == name)
                                .Select(s => new
                                {
                                    FullName = $"{s.FirstName} {s.MiddleName} {s.LastName}",
                                    NumberPhone = s.PhoneNumber,
                                    Studing = s.InformationEmployeeLearnings
                                               .Select(s => new
                                               {
                                                   Major = s.Major,
                                                   University = s.InformationLearning.UniversityName
                                               }),
                                    Position = s.InformationPosition?.Name,
                                    DepartmentName = s.InformationDepartment?.Name,
                                    Skill = s.InformationEmployeeSkills
                                              .Select(s => new
                                              {
                                                  Rating = s.Rating,
                                                  NameSkill = s.InformationSkill.Name
                                              })
                                });
            return result;
        }


    }
}
