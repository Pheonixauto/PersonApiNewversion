using PersonApi.Datas;
using PersonApi.Models;
using PersonApi.Repository.GenericRepository;
using PersonApi.Repository.Repositories.Interfaces;

namespace PersonApi.Repository.Repositories.Implement
{
    public class SalaryRepository : GenericRepository<InformationSalary>, ISalaryRepository
    {
        public SalaryRepository(DatabaseContext context) : base(context)
        {
        }
    }
}
