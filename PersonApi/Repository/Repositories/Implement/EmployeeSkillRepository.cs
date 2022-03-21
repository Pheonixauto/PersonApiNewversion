using PersonApi.Datas;
using PersonApi.Models;
using PersonApi.Repository.GenericRepository;
using PersonApi.Repository.Repositories.Interfaces;

namespace PersonApi.Repository.Repositories.Implement
{
    public class EmployeeSkillRepository : GenericRepository<InforEmployeeSkill>, IEmployeeSkillRepository
    {
        public EmployeeSkillRepository(DatabaseContext context) : base(context)
        {
        }
    }
}
