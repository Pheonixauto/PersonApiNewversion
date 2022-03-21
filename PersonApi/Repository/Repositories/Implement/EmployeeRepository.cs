using PersonApi.Datas;
using PersonApi.Models;
using PersonApi.Repository.GenericRepository;

namespace PersonApi.Repository.Repositories.Implement
{
    public class EmployeeRepository : GenericRepository<InforEmployee>, IEmployeeRepository
    {
        public EmployeeRepository(DatabaseContext context) : base(context)
        {
        }
    }
}
