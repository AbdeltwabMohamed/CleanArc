using Infrastracutre.Data;
using Infrastracutre.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastracutre.Repos
{
    public class BaseRepositry<T> : IBaseRepositry<T> where T : class
    {
        private readonly ApplicationDbContext dbContext;

        public BaseRepositry(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public IEnumerable<T> GetAll()
        {
         return   dbContext.Set<T>().ToList();
        }
    }
}
