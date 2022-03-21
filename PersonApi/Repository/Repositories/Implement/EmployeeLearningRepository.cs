using PersonApi.Datas;
using PersonApi.Models;
using PersonApi.Repository.GenericRepository;
using PersonApi.Repository.Repositories.Interfaces;

namespace PersonApi.Repository.Repositories.Implement
{
    public class EmployeeLearningRepository : GenericRepository<InforEmployeeLearning>, IEmployeeLearningRepository
    {
        public EmployeeLearningRepository(DatabaseContext context) : base(context)
        {
        }
    }
}
