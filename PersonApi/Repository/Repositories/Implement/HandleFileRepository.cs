using PersonApi.Datas;
using PersonApi.Models;
using PersonApi.Repository.GenericRepository;
using PersonApi.Repository.Repositories.Interfaces;

namespace PersonApi.Repository.Repositories.Implement
{
    public class HandleFileRepository : GenericRepository<InforEmployee>, IHandleFileRepository
    {
        public HandleFileRepository(DatabaseContext context) : base(context)
        {

        }
    }
}
