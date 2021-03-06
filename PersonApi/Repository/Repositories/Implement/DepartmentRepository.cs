using PersonApi.Datas;
using PersonApi.Models;
using PersonApi.Repository.GenericRepository;
using PersonApi.Repository.Repositories.Interfaces;

namespace PersonApi.Repository.Repositories.Implement
{
    public class DepartmentRepository : GenericRepository<InforDepartment>, IDepartmentRepository
    {
        public DepartmentRepository(DatabaseContext context) : base(context)
        {
        }
    }
}
