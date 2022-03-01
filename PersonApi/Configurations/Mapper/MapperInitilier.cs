﻿using AutoMapper;
using PersonApi.Models;
using PersonApi.ModelsDTO;

namespace PersonApi.Configurations.Mapper
{
    public class MapperInitilier : Profile
    {
        public MapperInitilier()
        {
            CreateMap<InformationEmployee, EmployeeDTO>().ReverseMap();
            CreateMap<InformationEmployee, CreateEmployeeDTO>().ReverseMap();


            CreateMap<InformationDepartment, DepartmentDTO>().ReverseMap();
            CreateMap<InformationDepartment, CreateDepartmentDTO>().ReverseMap();

            CreateMap<InformationLearning, LearningDTO>().ReverseMap();
            CreateMap<InformationLearning, CreateLearningDTO>().ReverseMap();

            CreateMap<InformationRelative, RelativeDTO>().ReverseMap();
            CreateMap<InformationRelative, CreateRelativeDTO>().ReverseMap();

            CreateMap<InformationSalary, SalaryDTO>().ReverseMap();
            CreateMap<InformationSalary, CreateSalaryDTO>().ReverseMap();

            CreateMap<InformationSkill, SkillDTO>().ReverseMap();
            CreateMap<InformationSkill, CreateSkillDTO>().ReverseMap();

            CreateMap<ApiUser, UserDTO>().ReverseMap();
            CreateMap<ApiUser, LoginUserDTO>().ReverseMap();


        }
    }
}
