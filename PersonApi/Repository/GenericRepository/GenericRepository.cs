using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using PersonApi.Datas;
using PersonApi.Models;
using System.Linq.Expressions;
using X.PagedList;

namespace PersonApi.Repository.GenericRepository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly DatabaseContext _context;

        protected GenericRepository(DatabaseContext context)
        {
            _context = context;
        }


        public async Task Add(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
        }

        public void Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
        }

        public async Task<T> Get(int id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public void Update(T entity)
        {
            _context.Set<T>().Update(entity);
        }
        ///////////////////////////////////////////////
        public async Task<IList<T>> GetAllAsync(Expression<Func<T, bool>> expression = null,
                                                Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
                                                List<string> include = null
                                                )
        {
            IQueryable<T> query = _context.Set<T>();
            if (expression != null)
            {
                query = query.Where(expression);
            }

            if (include != null)
            {
                foreach (var incudePropery in include)
                {
                    query = query.Include(incudePropery);
                }
            }
            if (orderBy != null)
            {
                query = orderBy(query);
            }

            return await query.AsNoTracking().ToListAsync();
        }

        public async Task<IPagedList<T>> GetPageList(RequestParams requestParams, List<string> include = null
                                                     )
        {
            IQueryable<T> query = _context.Set<T>();


            if (include != null)
            {
                foreach (var incudePropery in include)
                {
                    query = query.Include(incudePropery);
                }
            }

            return await query.AsNoTracking().ToPagedListAsync(requestParams.PageNumber, requestParams.PageSize);
        }
        ///////test
        public async Task<IList<T>> GetAllMutil(Expression<Func<T, T>> selector,
                                      Expression<Func<T, bool>> predicate = null,
                                      Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
                                      Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null
                                     )
        {
            IQueryable<T> query = _context.Set<T>();
     

            if (include != null)
            {
                query = include(query);
            }

            if (predicate != null)
            {
                query = query.Where(predicate);
            }

            if (orderBy != null)
            {
                query = (IQueryable<T>)orderBy(query).Select(selector).FirstOrDefault();
            }
            //else
            //{
            //    query = (IQueryable<T>)query.Select(selector).FirstOrDefault();
            //}
            return await query.AsNoTracking().ToListAsync();

        }

        public async Task<IList<T>> GetMultiChild(Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null)
        {
            IQueryable<T> query = _context.Set<T>();

            if (include != null)
            {
                query = include(query);
            }
            return await query.AsNoTracking().ToListAsync();
        }
    }
}
