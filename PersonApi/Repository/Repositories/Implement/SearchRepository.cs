using PersonApi.Datas;
using PersonApi.Models;
using PersonApi.Repository.GenericRepository;
using PersonApi.Repository.Repositories.Interfaces;

namespace PersonApi.Repository.Repositories.Implement
{
    public class SearchRepository : GenericRepository<InformationEmployee>, ISearchRepository
    {
        public SearchRepository(DatabaseContext context) : base(context)
        {
        }
    }
}
