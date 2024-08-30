using Infrastracutre.Data;
using Infrastracutre.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infrastracutre.Repos
{
    public class BaseRepositry<T> : IBaseRepositry<T> where T : class
    {
        private readonly ApplicationDbContext dbContext;

        public BaseRepositry(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public T Add(T item)
        {
            dbContext.Set<T>().Add(item);
            dbContext.SaveChanges();
            return item;
        }

        public IEnumerable<T> GetAll()
        {
            return dbContext.Set<T>().AsNoTracking().ToList().AsQueryable();
        }

        public T GetById(int id)
        {
            return dbContext.Set<T>().Find(id);
        }
        public T Update(T item)
        {
            dbContext.Set<T>().Update(item);
            dbContext.SaveChanges();
            return item;
        }

    }
}
