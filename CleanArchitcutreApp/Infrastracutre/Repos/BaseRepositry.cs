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

        public T Delete(T item)
        {
            dbContext.Set<T>().Remove(item);
            dbContext.SaveChanges();
            return item;
        }



        public IQueryable<T> GetAll()
        {
            return dbContext.Set<T>().AsNoTracking();
        }

        public async Task<T> GetById(int id)
        {
            return await dbContext.Set<T>().FindAsync(id);


        }
        public T Update(T item)
        {
            dbContext.Set<T>().Update(item);
            dbContext.SaveChanges();
            return item;
        }

    }
}
