using Microsoft.EntityFrameworkCore;
using OstadECommerece.Api.Repositories.Interfaces;

namespace OstadECommerece.Api.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly AppDbContext _context;
        private readonly DbSet<T> _dbSet;

        public GenericRepository(AppDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        //public IEnumerable<T> GetAll() => _dbSet.ToList();
        public IEnumerable<T> GetAll()
        {
            return _dbSet.ToList();
        }


        public T? GetById(int id) => _dbSet.Find(id);
        public void Add(T entity) => _dbSet.Add(entity);
        public void Update(T entity) => _dbSet.Update(entity);
        public void Delete(T entity) => _dbSet.Remove(entity);
        public void Save() => _context.SaveChanges();
    }

}
