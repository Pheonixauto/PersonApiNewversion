using PersonApi.Datas;
using PersonApi.Models;
using PersonApi.Repository.GenericRepository;
using PersonApi.Repository.Repositories.Interfaces;

namespace PersonApi.Repository.Repositories.Implement
{
    public class RelativeRepository : GenericRepository<InformationRelative>, IRelativeRepository
    {
        public RelativeRepository(DatabaseContext context) : base(context)
        {
        }
    }
}
