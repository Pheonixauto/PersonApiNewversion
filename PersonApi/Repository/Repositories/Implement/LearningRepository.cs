using PersonApi.Datas;
using PersonApi.Models;
using PersonApi.Repository.GenericRepository;
using PersonApi.Repository.Repositories.Interfaces;

namespace PersonApi.Repository.Repositories.Implement
{
    public class LearningRepository : GenericRepository<InformationLearning>, ILearningRepository
    {
        public LearningRepository(DatabaseContext context) : base(context)
        {
        }
    }
}
