using Microsoft.EntityFrameworkCore;
using PersonApi.Datas;
using System.Linq.Expressions;

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
                                                List<string> include = null)
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


    }
}
