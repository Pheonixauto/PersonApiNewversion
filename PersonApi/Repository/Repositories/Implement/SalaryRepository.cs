using PersonApi.Datas;
using PersonApi.Models;
using PersonApi.Repository.GenericRepository;
using PersonApi.Repository.Repositories.Interfaces;

namespace PersonApi.Repository.Repositories.Implement
{
    public class SalaryRepository : GenericRepository<InforSalary>, ISalaryRepository
    {
        public SalaryRepository(DatabaseContext context) : base(context)
        {
        }
    }
}
