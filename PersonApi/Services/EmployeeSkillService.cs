using PersonApi.Migrations;
using PersonApi.Models;
using PersonApi.Repository.UnitOfWork;
using PersonApi.Services.Interfaces;
using System.Collections.Generic;

namespace PersonApi.Services
{
    public class EmployeeSkillService: IEmployeeSkillService
    {
        public IUnitOfWork _unitOfWork;
        public EmployeeSkillService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<List<InformationEmployeeSkill>> GetAllEmployeeSkill()
        {
            var employeeSkillList = await _unitOfWork.EmployeeSkillRepository.GetAll();
            return (List<InformationEmployeeSkill>)employeeSkillList;
        }     

        public async Task<List<InformationEmployeeSkill>> GetAllDetail()
        {
            List<string> include = new List<string> { "InformationSkill", "InformationEmployee" };
            var list = await _unitOfWork.EmployeeSkillRepository.GetAllAsync(null,null, include);
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
                        select new {x.InformationSkill.Name, x.InformationEmployee.LastName};
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
    }
}
