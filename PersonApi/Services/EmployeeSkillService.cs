
using AutoMapper;
using PersonApi.DTO;
using PersonApi.Models;
using PersonApi.Repository.UnitOfWork;
using PersonApi.Services.Interfaces;
using System.Collections.Generic;

namespace PersonApi.Services
{
    public class EmployeeSkillService : IEmployeeSkillService
    {
        public IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public EmployeeSkillService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<List<InformationEmployeeSkill>> GetAllEmployeeSkill()
        {
            var employeeSkillList = await _unitOfWork.EmployeeSkillRepository.GetAll();
            return (List<InformationEmployeeSkill>)employeeSkillList;
        }

        public async Task<List<InformationEmployeeSkill>> GetAllDetail()
        {
            List<string> include = new List<string> { "InformationSkill", "InformationEmployee" };
            var list = await _unitOfWork.EmployeeSkillRepository.GetAllAsync(null, null, include);
            var query = from x in list
                        select x.InformationSkill.Name;
            return (List<InformationEmployeeSkill>)list;
        }

        public async Task<object> GetNameSkillEmployee()
        {
            List<string> include = new List<string> { "InformationSkill", "InformationEmployee" };
            var list = await _unitOfWork.EmployeeSkillRepository.GetAllAsync(null, null, include);
            var query = from x in list
                        where x.InformationEmployee.LastName == "A2"
                        select new { x.InformationSkill.Name, x.InformationEmployee.LastName };
            return query;
        }
        public async Task<List<InformationEmployeeSkill>> GetEmployeeSkillById(int id)
        {
            var list = await _unitOfWork.EmployeeSkillRepository.GetAll();

            var query = from re in list
                        where re.EmployId == id
                        select re;
            return query.ToList();

        }

        public async Task<bool> AddEmployeeSkill(CreateEmployeeSkillDTO createEmployeeSkillDTO)
        {
            var empSkillMap = _mapper.Map<InformationEmployeeSkill>(createEmployeeSkillDTO);
            await _unitOfWork.EmployeeSkillRepository.Add(empSkillMap);
            var result = _unitOfWork.Complete();
            if (result > 0)
            {
                return true;
            }
            else return false;
        }

        public async Task<object> GetEmployeeBySkill(string skillName)
        {
            List<string> include = new List<string> { "InformationEmployee", "InformationSkill" };
            var employeeSkill = await _unitOfWork.EmployeeSkillRepository.GetAllAsync(null, null, include);
            var result = employeeSkill.Where(x => x.InformationSkill.Name == skillName)
                                     .Select(x => x.InformationEmployee.LastName);
            var count = result.Count();
            return new { result, count };
        }

        public async Task<object> GetEmployeeByRating(double rating)
        {
            List<string> include = new List<string> { "InformationEmployee", "InformationSkill" };
            var employeeSkill = await _unitOfWork.EmployeeSkillRepository.GetAllAsync(null, null, include);
            var result = employeeSkill.Where(x => x.Rating == rating)
                                      .Select(x => x.InformationEmployee.LastName);
            return result;
        }
    }
}
