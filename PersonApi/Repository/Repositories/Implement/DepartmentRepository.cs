using PersonApi.Datas;
using PersonApi.Models;
using PersonApi.Repository.GenericRepository;
using PersonApi.Repository.Repositories.Interfaces;

namespace PersonApi.Repository.Repositories.Implement
{
    public class DepartmentRepository : GenericRepository<InformationDepartment>, IDepartmentRepository
    {
        public DepartmentRepository(DatabaseContext context) : base(context)
        {
        }
    }
}
