using AutoMapper;
using PersonApi.DTO;
using PersonApi.Models;
using PersonApi.ModelsDTO;

namespace PersonApi.Configurations.Mapper
{
    public class MapperInitilier : Profile
    {
        public MapperInitilier()
        {
            CreateMap<InforEmployee, EmployeeDTO>().ReverseMap();
            CreateMap<InforEmployee, CreateEmployeeDTO>().ReverseMap();
            CreateMap<InforEmployee, ImportEmployeeRelativeDTO>().ReverseMap();


            CreateMap<InforDepartment, DepartmentDTO>().ReverseMap();
            CreateMap<InforDepartment, CreateDepartmentDTO>().ReverseMap();

            CreateMap<InforLearning, LearningDTO>().ReverseMap();
            CreateMap<InforLearning, CreateLearningDTO>().ReverseMap();

            CreateMap<InforRelative, RelativeDTO>().ReverseMap();
            CreateMap<InforRelative, CreateRelativeDTO>().ReverseMap();
            CreateMap<InforRelative, ImportEmployeeRelativeDTO>().ReverseMap();

            CreateMap<InforSalary, SalaryDTO>().ReverseMap();
            CreateMap<InforSalary, CreateSalaryDTO>().ReverseMap();
            CreateMap<CreateSalaryDTO,InforSalary>().ReverseMap();


            CreateMap<InforSkill, SkillDTO>().ReverseMap();
            CreateMap<InforSkill, CreateSkillDTO>().ReverseMap();

            CreateMap<InforEmployeeSkill, EmployeeSkillDTO>().ReverseMap();
            CreateMap<InforEmployeeSkill, CreateEmployeeSkillDTO>().ReverseMap();

            CreateMap<ApiUser, UserDTO>().ReverseMap();
            CreateMap<ApiUser, LoginUserDTO>().ReverseMap();




        }
    }
}
