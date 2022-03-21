using PersonApi.Datas;
using PersonApi.Models;
using PersonApi.Repository.GenericRepository;
using PersonApi.Repository.Repositories.Interfaces;

namespace PersonApi.Repository.Repositories.Implement
{
    public class LearningRepository : GenericRepository<InforLearning>, ILearningRepository
    {
        public LearningRepository(DatabaseContext context) : base(context)
        {
        }
    }
}
