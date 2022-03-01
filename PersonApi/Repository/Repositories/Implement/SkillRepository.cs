using PersonApi.Datas;
using PersonApi.Models;
using PersonApi.Repository.GenericRepository;

namespace PersonApi.Repository.Repositories.Implement
{
    public class SkillRepository : GenericRepository<InformationSkill>, ISkillRepository
    {
        public SkillRepository(DatabaseContext context) : base(context)
        {
        }
    }
}
