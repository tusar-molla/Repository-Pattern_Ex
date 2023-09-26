using Microsoft.EntityFrameworkCore;
using Repository_Pattern_Ex.Models;
using System.Linq.Expressions;

namespace Repository_Pattern_Ex.Repository
{
    public interface IRepositoryBase<T>
    {
        IQueryable<T> FindAll();
        IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression);
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected RepositoryContext _context;
        private DbSet<T> _dbset;
        public RepositoryBase(RepositoryContext context )
        {
            _context=context;
            _dbset=_context.Set <T>();
        }
        public void Create(T entity)
        {
            _context.Add(entity);
        }

        public void Delete(T entity)
        {
            _context.Remove(entity);
        }

        public IQueryable<T> FindAll()
        {
          return  _dbset.AsNoTracking();
        }


        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression)
        {
            return _dbset.Where(expression).AsNoTracking();
        }

        public void Update(T entity)
        {
            _context.Update(entity);
        }
    }
}
