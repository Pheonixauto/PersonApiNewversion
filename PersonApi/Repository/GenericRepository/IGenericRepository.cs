using Microsoft.EntityFrameworkCore.Query;
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
        Task<IList<T>> GetMultiChild(Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null);
        Task<IPagedList<T>> GetPageList(RequestParams requestParams, List<string> include = null);


        ////////////////////////////////////////////////////////////
        Task<IList<T>> GetAllAsync(
            Expression<Func<T, bool>> expression = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            List<string> include = null
            );

        //////////////////////////////////////

        // Get table-children- child.
        Task<IList<T>> GetAllMutil(Expression<Func<T, T>> selector,
                                   Expression<Func<T, bool>> predicate = null,
                                   Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
                                   Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null
                                   );
    }
}
