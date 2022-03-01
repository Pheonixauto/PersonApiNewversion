using PersonApi.Models;
using PersonApi.Repository.GenericRepository;

namespace PersonApi.Repository.Repositories
{
    public interface IEmployeeRepository : IGenericRepository<InformationEmployee>
    {
    }
}
