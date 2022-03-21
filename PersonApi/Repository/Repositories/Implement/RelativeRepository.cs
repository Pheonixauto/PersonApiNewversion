using PersonApi.Datas;
using PersonApi.Models;
using PersonApi.Repository.GenericRepository;
using PersonApi.Repository.Repositories.Interfaces;

namespace PersonApi.Repository.Repositories.Implement
{
    public class RelativeRepository : GenericRepository<InforRelative>, IRelativeRepository
    {
        public RelativeRepository(DatabaseContext context) : base(context)
        {
        }
    }
}
