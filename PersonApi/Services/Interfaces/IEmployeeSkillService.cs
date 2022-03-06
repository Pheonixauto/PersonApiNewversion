﻿using PersonApi.DTO;
using PersonApi.Models;

namespace PersonApi.Services.Interfaces
{
    public interface IEmployeeSkillService
    {
        Task<List<InformationEmployeeSkill>> GetAllEmployeeSkill();
 
        Task<List<InformationEmployeeSkill>> GetEmployeeSkillById(int id);
        Task<List<InformationEmployeeSkill>> GetAllDetail();
        Task<object> GetNameSkillEmployee();

        Task<bool> AddEmployeeSkill(CreateEmployeeSkillDTO createEmployeeSkillDTO);

        // nhân viên theo skill, rating
        Task<object> GetEmployeeBySkill(string skillName);
        Task<object> GetEmployeeByRating(double rating);

    }
}
