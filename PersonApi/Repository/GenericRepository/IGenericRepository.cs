using PersonApi.Models;
using System.Linq.Expressions;
using X.PagedList;

namespace PersonApi.Repository.GenericRepository
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> Get(int id);
        Task<IEnumerable<T>> GetAll();
        Task Add(T entity);
        void Delete(T entity);
        void Update(T entity);

        ////////////////////////////////////////////////////////////
        Task<IList<T>> GetAllAsync(
            Expression<Func<T, bool>> expression = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            List<string> include = null
            );

        Task<IPagedList<T>> GetPageList(RequestParams requestParams, List<string> include = null );

    }
}
